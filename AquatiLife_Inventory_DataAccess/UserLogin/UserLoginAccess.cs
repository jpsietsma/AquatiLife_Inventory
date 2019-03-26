using static AquaModClasses.BaseClassModels.AppConfigurationInfo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquaModClasses.BaseClassModels;
using AquatiLife_Inventory_DataAccess.Authentication;

namespace AquatiLife_Inventory_DataAccess.DatabaseContext
{
    public static class UserLoginAccess
    {
        /// <summary>
        /// Check if user/password combination is correct
        /// </summary>
        /// <param name="username">Username entered by user</param>
        /// <param name="password">Password entered by user</param>
        /// <returns>true if user/password is correct</returns>
        public static bool CheckUserPass(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();
                string queryString = $@"SELECT count(*) FROM AquatiLife_Inventory_Database.dbo.Users WHERE UserName = '{ username }' AND Password = '{ password }' ";
                SqlCommand sql = new SqlCommand(queryString, conn);
                int results;
                int.TryParse(sql.ExecuteScalar().ToString(), out int parse);

                results = parse;

                if (results > 0)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Check if user/password combination is correct
        /// </summary>
        /// <param name="connection">SQL connection to use to connect to the database</param>
        /// <param name="username">Username to check for existance</param>
        /// <param name="password">Password to check if username exists</param>
        /// <returns>bool true if login is correct, false if unknown user or incorrect password</returns>
        public static bool CheckUserPass(SqlConnection connection, string username, string password)
        {
            using (connection)
            {
                connection.Open();
                string queryString = $@"SELECT UserName, Password FROM Users WHERE UserName = '{ username }' AND Password = '{ password }' ";
                SqlCommand sql = new SqlCommand(queryString);

                if (sql.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }

            return false;
        }


        public static void LogUserSession(AuthenticatedUserSession _session)
        {
            using (DatabaseEntities dbconn = new DatabaseEntities())
            {
                dbconn.UserLoginSessions.Add(_session._UserSessionRecord);
            }
        }
        
    }
}
