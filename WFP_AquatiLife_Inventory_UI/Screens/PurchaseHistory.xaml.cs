using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
using AquatiLife_Inventory_DataAccess.GlobalMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls;
using WFP_AquatiLife_Inventory_UI.Screens.Edit;
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

        private void EditLivePurchaseRecord_Click(object sender, RoutedEventArgs e)
        {
            Button EditButton = (Button)e.Source;
            int id = Convert.ToInt32(EditButton.Tag);

            new EditFishDetails(id, _UserSession).ShowDialog();
        }

        private void StatisticsTab_Selected(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            RadComboBox _combo = reportTypeCombo;
            DateTime Now = DateTime.Now;
            string FirstName;

            using (DatabaseEntities conn = new DatabaseEntities())
            {
                FirstName = conn.ContactInfo.Where(x => x.fk_UserID == _UserSession.UserID).First().FirstName;
            }

            string GreetingText;

            if (Convert.ToDateTime(Now.ToShortTimeString().ToString()) > Convert.ToDateTime("05:00:00.000")  && Convert.ToDateTime(Now.ToShortTimeString().ToString()) < Convert.ToDateTime("12:00:00.000"))
            {
                GreetingText = $@"Good Morning, { FirstName }.  I hope you're doing well";
            }
            
        }
    }
}
