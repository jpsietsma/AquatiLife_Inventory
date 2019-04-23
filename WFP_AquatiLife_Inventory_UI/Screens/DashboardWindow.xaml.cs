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
using Hardcodet.Wpf.TaskbarNotification;
using System.Drawing;

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
        public TaskbarIcon _trayIcon { get; set; }
        public AddPlant addPlantWindow { get; set; }
        public AddPurchase addPurchaseWindow { get; set; }

        /// <summary>
        /// Open a new dashboard session with the current authenticated user
        /// </summary>
        /// <param name="_session"></param>
        public DashboardWindow(AuthenticatedUserSession _session)
        {
            InitializeComponent();
            _trayIcon = AQ_Tray_Icon;

            _userSession = _session;

            this.Title = $@"AquatiLife Fish Inventory Management | Logged in as: { _session.UserName }";

            this.Closed += DashboardWindow_Closed;

            ErrorNotificationsMenu.Icon = new BitmapImage(new Uri("../images/Icons/MenuIcon_ErrorNotification.png", UriKind.Relative));

        }

        /// <summary>
        /// Shut down the application when the dashboard window is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DashboardWindow_Closed(object sender, EventArgs e)
        {
            this._userSession.LogOut();
            _trayIcon.Visibility = Visibility.Hidden;

            App.Current.Shutdown();
        }

        /// <summary>
        /// Open the profile dashboard for the current authenticated session
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_MyProfile(object sender, RoutedEventArgs e)
        {
            profileWindow = new UserProfileDashboard(_userSession);
                profileWindow.Show();
                profileWindow.Focus();            
        }

#region Program Commands eventhandlers

    /// <summary>
    /// Log user out when clicking on file > logout
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_Click_LogOut(object sender, RoutedEventArgs e)
    {

        this.Visibility = Visibility.Hidden;
        _trayIcon.Visibility = Visibility.Hidden;

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

#endregion

#region Insert Window eventhandlers

        /// <summary>
        /// Open the Add New Plant subitem under Accessories menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_AddPlant(object sender, RoutedEventArgs e)
        {
            addPlantWindow = new AddPlant(_userSession);
            addPlantWindow.Show();
            addPlantWindow.Focus();
        }

        /// <summary>
        /// Open the Add Purchase window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_AddPurchase(object sender, RoutedEventArgs e)
        {
            addPurchaseWindow = new AddPurchase(_userSession);
            addPurchaseWindow.Show();
            addPurchaseWindow.Focus();
        }

        /// <summary>
        /// Open the Add Tank window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_AddTank(object sender, RoutedEventArgs e)
        {
            tankWindow = new AddTank(_userSession);
            tankWindow.Show();
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
            fishWindow.Show();
            fishWindow.Focus();
        }

        #endregion

        private void NotificationsMenu_Click_NotificationsDashboard(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {

        }

        private void WarningNotificationsMenu_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {

        }
    }
}
