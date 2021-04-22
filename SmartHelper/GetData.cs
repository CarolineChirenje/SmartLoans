using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SmartHelper
{
    public static class GetData
    {
      static  IConfiguration _configuration;
        public static string SSDBConnection => SSDBConnectionValue();

        public static bool ShowDeveloperException => ShowDeveloperExceptions();

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
            _configuration = LoadAppConfigurations;
            string _environment = _configuration.GetSection("SiteEnvironment").Value;
            if (String.IsNullOrEmpty(_environment))
                _environment = SiteEnvironment.Test.ToString();
            string connectionStringName = $"SSDBConnection{_environment}";
            string configValue = _configuration.GetConnectionString(connectionStringName);
            return string.IsNullOrEmpty(configValue) ? "Data Source=172.105.28.87;Initial Catalog=SmartSave;User Id=sa;Password=Ch1gumbu6299##" : configValue;

        }
        public static bool ShowDeveloperExceptions()
        {
          _configuration= LoadAppConfigurations;
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

}
