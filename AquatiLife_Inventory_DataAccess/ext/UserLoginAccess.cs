using static AquatiLife_Inventory_DataAccess.Configuration.AppConfigurationInfo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.enums;
using System.Windows;
using AquatiLife_Inventory_DataAccess.DatabaseContext;

namespace AquatiLife_Inventory_DataAccess.ext
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
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                int count = conn.Users.Where(x => x.UserName == username && x.Password == password).Count();

                return count > 0 ? true : false;
            }
        }

        /// <summary>
        /// Log a record to the UserLoginSessions table for each session
        /// </summary>
        /// <param name="_session">AuthenticatedUserSession object to act on</param>
        /// <param name="_type">LogType type of session action: login or logout</param>
        public static void LogUserSession(AuthenticatedUserSession _session, LogType _type)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                switch (_type)
                {
                    case LogType.LOGIN:
                        {
                            try
                            {
                                conn.UserLoginSessions_Add(_session.SessionID, _session.UserID, _session.SessionBegin, _session.SessionEnd, _session.IsAdmin.ToString(), Convert.ToInt32(Convert.ToBoolean(_session.IsActive)));

                                conn.SaveChanges();
                            }
                            catch (Exception ex)
                            {
                                MessageBoxResult err = new MessageBoxResult();

                                if (ex.InnerException.Message != null)
                                {
                                    err = MessageBox.Show(ex.InnerException.Message);
                                }
                                else
                                {
                                    err = MessageBox.Show(ex.Message);
                                }                                
                            }                            
                                                        
                            break;
                        }

                    case LogType.LOGOUT:
                        {
                            try
                            {
                                UserLoginSessions sessionRecord = conn.UserLoginSessions.Where(x => x.pk_SessionID == _session.SessionID).First();
                                    sessionRecord.SessionEnd = _session.SessionEnd.ToString();
                                    sessionRecord.IsActive = _session.IsActive;
                                    sessionRecord.SessionDuration = _session.GetSessionLength();

                                conn.SaveChanges();
                            }
                            catch (Exception ex)
                            {
                                MessageBoxResult err = new MessageBoxResult();

                                if (ex.InnerException.Message != null)
                                {
                                    err = MessageBox.Show(ex.InnerException.Message);
                                }
                                else
                                {
                                    err = MessageBox.Show(ex.Message);
                                }
                            }
                            
                            break;
                        }
                }
            }          
        }

        
    }
}
