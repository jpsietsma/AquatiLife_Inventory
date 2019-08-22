using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;
using WFP_AquatiLife_Inventory_UI.ViewModels;

namespace WFP_AquatiLife_Inventory_UI.UserControls
{
    public class UserPurchaseHistoryGrid : RadGridView
    {
        public AuthenticatedUserSession _userSession { get; set; }

        public UserPurchaseHistoryGrid(AuthenticatedUserSession _session)
        {
            _userSession = _session;
            ItemsSource = GetData();

            Height = 400;
            Width = 400;
            
        }


        private List<UserPurchases> GetData()
        {
            List<UserPurchases> _data = new List<UserPurchases>();

            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.GetUserPurchases(_userSession.UserID, 0).ToList();

                foreach (var item in a)
                {
                    _data.Add(new UserPurchaseViewModel(item));
                }
            }

            return _data;
        }
        
    }
}
