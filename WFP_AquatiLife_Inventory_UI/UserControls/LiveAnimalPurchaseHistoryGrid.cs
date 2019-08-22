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
    public class LiveAnimalPurchaseHistoryGrid : RadGridView
    {
        private ObservableCollection<UserPurchases> _data { get; set; } = new ObservableCollection<UserPurchases>();

        public LiveAnimalPurchaseHistoryGrid(AuthenticatedUserSession _session)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = (conn.GetUserPurchases(_session.UserID, 1).ToList()).Concat(conn.GetUserPurchases(_session.UserID, 6).ToList());

                foreach (var item in a)
                {
                    _data.Add(new UserPurchaseViewModel(item));
                }
            }
        }

        public ObservableCollection<UserPurchases> GetData()
        {
            return _data;
        }
    }
}
