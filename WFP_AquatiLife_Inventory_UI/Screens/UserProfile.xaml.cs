using AquatiLife_Inventory_DataAccess.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for UserProfileDashboard.xaml
    /// </summary>
    public partial class UserProfile : Window
    {
        public UserProfile(AuthenticatedUserSession _session)
        {
            InitializeComponent();

            UserNameText.Text = _session.UserName;

            foreach (PropertyInfo _prop in _session.UserPermissions.GetType().GetProperties())
            {
               UserPermissionText.Text += _prop.Name + ": " + _prop.GetValue(_session.UserPermissions) + ";";
            }
        }
    }
}
