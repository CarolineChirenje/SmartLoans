using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SmartHelper
{
    public static class GetData
    {
        public static string SSDBConnection => SSDBConnectionValue();

        public static CustomSetting GetSettingValue(int CustomSettingID)
        {
            string sqlCustomSetting = $"SELECT TOP 1 * FROM CustomSettings WHERE CustomSettingID={CustomSettingID};";
            using (IDbConnection db = new SqlConnection(SSDBConnection))
            {
                return db.Query<CustomSetting>(sqlCustomSetting).SingleOrDefault();
            }
        }

        public static DataTable GetDataTable(string sqlQuery)
        {
            DataTable results= new DataTable(); ;
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
                       using (IDbConnection db = new SqlConnection(SSDBConnection))
            {
                return db.Query<string>(sqlQuery)?.SingleOrDefault();
            }
        }

        public static bool IsPermitted(int _permissionID)
        {
            string countValue;
            int permissionCount = 0;
            string _selectClause = @"SELECT COUNT(rp.PermissionID) FROM Users u 
              INNER JOIN UserRoles ur ON u.UserID = ur.UserID
              INNER JOIN RolePermissions rp ON ur.RoleID = rp.RoleID ";
            string _whereClause = $"WHERE u.UserName ='{UtilityService.CurrentUserName}' AND PermissionID ={_permissionID}";
            string sqlCustomSetting = _selectClause + _whereClause;
            using (IDbConnection db = new SqlConnection(SSDBConnection))
            {
                countValue = db.Query<string>(sqlCustomSetting).SingleOrDefault();
            }

            try
            {
                permissionCount = Int32.Parse(countValue);
            }
            catch (Exception ex)
            {

                permissionCount = 0;
            }
            return (permissionCount == 0) ? false : true;

        }

        public static string SSDBConnectionValue()
        {
            IConfiguration _configuration;

            _configuration = new ConfigurationBuilder()
          .AddJsonFile(
                "appsettings.json", true, true)
          .Build();

            string configValue = _configuration.GetConnectionString("SSDBConnection");

            return string.IsNullOrEmpty(configValue) ? "Data Source=WEKWACHIRENJE\\WEKWACHIRENJE;Initial Catalog=SSProd;Trusted_Connection=True;MultipleActiveResultSets=True;" : configValue;
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

}
