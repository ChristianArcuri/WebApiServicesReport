using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;

namespace WebAPIDataAccess
{
    public static class DAConnectionStrings
    {
        private static string decryptPwd;
        private static readonly bool UseAvailabilityGroup;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(DAConnectionStrings));

        static DAConnectionStrings()
        {
            log = log4net.LogManager.GetLogger(typeof(DAConnectionStrings));
            if (bool.TryParse(ConfigurationManager.AppSettings["UseAvailabilityGroup"], out UseAvailabilityGroup))
                UseAvailabilityGroup = true;
        }

        #region public
        public static string WireSecurityConnectionString
        {
            get
            {
                return GetConecctionString("SECURITY");
            }
        }

        public static string DefaultConnectionString
        {
            get
            {
                decryptPwd = string.IsNullOrEmpty(decryptPwd) ? ConfigurationManager.AppSettings["decryptPwd"] : decryptPwd;
                string conn = Decrypt(ConfigurationManager.ConnectionStrings["WireSecurity_Connection"].ConnectionString);
                return conn;
            }
        }

        public static string WireTransacReadOnlyConnectionString
        {
            get { return GetConecctionString("WIRETRANSAC", UseAvailabilityGroup); }
        }

        public static string WirePricingReadOnlyConnectionString
        {
            get { return GetConecctionString("WIREPRICING", UseAvailabilityGroup); }
        }

        public static string WireSearchReadOnlyConnectionString
        {
            get { return GetConecctionString("WIRESEARCH", UseAvailabilityGroup); }
        }

        public static string WireSecurityReadonlyConnectionString
        {
            get { return GetConecctionString("SECURITY", UseAvailabilityGroup); }
        }

        public static string WireTransacConnectionString
        {
            get
            {
               return GetConecctionString("WIRETRANSAC");
             
            }
        }

        public static string WireSearchConnectionString
        {
            get
            {
                return GetConecctionString("WIRESEARCH");
            }
        }
        public static string FaxOutgoingConnectionString
        {
            get
            {
              // return "data source=192.168.1.139;user id=mgarcia;password=;initial catalog=FaxOutgoing;Persist Security Info=true";
               return GetConecctionString("FAXOUTGOING");

            }
        }

        public static string MoneyOrderConnectionString
        {
            get
            {
                 return GetConecctionString("MONEYORDERS");

            }
        }

        public static string WirePricingConnectionString
        {
            get
            {
                return GetConecctionString("WIREPRICING");

            }
        }

        public static string ChecksConnectionString
        {
            get
            {
                return GetConecctionString("CHECKS");

            }
        }

        public static string DebitCardConnectionString
        {
            get
            {
                return GetConecctionString("DEBITCARD");

            }
        }
        public static string ReportUser
        {
            get
            {
                decryptPwd = string.IsNullOrEmpty(decryptPwd) ? ConfigurationManager.AppSettings["decryptPwd"] : decryptPwd;
                string conn = Decrypt(ConfigurationManager.AppSettings["ReportUser"].ToString());
                return conn;
            }
        }

        public static string ReportPassword
        {
            get
            {
                decryptPwd = string.IsNullOrEmpty(decryptPwd) ? ConfigurationManager.AppSettings["decryptPwd"] : decryptPwd;
                string conn = Decrypt(ConfigurationManager.AppSettings["ReportPassword"].ToString());
                return conn;
            }
        }

        public static string ReportDomain
        {
            get
            {
                decryptPwd = string.IsNullOrEmpty(decryptPwd) ? ConfigurationManager.AppSettings["decryptPwd"] : decryptPwd;
                string conn = Decrypt(ConfigurationManager.AppSettings["ReportDomain"].ToString());
                return conn;
            }
        }

        public static string GetDecryptSetting(string value)
        {
            decryptPwd = string.IsNullOrEmpty(decryptPwd) ? ConfigurationManager.AppSettings["decryptPwd"] : decryptPwd;
            string conn = Decrypt(value);
            return conn;
        }
     
        #endregion

        #region private
        private static string Decrypt(string cipherText)
        {
            string result = string.Empty;
            try
            {
                byte[] cipherBytes = Convert.FromBase64String(cipherText);

                PasswordDeriveBytes pdb = new PasswordDeriveBytes(decryptPwd,
                    new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 
                0x64, 0x76, 0x65, 0x64, 0x65, 0x76});


                byte[] decryptedData = Decrypt(cipherBytes,
                    pdb.GetBytes(32), pdb.GetBytes(16));


                result = System.Text.Encoding.Unicode.GetString(decryptedData);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Decrypt ERROR: {0}", ex.Message);
            }
            return result;
        }
        private static byte[] Decrypt(byte[] cipherData, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();

            alg.Key = Key;
            alg.IV = IV;

            CryptoStream cs = new CryptoStream(ms,
                 alg.CreateDecryptor(), CryptoStreamMode.Write);

            cs.Write(cipherData, 0, cipherData.Length);
            cs.Close();

            byte[] decryptedData = ms.ToArray();
            return decryptedData;
        }

        private static string GetConecctionString(string dbName,bool? IsReadOnly=null)
        {
            string result = string.Empty;

            int environmentId = Convert.ToInt32(ConfigurationManager.AppSettings["EnvironmentId"]);
            int appId = Convert.ToInt32(ConfigurationManager.AppSettings["ApplicationId"]);

            //DataTable dt = new DAConfigParam().GetConnectionInformation(dbName, environmentId, appId);
            DataTable dt = ConnectionInfoCache.GetOrAddToCache(dbName, environmentId, appId);
            if (dt.Rows.Count > 0)
            {
                SqlConnectionStringBuilder sqlConn = new SqlConnectionStringBuilder();
                sqlConn.DataSource = dt.Rows[0]["ServerName"].ToString();
                sqlConn.InitialCatalog = dt.Rows[0]["DatabaseName"].ToString();
                sqlConn.UserID = Decrypt(dt.Rows[0]["UserName"].ToString());
                sqlConn.Password = Decrypt(dt.Rows[0]["Password"].ToString()); ;
                sqlConn.ApplicationName = dt.Rows[0]["ApplicationName"].ToString();
                sqlConn.Encrypt = true;
                if (IsReadOnly != null)
                {
                    sqlConn.ApplicationIntent = IsReadOnly.Value ? ApplicationIntent.ReadOnly : ApplicationIntent.ReadWrite;
                    sqlConn.MultiSubnetFailover = true;
                }
                sqlConn.TrustServerCertificate = true;
                result = sqlConn.ToString();
            }
            return result;
        }

      
        #endregion
    }
}
