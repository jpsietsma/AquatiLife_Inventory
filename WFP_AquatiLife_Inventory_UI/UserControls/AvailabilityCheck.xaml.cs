using AquatiLife_Inventory_DataAccess.DatabaseContext;
using AquatiLife_Inventory_DataAccess.GlobalMethods;
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
using System.Windows.Navigation;
using Telerik.Windows.Controls;

namespace WFP_AquatiLife_Inventory_UI.UserControls
{
    /// <summary>
    /// Interaction logic for AvailabilityCheck.xaml
    /// </summary>
    public partial class AvailabilityCheck : UserControl
    {
        public Image StatusImage { get; set; }
        public TextBox SearchTextBox { get; set; }
        private string TooltipText { get; set; }
        public bool IsAvailable { get; set; }


        public AvailabilityCheck()
        {           
            InitializeComponent();

            StatusImage = AvailabilityStatusImage;
            SearchTextBox = InputTextbox;
            IsAvailable = false;

        }

        private void UsernameInputTextbox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Authentication.CheckUsername(SearchTextBox.Text))
            {
                StatusImage.Source = new BitmapImage(new Uri(@"C:\Users\bobswat\OneDrive\GitHub\AquatiLife_Inventory\WFP_AquatiLife_Inventory_UI\images\UI\UserControls\AvailabilityChecker\RedCross.png"));
                TooltipText = "Username is taken";
                IsAvailable = false;
            }
            else
            {
                StatusImage.Source = new BitmapImage(new Uri(@"C:\Users\bobswat\OneDrive\GitHub\AquatiLife_Inventory\WFP_AquatiLife_Inventory_UI\images\UI\UserControls\AvailabilityChecker\GreenCheck.png"));
                TooltipText = "Username is Available";
                IsAvailable = true;
            }
        }

        private void ShowTooltip_MouseEnter(object sender, MouseEventArgs e)
        {
            RadToolTip _tooltip = InputToolTip;
            _tooltip.Content = TooltipText;
            _tooltip.Visibility = Visibility.Visible;
        }

        private void HideToolTip_MouseLeave(object sender, MouseEventArgs e)
        {
            RadToolTip _tooltip = InputToolTip;
            _tooltip.Visibility = Visibility.Hidden;
        }
    }
}
