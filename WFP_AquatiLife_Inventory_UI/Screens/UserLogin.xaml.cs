using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
using AquatiLife_Inventory_DataAccess.enums;
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
    /// Interaction logic for UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window
    {
        public AuthenticatedUserSession _session { get; set; }

        public UserLogin()
        {            
            InitializeComponent();
        }

        private void LoginSubmit_Click(object sender, RoutedEventArgs e)
        {

            if (UserLoginAccess.CheckUserPass(UserName.Text, Password.Password))
            {
                _session = new AuthenticatedUserSession(UserName.Text);

                UserLoginAccess.LogUserSession(_session, LogType.LOGIN);

                MainWindow _main = new MainWindow(_session);

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");                
            }

        }

    }
}
