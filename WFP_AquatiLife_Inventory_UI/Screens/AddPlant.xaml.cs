using AquatiLife_Inventory_DataAccess.ViewModels.BaseClasses;
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

namespace WFP_AquatiLife_Inventory_UI.Screens
{
    /// <summary>
    /// Interaction logic for AddPlant.xaml
    /// </summary>
    public partial class AddPlant : Window
    {
        private string _plantType = string.Empty;

        public AddPlant()
        {
            ComboBox ddlPlantType = FindName("ddlPlantType") as ComboBox;
            ddlPlantType.Items.Insert(0, new { Text = "-- Select Plant Type --", Value = "" });
            InitializeComponent();
        }

        private void DdlPlantType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ddlPlantType.SelectedValue.ToString()))
            {

            }
            else
            {
                gridMoreInfo.Visibility = Visibility.Hidden;
            }
        }
    }
}
