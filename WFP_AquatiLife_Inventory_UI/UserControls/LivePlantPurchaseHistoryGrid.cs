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
    public class LivePlantPurchaseHistoryGrid : RadGridView
    {
        private ObservableCollection<UserPurchases> _data { get; set; } = new ObservableCollection<UserPurchases>();

        public LivePlantPurchaseHistoryGrid(AuthenticatedUserSession _session)
        {           
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.GetUserPurchases(_session.UserID, 2).ToList();

                foreach (var item in a)
                {
                    _data.Add(new UserPurchaseViewModel(item));
                }
            }

            this.ItemsSource = GetData();
            this.ShowGroupPanel = false;
            this.AutoGenerateColumns = false;
            this.RowDetailsVisibilityMode = Telerik.Windows.Controls.GridView.GridViewRowDetailsVisibilityMode.VisibleWhenSelected;
            this.ColumnWidth = GridViewLength.Auto;

            GridViewDataColumn datacol = new GridViewDataColumn();
            

        }

        public ObservableCollection<UserPurchases> GetData()
        {
            return _data;
        }
    }
}
