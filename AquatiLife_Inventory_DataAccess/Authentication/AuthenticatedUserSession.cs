using AquaModClasses.Authentication;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.Authentication
{
    public class AuthenticatedUserSession : UserSession
    {
        public UserLoginSessions _UserSessionRecord { get; set; }

        public AuthenticatedUserSession(string user)
        {         

            using (DatabaseEntities dbconn = new DatabaseEntities())
            {
                Users _data = dbconn.Users.Where(x => x.UserName == user).First();

                SessionID = GetHashCode();
                UserID = _data.pk_UserID;
                UserName = _data.UserName;
                PermissionLevels = _data.UserRole;
                SessionBegin = DateTime.Now.ToString();
                IsActive = true;

                _UserSessionRecord = GetUserLoginSession();

            }
        }

        /// <summary>
        /// Log user session to database after successfully logging in
        /// </summary>
        public UserLoginSessions GetUserLoginSession()
        {
            UserLoginSessions _session = new UserLoginSessions();

            _session.fk_UserID = UserID;
            _session.pk_SessionID = SessionID;
            _session.SessionBegin = SessionBegin;
            _session.SessionPermission = PermissionLevels;

            return _session;
        }

        /// <summary>
        /// Get list of permissions attached to user session
        /// </summary>
        /// <returns>List of user permissions</returns>
        public List<string> GetUserPermissions()
        {
            List<string> permissionList = new List<string>();

            string[] permissionText = this.PermissionLevels.Split(';');

            foreach (string permission in permissionText)
            {
                permissionList.Add(permission);
            }

            permissionList.Sort();

            return permissionList;
        }

    }
}
