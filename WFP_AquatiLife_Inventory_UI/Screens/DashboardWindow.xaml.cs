using WFP_AquatiLife_Inventory_UI.Screens;
using WFP_AquatiLife_Inventory_UI.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using AquatiLife_Inventory_DataAccess.Authentication;
using Hardcodet.Wpf.TaskbarNotification;
using Telerik.Windows.Controls;
using WFP_AquatiLife_Inventory_UI.Screens.Edit;
using WFP_AquatiLife_Inventory_UI.Screens.Users;

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
        public UserProfile profileWindow { get; set; }
        public AuthenticatedUserSession _userSession { get; set; }
        public TaskbarIcon _trayIcon { get; set; }
        public AddPlant addPlantWindow { get; set; }
        public AddPurchase addPurchaseWindow { get; set; }
        public PurchaseHistory purchaseHistoryWindow { get; set; }
        public EditFishDetails editFishWindow { get; set; }

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

            ErrorNotificationsMenuIcon.Source = new BitmapImage(new Uri("../images/UI/Icons/MenuIcon_NofiticationIcon.png", UriKind.Relative));
            WarningNotificationMenuIcon.Source = new BitmapImage(new Uri("../images/UI/Icons/MenuIcon_WarningIcon.png", UriKind.Relative));

            if (_session.IsAdmin)
            {
                AdministratorMenu.Visibility = Visibility.Visible;
                ErrorNotificationsMenu.Visibility = Visibility.Visible;
            }

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
        /// Open the profile dashboard for the current authenticated session
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_MyProfile(object sender, RoutedEventArgs e)
        {
            profileWindow = new UserProfile(_userSession);
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
        ConfirmDialog confirm = new ConfirmDialog(ConfirmDialog.DialogType.LOGOUT, _userSession);
            confirm.Show();

        //User clicks ok button
        if (confirm.UserChoice)
        {
            this._userSession.LogOut();
        }

    }

        /// <summary>
        /// Prompt user to exit application when clicking File > Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_Exit(object sender, RoutedEventArgs e)
        {
            ConfirmDialog _confirm = new ConfirmDialog(ConfirmDialog.DialogType.EXIT, _userSession);
            _confirm.ShowConfirm();

            //User clicks ok button
            if (_confirm.UserChoice)
            {
                _userSession.LogOut();
                App.Current.Shutdown();
            }
            
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

        /// <summary>
        /// Logout menu item under My Account is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_LogOut(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            ConfirmDialog _confirm = new ConfirmDialog(ConfirmDialog.DialogType.LOGOUT, _userSession);
            _confirm.ShowConfirm();

            //User clicks ok button
            if (_confirm.UserChoice)
            {
                this._userSession.LogOut();

                this.Visibility = Visibility.Hidden;
                this._trayIcon.Visibility = Visibility.Hidden;

                UserLogin _login = new UserLogin();

                loginWindow = _login;

                loginWindow.Show();
                loginWindow.Topmost = true;
                loginWindow.Focus();

            }

        }

        private void MenuItem_Click_PurchaseHistory(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            PurchaseHistory history = new PurchaseHistory(_userSession);

            purchaseHistoryWindow = history;

            purchaseHistoryWindow.ShowDialog();
            purchaseHistoryWindow.Topmost = true;
            purchaseHistoryWindow.Focus();
        }

        private void RadMenuItem_Click_UserDashboard(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {

        }

        private void RadMenuItem_Click_AdminAddUser(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            AddUser addUserWindow = new AddUser(_userSession);

            addUserWindow.ShowDialog();
            addUserWindow.IsTopmost = true;
            addUserWindow.Focus();
        }
    }
}
