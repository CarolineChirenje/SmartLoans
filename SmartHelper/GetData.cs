using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SmartHelper
{
    public static class GetData
    {
        static IConfiguration _configuration;
        public static string SSDBConnection => SSDBConnectionValue();

        public static bool ShowDeveloperException => ShowDeveloperExceptions();


        public static Maintain MaintananceMode()
        {
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            string maintananceQuery = $"SELECT TOP 1 * FROM Maintanances WHERE StartDate<='{currentDate}' AND EndDate>='{currentDate}';";
            using IDbConnection db = new SqlConnection(SSDBConnection);
            return db.Query<Maintain>(maintananceQuery).SingleOrDefault();
        }
        public static Licensing LicenceMode()
        {
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            string licenceQuery = $"SELECT TOP 1 * FROM Licences WHERE StartDate<='{currentDate}' AND EndDate<='{currentDate}';";
            using IDbConnection db = new SqlConnection(SSDBConnection);
            return db.Query<Licensing>(licenceQuery).SingleOrDefault();
        }
        public static CustomSetting GetSettingValue(int CustomSettingID)
        {
            string sqlCustomSetting = $"SELECT TOP 1 * FROM CustomSettings WHERE CustomSettingID={CustomSettingID};";
            using IDbConnection db = new SqlConnection(SSDBConnection);
            return db.Query<CustomSetting>(sqlCustomSetting).SingleOrDefault();
        }

        public static DataTable GetDataTable(string sqlQuery)
        {
            DataTable results = new DataTable(); ;
            using (SqlConnection conn = new SqlConnection(SSDBConnection))
            {
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(results);
                conn.Close();
                da.Dispose();
            }
            return results;
        }

        public static string GetStringValue(string sqlQuery)
        {
            using IDbConnection db = new SqlConnection(SSDBConnection);
            return db.Query<string>(sqlQuery)?.SingleOrDefault();
        }

        public static bool IsPermitted(int _permissionID)
        {
            string countValue;
            string _selectClause = @"SELECT COUNT(rp.PermissionID) FROM Users u 
              INNER JOIN UserRoles ur ON u.UserID = ur.UserID
              INNER JOIN RolePermissions rp ON ur.RoleID = rp.RoleID ";
            string _whereClause = $"WHERE u.UserName ='{UtilityService.CurrentUserName}' AND PermissionID ={_permissionID}";
            string sqlCustomSetting = _selectClause + _whereClause;
            using (IDbConnection db = new SqlConnection(SSDBConnection))
            {
                countValue = db.Query<string>(sqlCustomSetting).SingleOrDefault();
            }

            int permissionCount;
            try
            {
                permissionCount = Int32.Parse(countValue);
            }
            catch
            {

                permissionCount = 0;
            }
            return permissionCount != 0;

        }
        public static string GetSupportValue(int supportListID)
        {
            string value;
            string sqlCustomSetting = $"SELECT TOP 1 t.Value FROM TechnicalSupport t WHERE t.TechnicalSupportID={supportListID};";
            using (IDbConnection db = new SqlConnection(SSDBConnection))
            {
                value = db.Query<string>(sqlCustomSetting).SingleOrDefault();
            }

            return value;

        }
        public static byte[] CompanyLogo()
        {
            byte[] logo;

            string sqlCustomSetting = "SELECT TOP 1 c.CompanyLogo FROM Companies c WHERE c.IsDefault=1;";
            using (IDbConnection db = new SqlConnection(SSDBConnection))
            {
                logo = db.Query<byte[]>(sqlCustomSetting).SingleOrDefault();
            }

            return logo;

        }
        public static string SSDBConnectionValue()
        {
          
              string  _environment = Environment();
            string connectionStringName = $"SSDBConnection{_environment}";
            string configValue = _configuration.GetConnectionString(connectionStringName);
            return string.IsNullOrEmpty(configValue) ? "Data Source=172.105.28.87;Initial Catalog=SmartSave;User Id=sa;Password=Ch1gumbu6299##" : configValue;

        }
        public static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        public static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
        public static string   Environment()
        {
            _configuration = LoadAppConfigurations;
            string _environment = _configuration.GetSection("SiteEnvironment").Value;
            if (String.IsNullOrEmpty(_environment))
                _environment = SiteEnvironment.Test.ToString();
            return _environment;

        }
        public static bool ShowDeveloperExceptions()
        {
            _configuration = LoadAppConfigurations;
            bool showDeveloperExceptions = false;
            try
            {
                showDeveloperExceptions = bool.Parse(_configuration.GetSection("ShowDeveloperExceptions").Value);
            }
            catch
            {


            }

            return showDeveloperExceptions;

        }
        
        public static int GetSessionTimeOut()
        {
            _configuration = LoadAppConfigurations;
            int sessionTimeOut = 60;
            try
            {
                sessionTimeOut = Int32.Parse(_configuration.GetSection("SessionTimeOut").Value);
            }
            catch
            {
            }
           return sessionTimeOut;
        }

        public static bool EnableLogger()
        {
            _configuration = LoadAppConfigurations;
            bool enableLogger = false;
            try
            {
                enableLogger = Boolean.Parse(_configuration.GetSection("EnableLogger").Value);
            }
            catch
            {
            }
            return enableLogger;
        }

        public static SmartLog SmartLogData()
        {
            _configuration = LoadAppConfigurations;
            SmartLog log = new SmartLog();
            try
            {
                log.EnableSmartLog = Convert.ToBoolean(_configuration["SmartLog:EnableSmartLog"].ToString());
                log.LogToFile = Convert.ToBoolean(_configuration["SmartLog:LogToFile"].ToString());
                log.LogToDatabase = Convert.ToBoolean(_configuration["SmartLog:LogToDatabase"].ToString());
                log.LogToRabbitMQ = Convert.ToBoolean(_configuration["SmartLog:LogToRabbitMQ"].ToString());
                log.LogDirectory = _configuration["SmartLog:LogDirectory"].ToString();

            }
            catch
            {


            }

            return log;

        }
        public static IConfiguration LoadAppConfigurations
        {
            get
            {
                return new ConfigurationBuilder()
                .AddJsonFile(
                      "appsettings.json", true, true)
                .Build();
            }

        }
    }



    public class CustomSetting
    {
        public int CustomSettingID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public int CustomVariableTypeID { get; set; }
        public int CustomSettingTypeID { get; set; }

    }
    public class Maintain
    {

        public int MaintananceID { get; set; }
        public string Reason { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool HasExpired { get; set; }

    }
    public class Licensing
    {

        public int LicenceID { get; set; }
        public string Reason { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool HasExpired { get; set; }

    }

    public class SmartLog
    {
        public bool EnableSmartLog { get; set; }
        public bool LogToFile { get; set; }
        public bool LogToDatabase { get; set; }
        public bool LogToRabbitMQ { get; set; }
        public string LogDirectory { get; set; }

    }

}
