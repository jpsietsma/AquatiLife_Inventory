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
using WFP_AquatiLife_Inventory_UI.PopulateUI;

namespace WFP_AquatiLife_Inventory_UI.Screens
{
    /// <summary>
    /// Interaction logic for AddPurchase.xaml
    /// </summary>
    public partial class AddPurchase : Window
    {
        public AddPurchase(AuthenticatedUserSession _session)
        {
            InitializeComponent();
            ddlPurchaseCategories.PopulateUI_DDL_PurchaseCategories(_session);
            ddlStoreName.PopulateUI_DDL_Stores(_session);
        }
    }
}
