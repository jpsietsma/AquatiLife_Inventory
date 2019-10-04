using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.GlobalMethods
{
    public static class Authentication
    {
        /// <summary>
        /// Determine whether an action is allowed for a particular user session
        /// </summary>
        /// <param name="_session">Session to authenticate</param>
        /// <returns>true if action is allowed, false otherwise</returns>
        public static bool AuthenticateAction(this AuthenticatedUserSession _session, WPFActions _action)
        {
            switch (_action)
            {
                case WPFActions.EDIT_PURCHASE:
                    {
                        return _session.Permissions.EditPurchase;
                    }
                    
                case WPFActions.ADD_PURCHASE:
                    {
                        return _session.Permissions.AddPurchase;
                    }
                case WPFActions.DELETE_PURCHASE:
                    {
                        return _session.Permissions.DeletePurchase;
                    }
                case WPFActions.EDIT_FISH:
                    {
                        return _session.Permissions.EditFish;
                    }
                case WPFActions.ADD_FISH:
                    {
                        return _session.Permissions.AddFish;
                    }
                case WPFActions.DELETE_FISH:
                    {
                        return _session.Permissions.DeleteFish;
                    }
                case WPFActions.EDIT_SUPPLY:
                    {
                        return _session.Permissions.EditSupply;
                    }
                case WPFActions.ADD_SUPPLY:
                    {
                        return _session.Permissions.AddSupply;
                    }
                case WPFActions.DELETE_SUPPLY:
                    {
                        return _session.Permissions.DeleteSupply;
                    }
                default:
                    {
                        return false;
                    }
            }

        }

        /// <summary>
        /// Describes actions that can be taken within the WPF application
        /// </summary>
        public enum WPFActions
        {
            #region Section: Purchase permissions

                /// <summary>
                /// Allow editing purchases?
                /// </summary>
                EDIT_PURCHASE,

                /// <summary>
                /// Allow adding purchases?
                /// </summary>
                ADD_PURCHASE,

                /// <summary>
                /// Allow deleting purchases?
                /// </summary>
                DELETE_PURCHASE,

            #endregion

            #region Section: Fish permissions

                /// <summary>
                /// Allow editing fish records?
                /// </summary>
                EDIT_FISH,

                /// <summary>
                /// Allow adding fish records?
                /// </summary>
                ADD_FISH,  
            
                /// <summary>
                /// Allow deleting fish records?
                /// </summary>
                DELETE_FISH,

            #endregion

            #region Section: Supply permissions

                /// <summary>
                /// Allow editing supply records?
                /// </summary>
                EDIT_SUPPLY,

                /// <summary>
                /// Allow adding supply records?
                /// </summary>
                ADD_SUPPLY,

                /// <summary>
                /// Allow deleting supply records?
                /// </summary>
                DELETE_SUPPLY

            #endregion
        }

        /// <summary>
        /// Check whether an account exists with the passed username
        /// </summary>
        /// <param name="username">username to check</param>
        /// <returns>true if found, false otherwise</returns>
        public static bool CheckUsername(string username)
        {
            bool _exists = false;

            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.Users.Where(x => x.UserName == username).Count();

                if (a > 0)
                {
                    _exists = true;
                }
                else
                {
                    _exists = false;
                }
            }

            return _exists;
        }
    }
}
