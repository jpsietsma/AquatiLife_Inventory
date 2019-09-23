using AquatiLife_Inventory_DataAccess.DatabaseContext;
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
using Telerik.Windows.Controls;
using ViewModelClasses.Users;

namespace WFP_AquatiLife_Inventory_UI.Screens.Users
{
    /// <summary>
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : RadWindow
    {
        public NewUserAccountViewModel _newUser { get; set; }

        public AddUser()
        {
            InitializeComponent();
        }

        private void CancelCreateUserButton_Click(object sender, RoutedEventArgs e)
        {
            _newUser = null;
            this.Close();
        }

        private void SignInNextStepCreateUserButton_Click(object sender, RoutedEventArgs e)
        {
            PermissionsTab.IsEnabled = true;
        }

        private void ProfileNextStepCreateUserButton_Click(object sender, RoutedEventArgs e)
        {
            PermissionsTab.IsEnabled = true;
        }

        private void PermissionsNextStepCreateUserButton_Click(object sender, RoutedEventArgs e)
        {
            ProfileTab.IsEnabled = true;
        }

        private void FinalizeCreateUserButton_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                //conn.Users.Add(_newUser).
            }
        }
    }
}
