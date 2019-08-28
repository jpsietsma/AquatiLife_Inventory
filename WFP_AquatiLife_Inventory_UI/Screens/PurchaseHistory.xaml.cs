using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
using AquatiLife_Inventory_DataAccess.GlobalMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Telerik.Windows.Controls;
using WFP_AquatiLife_Inventory_UI.UserControls;

namespace WFP_AquatiLife_Inventory_UI.Screens
{
    /// <summary>
    /// Interaction logic for PurchaseHistory.xaml
    /// </summary>
    public partial class PurchaseHistory : Window
    {
        public AuthenticatedUserSession _UserSession { get; set; }

        public PurchaseHistory(AuthenticatedUserSession _session)
        {            
            InitializeComponent();

            _UserSession = _session;

            Title = $@"{_session.UserName} - Purchase History";         
        }

        private void AllPurchasesTab_Selected(object sender, RoutedEventArgs e)
        {
            UIConstruction.PopulatePurchaseGrid(AllPurchasesGrid, _UserSession);
        }

        private void AnimalPurchasesTab_Selected(object sender, RoutedEventArgs e)
        {
            UIConstruction.PopulateLiveAnimalPurchasesGrid(LiveAnimalsPurchaseGrid, _UserSession);
        }

        private void SupplyPurchasesTab_Selected(object sender, RoutedEventArgs e)
        {
            UIConstruction.PopulateSupplyPurchasesGrid(SupplyGrid, _UserSession);
        }

        private void DecorationPurchasesTab_Selected(object sender, RoutedEventArgs e)
        {
            UIConstruction.PopulateDecorationPurchasesGrid(DecorationGrid, _UserSession);
        }

        private void LivePlantPurchasesTab_Selected(object sender, RoutedEventArgs e)
        {
            UIConstruction.PopulateLivePlantPurchasesGrid(LivePlantsGrid, _UserSession);
        }
    }
}
