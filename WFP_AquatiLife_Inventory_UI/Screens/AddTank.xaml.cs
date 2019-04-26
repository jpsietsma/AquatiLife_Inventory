using AquatiLife_Inventory_DataAccess.Authentication;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for AddTank.xaml
    /// </summary>
    public partial class AddTank : Window
    {
        public AddTank(AuthenticatedUserSession _session)
        {
            InitializeComponent();

            ddlWaterType.PopulateUI_DDL_TankWaterTypes(_session);

        }

        /// <summary>
        /// Add new tank to database for user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewTank_ButtonClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tank add button clicked!");
        }
    }
}
