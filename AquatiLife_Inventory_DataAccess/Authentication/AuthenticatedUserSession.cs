using AquatiLife_Inventory_DataAccess.DatabaseContext;
using AquatiLife_Inventory_DataAccess.enums;
using AquatiLife_Inventory_DataAccess.ext;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AquatiLife_Inventory_DataAccess.Authentication
{
    public class AuthenticatedUserSession : UserSession
    {
        public UserLoginSessions _UserSessionRecord { get; set; }
        public UserPermissions Permissions { get; set; }

        public AuthenticatedUserSession(string user)
        {       
            using (DatabaseEntities dbconn = new DatabaseEntities())
            {
                try
                {
                    Users _data = dbconn.Users.Where(x => x.UserName == user).First();
                    Permissions = dbconn.UserPermissions.Where(x => x.fk_UserID == _data.pk_UserID).First();

                    SessionID = GenerateSessionID();
                    UserID = _data.pk_UserID;
                    UserName = _data.UserName;
                    PermissionLevels = _data.UserRole;
                    SessionBegin = DateTime.Now;
                    SessionEnd = null;
                    IsActive = true;

                    _UserSessionRecord = GetUserLoginSession();
                }
                catch (Exception ex)
                {
                    MessageBoxResult err = new MessageBoxResult();
                        err = MessageBox.Show(ex.Message);
                }

            }
        }

        /// <summary>
        /// Generate new unique id based on session begin time and new GUID
        /// </summary>
        /// <returns></returns>
        private string GenerateSessionID()
        {
            return Guid.NewGuid().ToString("N");
        }

        /// <summary>
        /// Log user session to database after successfully logging in
        /// </summary>
        public UserLoginSessions GetUserLoginSession()
        {
            UserLoginSessions _session = new UserLoginSessions();

            _session.fk_UserID = UserID;
            _session.pk_SessionID = SessionID;
            _session.SessionBegin = SessionBegin.ToString();
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

        /// <summary>
        /// Log the user out and record the session to the database
        /// </summary>
        public void LogOut()
        {
            this.SessionEnd = DateTime.Now;
            this.IsActive = false;

            UserLoginAccess.LogUserSession(this, LogType.LOGOUT);
        }

    }
}
