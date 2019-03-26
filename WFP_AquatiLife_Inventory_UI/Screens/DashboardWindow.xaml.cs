using WFP_AquatiLife_Inventory_UI.Screens;
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
using System.Windows.Shapes;
using AquatiLife_Inventory_DataAccess.Authentication;

namespace WFP_AquatiLife_Inventory_UI
{
    /// <summary>
    /// Interaction logic for DashboardWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window
    {
        public AddTank tankWindow { get; set; } = new AddTank();
        public AddFish fishWindow { get; set; } = new AddFish();
        public UserLogin loginWindow { get; set; } = new UserLogin();
        public UserProfileDashboard profileWindow { get; set; } = new UserProfileDashboard();

        public DashboardWindow(AuthenticatedUserSession _session)
        {
            //InitializeComponent();
            DataContext = _session;

            this.Closed += DashboardWindow_Closed;

            if(_session == null)
            {
                loginWindow.Visibility = Visibility.Visible;
                loginWindow.Topmost = true;
                loginWindow.Focus();

                if (loginWindow._session != null)
                {
                    _session = loginWindow._session;                    
                    this.Visibility = Visibility.Visible;
                    this.Activate();
                    InitializeComponent();

                    loginWindow.Close();
                }
            }            

        }

        //Shut down the application when DashboardWindow is closed
        private void DashboardWindow_Closed(object sender, EventArgs e)
        {
            App.Current.Shutdown();
        }

        //Open AddTank window when menu item clicked
        private void MenuItem_Click_AddTank(object sender, RoutedEventArgs e)
        {
            
                tankWindow.Visibility = Visibility.Visible;
                tankWindow.Focus();
                        
        }

        //Open AddFish window when menu item clicked
        private void MenuItem_Click_AddFish(object sender, RoutedEventArgs e)
        {            
                fishWindow.Visibility = Visibility.Visible;
                fishWindow.Focus();
        }

        //Open MyProfile window when menu item is clicked
        private void MenuItem_Click_MyProfile(object sender, RoutedEventArgs e)
        {
            profileWindow.Visibility = Visibility.Visible;
            profileWindow.Focus();            
        }


    }
}
