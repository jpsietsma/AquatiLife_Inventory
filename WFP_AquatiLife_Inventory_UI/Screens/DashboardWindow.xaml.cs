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
        public AddTank tankWindow { get; set; }
        public AddFish fishWindow { get; set; }
        public UserLogin loginWindow { get; set; }
        public UserProfileDashboard profileWindow { get; set; }
        public AuthenticatedUserSession _userSession { get; set; }

        /// <summary>
        /// Open a new dashboard session with the current authenticated user
        /// </summary>
        /// <param name="_session"></param>
        public DashboardWindow(AuthenticatedUserSession _session)
        {
            InitializeComponent();
            _userSession = _session;

            this.Title = $@"AquatiLife Fish Inventory Management | Logged in as: { _session.UserName }";

            this.Closed += DashboardWindow_Closed;            

        }

        /// <summary>
        /// Shut down the application when the dashboard window is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DashboardWindow_Closed(object sender, EventArgs e)
        {
            this._userSession.LogOut();
            App.Current.Shutdown();
        }

        /// <summary>
        /// Open the Add Tank window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_AddTank(object sender, RoutedEventArgs e)
        {
                tankWindow = new AddTank(_userSession);
                tankWindow.Activate();
                tankWindow.Focus();
                        
        }

        /// <summary>
        /// Open the add fish window 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_AddFish(object sender, RoutedEventArgs e)
        {
            fishWindow = new AddFish(_userSession);    
            fishWindow.Activate();
            fishWindow.Focus();
        }

        /// <summary>
        /// Open the profile dashboard for the current authenticated session
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_MyProfile(object sender, RoutedEventArgs e)
        {
            profileWindow = new UserProfileDashboard(_userSession);
                profileWindow.Activate();
                profileWindow.Focus();            
        }

        /// <summary>
        /// Log user out when clicking on file > logout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_LogOut(object sender, RoutedEventArgs e)
        {

            this.Visibility = Visibility.Hidden;
            this._userSession.LogOut();

            MainWindow _main = new MainWindow();
                _main.Activate();
                _main.Topmost = true;
                _main.Focus();
        }

        /// <summary>
        /// Exits application when clicking File > Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_Exit(object sender, RoutedEventArgs e)
        {
            _userSession.LogOut();
            App.Current.Shutdown();
        }
    }
}
