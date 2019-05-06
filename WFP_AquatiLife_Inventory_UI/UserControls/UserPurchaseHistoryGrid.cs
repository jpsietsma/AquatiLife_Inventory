using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;

namespace WFP_AquatiLife_Inventory_UI.UserControls
{
    public class UserPurchaseHistoryGrid : RadGridView
    {
        private ObservableCollection<UserPurchases> _data { get; set; } = new ObservableCollection<UserPurchases>();

        public UserPurchaseHistoryGrid(AuthenticatedUserSession _session)
        {
            using (Entities conn = new Entities())
            {
                var a = conn.GetUserPurchases(_session.UserID, 0).ToList();

                foreach (var item in a)
                {
                    _data.Add(new UserPurchases { pk_PurchaseID = item.pk_PurchaseID, Description = item.Description, Cost = item.Cost, Date = item.Date, Quantity = item.Quantity, fk_StoreID = item.fk_StoreID, fk_PurchaseCategory = item.fk_PurchaseCategory });
                }
            }
        }

        public ObservableCollection<UserPurchases> GetData()
        {
            return _data;
        }
    }
}
