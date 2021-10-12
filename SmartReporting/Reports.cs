using SmartHelper;
using SmartInterfaces;
using SmartLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartReporting
{
    public static class Reports
    {
        public static DataTable Transactional(Statement _statement)
        {

            DataTable results = null;
            try
            {
                string _selectClause = @"WITH CTE_Trans AS (
                                        SELECT  t.ClientID, t.TransactionDate, t.PaymentDate,tt.Code AS TransCode , CASE WHEN a.Name IS NOT NULL THEN CONCAT(t.TransRef,' : ', a.Name) ELSE CONCAT(t.TransRef,' : ', t.Narration) END AS Counter,t.Amount,p.Name AS Entity,t.TransactionID,t.ParentPaymentID
                                        FROM Transactions t
                                        INNER JOIN Products p ON p.ProductID=t.ProductID
                                        INNER JOIN TransactionType tt ON t.TransactionTypeID=tt.TransactionTypeID
										LEFT JOIN AssertCategories a ON t.AssertCategoryID=a.AssertCategoryID
                                       UNION ALL
                                        SELECT  t.ClientID, t.TransactionDate, t.PaymentDate,tt.Code AS TransCode ,CONCAT(t.TransRef,' : ', t.Narration) AS Counter,t.Amount,c.Title AS Entity,t.TransactionID,t.ParentPaymentID
                                        FROM Transactions t
                                        INNER JOIN Courses c ON c.CourseID=t.CourseID
                                        INNER JOIN TransactionType tt ON t.TransactionTypeID=tt.TransactionTypeID
                                        )
                                        SELECT * FROM CTE_Trans t ";
                string sqlQuery = _selectClause + $"WHERE t.ClientID={_statement.ClientID}  AND t.TransactionDate>'{_statement.StartDate.ToString("yyyy-MM-dd")}' AND t.TransactionDate < '{ _statement.EndDate.ToString("yyyy-MM-dd")}'";
                results = GetData.GetDataTable(sqlQuery);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
            }
            return results;
        }
        public static DataTable ProductBased(Statement _statement)
        {

            DataTable results = null;
            try
            {
                string _selectClause = @"SELECT t.PaymentDate,t.TransactionDate,tt.Code AS TransCode ,CASE WHEN a.Name IS NOT NULL THEN CONCAT(t.TransRef,' : ', a.Name) ELSE CONCAT(t.TransRef,' : ', t.Narration) END AS Counter,t.Amount,p.Name AS Product,t.TransactionID,t.ParentPaymentID
                                            FROM Transactions t
                                            INNER JOIN Products p ON p.ProductID=t.ProductID
                                            INNER JOIN TransactionType tt ON t.TransactionTypeID=tt.TransactionTypeID
                                            LEFT JOIN AssertCategories a ON t.AssertCategoryID=a.AssertCategoryID  ";
                string sqlQuery = _selectClause + $"WHERE t.ClientID={_statement.ClientID}  AND t.TransactionDate>'{_statement.StartDate.ToString("yyyy-MM-dd")}' AND t.TransactionDate < '{ _statement.EndDate.ToString("yyyy-MM-dd")}'";

                if (_statement.ProductID > 0)
                    sqlQuery = sqlQuery + $" AND t.ProductID={_statement.ProductID}";
                results = GetData.GetDataTable(sqlQuery);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
            }
            return results;
        }
        public static DataTable OutstandingPayments(Statement _statement)
        {

            DataTable results = null;
            try
            {
                string sqlQuery =
                    $@"SELECT 
                c.ClientID,
                cf.ClientFeeID,
                CONCAT('Product ',' - ',p.Name) AS Entity,
                pf.Name AS Fee,
                f.Name AS PaymentTerms,
                cf.DueDate,
                cf.Amount
                FROM 
                Clients c 
                INNER JOIN [dbo].[ClientFees] cf ON c.ClientID= cf.ClientID
                INNER JOIN ClientProducts cp ON cf.ClientProductID=cp.ClientProductID
                INNER JOIN  Products p ON cp.ProductID=p.ProductID
                INNER JOIN ProductFees pf ON cf.ProductFeeID=pf.ProductFeeID
                INNER JOIN Frequencies f ON pf.FrequencyID=f.FrequencyID
                WHERE DatePaid IS NULL AND c.ClientID={_statement.ClientID} AND DueDate >'{_statement.StartDate.ToString("yyyy-MM-dd")}' AND DueDate < '{_statement.EndDate.ToString("yyyy-MM-dd")}' 

                UNION ALL
                SELECT 
                c.ClientID,
                cf.ClientFeeID,
                CONCAT('Course ',' - ',cs.Title) AS Entity,
                csf.Name AS Fee,
                f.Name AS PaymentTerms,
                cf.DueDate,
                cf.Amount
                FROM 
                Clients c 
                INNER JOIN [dbo].[ClientFees] cf ON c.ClientID= cf.ClientID
                INNER JOIN ClientCourses cc ON cf.ClientCourseID=cc.ClientCourseID
                INNER JOIN  Courses cs ON cs.CourseID=cc.CourseID
                INNER JOIN CourseFees csf ON cf.CourseFeeID=csf.CourseFeeID
                INNER JOIN Frequencies f ON csf.FrequencyID=f.FrequencyID
                WHERE DatePaid IS NULL AND c.ClientID={_statement.ClientID} AND DueDate >'{_statement.StartDate.ToString("yyyy-MM-dd")}' AND DueDate < '{_statement.EndDate.ToString("yyyy-MM-dd")}'";

                results = GetData.GetDataTable(sqlQuery);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
            }
            return results;
        }

        public static DataTable Deductions(Statement _statement)
        {
            DataTable results = null;
            try
            {
                string _selectClause = @"SELECT p.Name AS Product,i.DueDate,id.InvoiceNumber,id.DeductedAmount,c.ClientID,
                                        ps.Name AS PaymentStatus
                                         FROM 
                                         Invoices i 
                                         INNER JOIN InvoiceDetails id ON i.InvoiceID=id.InvoiceID
                                         INNER JOIN PaymentStatus  ps ON id.PaymentStatusID=ps.PaymentStatusID
                                         INNER JOIN Products p ON id.ProductID=id.ProductID
                                         INNER JOIN Clients c ON  id.ClientID=c.ClientID ";
                string sqlQuery = _selectClause + $"WHERE c.ClientID={_statement.ClientID}  AND i.DueDate>'{_statement.StartDate.ToString("yyyy-MM-dd")}' AND i.DueDate < '{_statement.EndDate.ToString("yyyy-MM-dd")}' AND i.InvoiceStatusID={(int)InvoiceState.Finalised}";

                results = GetData.GetDataTable(sqlQuery);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Reporting, ex);
            }
            return results;
        }
    }
}
