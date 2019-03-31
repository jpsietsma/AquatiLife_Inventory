using AquatiLife_Inventory_DataAccess.Authentication;
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
using WFP_AquatiLife_Inventory_UI.Screens;

namespace WFP_AquatiLife_Inventory_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AuthenticatedUserSession _userSession;
        UserLogin _login;
        DashboardWindow _dash;

        /// <summary>
        /// Show Login window if user is not logged in or session is not active
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            _login = new UserLogin();
            _login.Visibility = Visibility.Visible;
            _login.Title = "User Login";
            _login.Focus();

            this.Close();

        }

        /// <summary>
        /// Show Dashboard window if user is logged and session is active
        /// </summary>
        /// <param name="_session">User Session</param>
        public MainWindow(AuthenticatedUserSession _session)
        {
            if (_session.IsActive)
            {
                InitializeComponent();
                _userSession = _session;

                _dash = new DashboardWindow(_userSession);
                _dash.Visibility = Visibility.Visible;
                _dash.Focus();

                this.Visibility = Visibility.Hidden;
            }
            else
            {
                InitializeComponent();
 
                _login = new UserLogin();
                _login.Visibility = Visibility.Visible;
                _login.Title = "User Login";
                _login.Focus();

                this.Visibility = Visibility.Hidden;
            }          
        }

    }
}
