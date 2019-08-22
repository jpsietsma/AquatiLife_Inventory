using System;
using System.Windows;
using Telerik.Windows.Controls;
using WFP_AquatiLife_Inventory_UI.PopulateUI;
using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.DatabaseContext;

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
            ddlPurchaseUser.SelectedValue = _session.UserName;

            numQty.ValueFormat = ValueFormat.Numeric;
            numQty.Value = 1;
            numPrice.ValueFormat = ValueFormat.Currency;
            numPrice.Value = 0.00;

        }

        /// <summary>
        /// Occurs when user clicks on 'Save Purchase' button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddPurchase_Click(object sender, RoutedEventArgs e)
        {
            using (UserPurchases purchase = new UserPurchases())
            {
                purchase.Description = txtDescription.Text;
                purchase.Cost = Convert.ToDecimal(numPrice.Value.GetValueOrDefault());
                purchase.Date = txtDate.DateTimeText;
                purchase.Quantity = Convert.ToInt32(numQty.Value);
                purchase.fk_PurchaseCategory = ddlPurchaseCategories.SelectedIndex;
                purchase.fk_StoreID = ddlStoreName.SelectedIndex;
                purchase.fk_UserID = ddlPurchaseUser.SelectedIndex;

                try
                {
                    using (DatabaseEntities conn = new DatabaseEntities())
                    {
                        conn.UserPurchases.Add(purchase);
                        conn.SaveChanges();
                    }

                    RadWindow.Alert($@"Purchase record for { purchase.Description } added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }              
        }

        private void BtnClearForm_Click(object sender, RoutedEventArgs e)
        {
            this.txtDescription.Text = null;
            this.numPrice.Value = 0.00;
            this.numQty.Value = 1.00;
            this.ddlStoreName.SelectedIndex = 0;
            this.txtDate = null;
        }

        private void NumQtyPrice_Changed(object sender, RadRangeBaseValueChangedEventArgs e)
        {
            double val = Convert.ToDouble(numQty.Value * numPrice.Value);
            extCost.Text = $@"(total ${ val.ToString() })";
        }

    }
}
