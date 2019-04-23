using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
using AquatiLife_Inventory_DataAccess.ext;
using AquatiLife_Inventory_DataAccess.PopulateUI;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WFP_AquatiLife_Inventory_UI.PopulateUI;
using WFP_AquatiLife_Inventory_UI.ViewModels;

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
                PlantDictionaryEntryViewModel _vm = new PlantDictionaryEntryViewModel(PopulateUI_View_PlantInfo.PopulateView(ddlPlantType.SelectedValue.ToString()));
                BitmapImage image = new BitmapImage(new Uri(@"../" + _vm.PlantImage, UriKind.Relative));

                PlantCareGrid.Visibility = Visibility.Visible;

                cbxNeedsFertilizer.IsChecked = _vm.NeedsFertilizer;
                cbxNeedsFertilizer.IsEnabled = false;
                cbxNeedsFertilizer.HorizontalAlignment = HorizontalAlignment.Center;
                cbxNeedsFertilizer.VerticalAlignment = VerticalAlignment.Center;

                cbxFloatable.IsChecked = _vm.CanFloat;
                cbxFloatable.IsEnabled = false;
                cbxFloatable.HorizontalAlignment = HorizontalAlignment.Center;
                cbxFloatable.VerticalAlignment = VerticalAlignment.Center;

                txtTempRange.Text = _vm.PlantMinTemp.ToString() + " - " + _vm.PlantMaxTemp.ToString() + "°F";
                txtTempRange.HorizontalAlignment = HorizontalAlignment.Center;
                txtTempRange.VerticalAlignment = VerticalAlignment.Center;

                txtIdealTemp.Text = _vm.PlantIdealTemp.ToString() + "°F";
                txtIdealTemp.HorizontalAlignment = HorizontalAlignment.Center;
                txtIdealTemp.VerticalAlignment = VerticalAlignment.Center;

                txtLighting.Text = _vm.TankLightingLevel;
                txtLighting.HorizontalAlignment = HorizontalAlignment.Center;
                txtLighting.VerticalAlignment = VerticalAlignment.Center;

                txtSizeClass.Text = _vm.PlantSizeClass;
                txtSizeClass.HorizontalAlignment = HorizontalAlignment.Center;
                txtSizeClass.VerticalAlignment = VerticalAlignment.Center;

                txtMaxHeight.Text = _vm.PlantMaxHeight.ToString() + '"';
                txtMaxHeight.HorizontalAlignment = HorizontalAlignment.Center;
                txtMaxHeight.VerticalAlignment = VerticalAlignment.Center;

                PlantImage.Source = image;

                txtTypeName.Text = ddlPlantType.SelectedValue.ToString();
            }
            else
            {
                TankCheckGrid.Visibility = Visibility.Hidden;
                PlantCareGrid.Visibility = Visibility.Hidden;
            }
        }

        private void DdlUserTank_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string value = ddlUserTank.SelectedValue.ToString();
            
            if (ddlUserTank.SelectedIndex != 0)
            {
                value = value.Split('-')[1];

                TankCheckGrid.Visibility = Visibility.Visible;

                using (Entities conn = new Entities())
                {
                    vw_UserTanks tank = conn.vw_UserTanks.Where(x => x.TankDisplayName == value).First();                    

                    switch (UserTankExt.RunCompatabilityTest_WaterType(tank.Tank_ID, txtTypeName.Text).ToString())
                    {
                        case "P":
                            {
                                PF_compatabilityWaterType.Source = new BitmapImage(new Uri("../images/UI/Icons/checkmark_green.png", UriKind.Relative));
                                //compatabilityWaterType.Background = new SolidColorBrush { Color = Color.FromRgb(0, 100, 0), Opacity = 0.10 };

                             break;
                            }

                        case "F":
                            {
                                PF_compatabilityWaterType.Source = new BitmapImage(new Uri("../images/UI/Icons/x_red.png", UriKind.Relative));
                                //compatabilityWaterType.Background = new SolidColorBrush { Color = Color.FromRgb(100, 0, 0), Opacity = 0.10 };

                                break;
                            }
                    }

                    PF_compatabilityGallonSize.Source = new BitmapImage(new Uri("../images/UI/Icons/x_red.png", UriKind.Relative));
                    PF_compatabilityLightingType.Source = new BitmapImage(new Uri("../images/UI/Icons/x_red.png", UriKind.Relative));
                    PF_compatabilitySubstrate.Source = new BitmapImage(new Uri("../images/UI/Icons/x_red.png", UriKind.Relative));
                    PF_compatabilityTemperature.Source = new BitmapImage(new Uri("../images/UI/Icons/x_red.png", UriKind.Relative));
                    PF_compatabilityWaterpH.Source = new BitmapImage(new Uri("../images/UI/Icons/x_red.png", UriKind.Relative));
                }
            }            
        }

        private void FailureDetails_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tank compatability test failed!");
        }

        private void RunTest_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This feature must be coded.");
        }

        private void AssignNewPlant_Click_AddPlant(object sender, RoutedEventArgs e)
        {

        }
    }
}
