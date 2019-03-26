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
        public AuthenticatedUserSession _userSession { get; set; } = null;
        UserLogin _login = new UserLogin();

        public MainWindow()
        {
            InitializeComponent();
            this.Visibility = Visibility.Hidden;

            if (_userSession == null)
            {                
                _login.Visibility = Visibility.Visible;
                _login.Title = "User Login";
            }
        }
    }
}
