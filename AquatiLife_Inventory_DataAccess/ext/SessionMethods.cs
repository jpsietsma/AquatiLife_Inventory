using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.Authentication
{
    /// <summary>
    /// Class to add session functionality such as logging and updating the database on logins/logouts
    /// </summary>
    public static class SessionMethods
    {
        /// <summary>
        /// Log the user out of the current session when closing the window, updates SessionEnd in Database
        /// </summary>
        /// <param name="_session"></param>
        public static void SessionLogout(this AuthenticatedUserSession _session)
        {
            try
            {
                using (DatabaseEntities dbconn = new DatabaseEntities())
                {
                    UserLoginSession sessionData = dbconn.UserLoginSessions.Where(x => x.pk_SessionID == _session.SessionID).FirstOrDefault();

                    string sql = $@"UPDATE dbo.UserLoginSessions SET SessionEnd = { DateTime.Now.ToString() } WHERE pk_SessionID = { _session.SessionID }";
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
