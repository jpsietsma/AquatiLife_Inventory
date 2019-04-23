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

            txtUser.Text = _session.UserName;
            txtUser.IsEnabled = false;
            numQty.ValueFormat = ValueFormat.Numeric;
            numPrice.ValueFormat = ValueFormat.Currency;

            if (_session.GetUserPermissions().Contains("Admin"))
            {
                txtUser.Visibility = Visibility.Hidden;
                admin_ddlUser.PopulateUI_DDL_Users(_session);
            }
        }

        /// <summary>
        /// Occurs when user clicks on 'Save Purchase' button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddPurchase_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Purchase record added successfully!");
        }

        /// <summary>
        /// Occurs when user cliks on clear form button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClearForm_Click(object sender, RoutedEventArgs e)
        {
            this.txtDate.SelectedValue = null;
            this.txtDescription.Text = null;
            this.numPrice.Value = 0.00;
            this.numQty.Value = 0.00;
            this.ddlPurchaseCategories.SelectedIndex = 0;
            this.ddlStoreName.SelectedIndex = 0;
        }
    }
}
