using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
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

            ddlPurchaseUser.PopulateUI_DDL_Users(_session);

            numQty.ValueFormat = ValueFormat.Numeric;
            numPrice.ValueFormat = ValueFormat.Currency;                                       

        }

        /// <summary>
        /// Occurs when user clicks on 'Save Purchase' button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddPurchase_Click(object sender, RoutedEventArgs e)
        {
            UserPurchases purchase = new UserPurchases();
                purchase.Description = txtDescription.Text;
                purchase.Cost = Convert.ToDouble(numPrice.Value);
                purchase.Date = txtDate.DateTimeText;
                purchase.Quantity = Convert.ToInt32(numQty.Value);
                purchase.fk_PurchaseCategory = ddlPurchaseCategories.SelectedIndex;
                purchase.fk_StoreID = ddlStoreName.SelectedIndex;
                purchase.fk_UserID = ddlPurchaseUser.SelectedIndex;

            MessageBox.Show($@"Purchase record for { purchase.Description } added successfully!");
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
            this.ddlPurchaseUser.SelectedIndex = 0;
        }
    }
}
