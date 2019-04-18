using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.ext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WFP_AquatiLife_Inventory_UI.PopulateUI;

namespace WFP_AquatiLife_Inventory_UI.Screens
{
    /// <summary>
    /// Interaction logic for AddPlant.xaml
    /// </summary>
    public partial class AddPlant : Window
    {

        public AddPlant(AuthenticatedUserSession _session)
        {
            InitializeComponent();

            ddlPlantType.PopulateUI_DDL_PlantTypes();
            ddlUserTank.PopulateUI_DDL_UserTanks(_session);

        }

        private void DdlPlantType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ddlPlantType.SelectedIndex != 0)
            {
                this.DataContext = 
                PlantCareGrid.Visibility = Visibility.Visible;                
                                
                cbxNeedsFertilizer.IsChecked = true;
                cbxFloatable.IsChecked = true;                                  
                txtTempMin.Text = "70";
                txtTempMax.Text = "90";
                txtIdealTemp.Text = "75";
                txtLighting.Text = "";
                txtSizeClass.Text = "";
                txtMaxHeight.Text = "";
            }
            else
            {
                TankCheckGrid.Visibility = Visibility.Hidden;
                PlantCareGrid.Visibility = Visibility.Hidden;
            }
        }

        private void DdlUserTank_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ddlUserTank.SelectedIndex != 0)
            {
                TankCheckGrid.Visibility = Visibility.Visible;
                PF_compatabilityWaterType.Text = UserTankExt.RunCompatabilityTest_WaterType(Convert.ToInt32(ddlUserTank.SelectedValue), ddlPlantType.SelectedValue.ToString()).ToString();
            }
        }
    }
}
