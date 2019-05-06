using AquatiLife_Inventory_DataAccess.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Telerik.Windows.Controls;
using WFP_AquatiLife_Inventory_UI.UserControls;

namespace WFP_AquatiLife_Inventory_UI.Screens
{
    /// <summary>
    /// Interaction logic for PurchaseHistory.xaml
    /// </summary>
    public partial class PurchaseHistory : Window
    {
        public PurchaseHistory(AuthenticatedUserSession _session)
        {
            Title = $@"{ _session.UserName } | User Purchase History";
            InitializeComponent();

            RadTabControl tabControl = historyTabs;
            RadGridView historyGrid = PurchaseHistoryGrid;

            historyGrid.ItemsSource = new UserPurchaseHistoryGrid(_session).GetData();
            historyGrid.ShowGroupPanel = false;

        }
    }
}
