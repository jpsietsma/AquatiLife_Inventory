using AquatiLife_Inventory_DataAccess.Authentication;
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
        public NewUserAccountViewModel _newUserModel { get; set; }
        public NewUserAccountContactInfoViewModel _userContact { get; set; }

        public AuthenticatedUserSession _userSession { get; set; }

        public bool FinalApproved { get; set; }

        public AddUser(AuthenticatedUserSession _session)
        {
            InitializeComponent();
            _userSession = _session;

            _newUserModel = new NewUserAccountViewModel();
            _newUserModel.UserPermissions = new ViewModelClasses.Users.Permissions.UserPermissionsViewModel();

        }

        private void CancelCreateUserButton_Click(object sender, RoutedEventArgs e)
        {
            _newUserModel = null;
            this.Close();
        }

        private void SignInNextStepCreateUserButton_Click(object sender, RoutedEventArgs e)
        {
            _newUserModel.UserName = checkerControl.SearchTextBox.Text;

            _newUserModel.Email = TextboxEmailAddress.Text;
            _newUserModel.Password = PasswordboxUserPassword.Text;


            if (Convert.ToBoolean(acceptTOS.IsChecked.GetValueOrDefault())
                && checkerControl.IsAvailable
                && PasswordboxUserPassword.Text == PasswordBoxUserPasswordConfirm.Text)
            {
                PermissionsTab.IsEnabled = true;
                PermissionsTab.IsSelected = true;
            }
            else if(!checkerControl.IsAvailable)
            {
                MessageBox.Show("Username is taken or unavailable, please choose another.");
            }
            else if (PasswordboxUserPassword.Text != PasswordBoxUserPasswordConfirm.Text)
            {
                MessageBox.Show("Password and Password Confirm must match.");
            }
            else if(!Convert.ToBoolean(acceptTOS.IsChecked))
            {
                MessageBox.Show("You must accept the terms of service to create an account.");
            }
            
        }

        private void PermissionsNextStepCreateUserButton_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(cbxLoginGlobal.IsChecked.GetValueOrDefault()))
            {
                //If global login is set, allow all login types
                _newUserModel.UserPermissions.LoginAPI = true;
                _newUserModel.UserPermissions.LoginDesktop = true;
                _newUserModel.UserPermissions.LoginWeb = true;
                _newUserModel.UserPermissions.LoginMobile = true;
            }
            else
            {
                //Otherwise, set our login permissions as per the checkboxes
                _newUserModel.UserPermissions.LoginAPI = Convert.ToBoolean(cbxLoginApi.IsChecked.GetValueOrDefault());
                _newUserModel.UserPermissions.LoginDesktop = Convert.ToBoolean(cbxLoginDesktop.IsChecked.GetValueOrDefault());
                _newUserModel.UserPermissions.LoginWeb = Convert.ToBoolean(cbxLoginWeb.IsChecked.GetValueOrDefault());
                _newUserModel.UserPermissions.LoginMobile = Convert.ToBoolean(cbxLoginWeb.IsChecked.GetValueOrDefault());
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////
            // we should implement 'add all, edit all, delete all' checkboxes to simplify account creation //
            /////////////////////////////////////////////////////////////////////////////////////////////////

            //Adds
            _newUserModel.UserPermissions.AddDecoration = Convert.ToBoolean(cbxAddDecorations.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.AddFish = Convert.ToBoolean(cbxAddFish.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.AddLivePlant = Convert.ToBoolean(cbxAddPlants.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.AddPurchase = Convert.ToBoolean(cbxAddPurchase.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.AddSupply = Convert.ToBoolean(cbxAddDecorations.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.AddTank = Convert.ToBoolean(cbxAddTanks.IsChecked.GetValueOrDefault());

            //Edits
            _newUserModel.UserPermissions.EditDecoration = Convert.ToBoolean(cbxEditDecorations.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.EditFish = Convert.ToBoolean(cbxEditFish.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.EditLivePlant = Convert.ToBoolean(cbxEditPlants.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.EditPurchase = Convert.ToBoolean(cbxEditPurchase.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.EditSupply = Convert.ToBoolean(cbxEditSupplies.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.EditTank = Convert.ToBoolean(cbxEditTanks.IsChecked.GetValueOrDefault());

            //Deletes
            _newUserModel.UserPermissions.DeleteDecoration = Convert.ToBoolean(cbxDeleteDecorations.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.DeleteFish = Convert.ToBoolean(cbxDeleteFish.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.DeletePlant = Convert.ToBoolean(cbxDeletePlants.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.DeletePurchase = Convert.ToBoolean(cbxDeletePurchase.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.DeleteSupply = Convert.ToBoolean(cbxDeleteDecorations.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.DeleteTank = Convert.ToBoolean(cbxDeleteTanks.IsChecked.GetValueOrDefault());

            //Global
            _newUserModel.UserPermissions.ViewGlobalDecorations = Convert.ToBoolean(cbxViewGlobalDecorations.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.ViewGlobalFish = Convert.ToBoolean(cbxViewGlobalFish.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.ViewGlobalPlants = Convert.ToBoolean(cbxViewGlobalPlants.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.ViewGlobalProgramUsers = Convert.ToBoolean(cbxViewGlobalProgramUsers.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.ViewGlobalPurchases = Convert.ToBoolean(cbxViewGlobalPurchases.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.ViewGlobalSupplies = Convert.ToBoolean(cbxViewGlobalSupplies.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.ViewGlobalTanks = Convert.ToBoolean(cbxViewGlobalTanks.IsChecked.GetValueOrDefault());

            //Miscellaneous / Other
            _newUserModel.UserPermissions.PerformMaintenance = Convert.ToBoolean(cbxPerformMaintenance.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.PerformGlobalMaintenance = Convert.ToBoolean(cbxPerformMaintenanceGlobal.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.RecordDeath = Convert.ToBoolean(cbxRecordDeath.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.RecordGlobalDeath = Convert.ToBoolean(cbxRecordDeathGlobal.IsChecked.GetValueOrDefault());

            //Administrator Priviliges
            _newUserModel.UserPermissions.AddProgramUsers = Convert.ToBoolean(cbxAddProgramUsers.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.EditProgramUsers = Convert.ToBoolean(cbxEditProgramUsers.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.DeleteProgramUsers = Convert.ToBoolean(cbxDeleteProgramUsers.IsChecked.GetValueOrDefault());
            _newUserModel.UserPermissions.AddSuperAdminUser = Convert.ToBoolean(cbxAddSuperAdmin.IsChecked.GetValueOrDefault());

            ProfileTab.IsEnabled = true;
            ProfileTab.IsSelected = true;
        }

        private void ProfileNextStepCreateUserButton_Click(object sender, RoutedEventArgs e)
        {
            _newUserModel.FirstName = UserFirstNameTextbox.Text;
            _newUserModel.LastName = UserLastNameTextbox.Text;
            _newUserModel.AltEmail = UserAltEmailTextbox.Text;
            _newUserModel.StreetAddress = UserStreetAddress.Text;
            _newUserModel.City = UserCityAddressTextbox.Text;
            _newUserModel.State = AddressStateComboBox.InnerStateComboBox.SelectedValue.ToString();
            _newUserModel.ZipCode = UserZipAddressTextbox.Text;
            _newUserModel.PhoneNumber = PhoneNumberTextbox.Text;
            _newUserModel.Website = WebsiteAddressTextbox.Text;

            _newUserModel.ProfileImageUrl = UserProfileImageUploadbox.Text;

            FinalizeTab.IsEnabled = true;
            FinalizeTab.IsSelected = true;

            finalized_FullName.Text = _newUserModel.FirstName + " " + _newUserModel.LastName;
            finalized_UserName.Text = _newUserModel.UserName;

            RadWindow _info = new RadWindow();
            _info.DataContext = _newUserModel;

            foreach (var item in _newUserModel.GetType().GetProperties())
            {                
                if (item.Name.EndsWith("UserPermissions"))
                {
                    _info.Content += item.Name + ": \n";

                    foreach (var permission in _newUserModel.UserPermissions.GetType().GetProperties())
                    {
                        if (!permission.Name.StartsWith("UserProfiles") && !permission.Name.StartsWith("Users") && !permission.Name.StartsWith("pk") && !permission.Name.StartsWith("fk"))
                        {
                            _info.Content += "\t" + permission.Name + ": " + permission.GetValue(_newUserModel.UserPermissions) + "\n";
                        }
                    }                                       
                }
                else
                {
                    if (!item.Name.StartsWith("fk"))
                    {
                        _info.Content += item.Name + ": " + item.GetValue(_newUserModel) + "\n";
                    }                    
                }                                   
            }

            _info.Header = "Confirm the new account details";
            _info.Closed += _info_Closed;

            _info.ShowDialog();
            

            


        }

        private void _info_Closed(object sender, WindowClosedEventArgs e)
        {
            FinalizeCreateUserButton.IsEnabled = true;
        }

        private void FinalizeCreateUserButton_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {                
                if (_userSession.Permissions.AddProgramUsers)
                {
                    try
                    {
                        //Create our user contact record                                              
                        int info_pk = conn.ContactInfo_Add(_newUserModel.FirstName, _newUserModel.LastName, _newUserModel.StreetAddress, _newUserModel.City, _newUserModel.State, _newUserModel.ZipCode, _newUserModel.PhoneNumber, _newUserModel.AltEmail, _newUserModel.Website, null);

                        var x = 0;

                        //create our user permissions record
                        int permissions_pk = conn.UserPermissionsRecord_Add(_newUserModel.UserPermissions.AddProgramUsers, _newUserModel.UserPermissions.AddPurchase, _newUserModel.UserPermissions.AddSupply,
                            _newUserModel.UserPermissions.AddDecoration, _newUserModel.UserPermissions.AddFish, _newUserModel.UserPermissions.AddLivePlant, _newUserModel.UserPermissions.AddTank,
                            _newUserModel.UserPermissions.EditProgramUsers, _newUserModel.UserPermissions.EditPurchase, _newUserModel.UserPermissions.EditSupply, _newUserModel.UserPermissions.EditDecoration,
                            _newUserModel.UserPermissions.EditFish, _newUserModel.UserPermissions.EditLivePlant, _newUserModel.UserPermissions.EditTank, _newUserModel.UserPermissions.ViewGlobalPurchases,
                            _newUserModel.UserPermissions.EditProgramUsers, _newUserModel.UserPermissions.DeletePurchase, _newUserModel.UserPermissions.DeleteSupply, _newUserModel.UserPermissions.DeleteDecoration,
                            _newUserModel.UserPermissions.DeleteFish, _newUserModel.UserPermissions.DeletePlant, _newUserModel.UserPermissions.DeleteTank, _newUserModel.UserPermissions.RecordDeath,
                            _newUserModel.UserPermissions.RecordGlobalDeath, _newUserModel.UserPermissions.PerformMaintenance, _newUserModel.UserPermissions.PerformGlobalMaintenance, _newUserModel.UserPermissions.LoginWeb,
                            _newUserModel.UserPermissions.LoginMobile, _newUserModel.UserPermissions.LoginAPI);

                        
                        //Create our user profile record                 
                        int profile_pk = conn.UserProfiles_Add(info_pk, permissions_pk);

                        // Add user to Database: 
                        int user_pk = conn.Users_Add(profile_pk, _newUserModel.Email, _newUserModel.UserName, _newUserModel.Password);

                        // Save Database Changes: 
                        conn.SaveChanges();

                        RadAlert Alert = new RadAlert();
                        Alert.Content = $@"User Account: { _newUserModel.UserName } \n Has been successfully created!";
                    }
                    catch (Exception ex)
                    {
                        if (ex.InnerException == null)
                        {
                            new RadWindow { Content = $@"Error Occurred: {ex.Message}" }.ShowDialog();
                        }
                        else
                        {
                            new RadWindow { Content = $@"Error Occurred: {ex.InnerException.Message}" }.ShowDialog();
                        }                        
                    }

                }
                else
                {
                    MessageBox.Show("You do not have permission to add new program users. \n Please contact an Administrator for assistance.");
                }
                               
            }
        }

        private void UpdateSignInNextButtonAvailability(object sender, RoutedEventArgs e)
        {
            bool makeAvailable = false;

            if (checkerControl.IsAvailable )
            {
                if (PasswordboxUserPassword.Text != null && PasswordBoxUserPasswordConfirm.Text != null)
                {
                    if (PasswordboxUserPassword.Text != PasswordBoxUserPasswordConfirm.Text)
                    {
                        MessageBox.Show("Password and confirm password fields must match.");
                        makeAvailable = false;
                    }
                    else
                    {
                        if (TextboxEmailAddress.Text != null)
                        {
                            makeAvailable = true;
                        }
                        else
                        {
                            MessageBox.Show("Email field is required for registration!");
                            makeAvailable = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You must enter a password");
                    makeAvailable = false;
                }                
            }

            SignInNextStepCreateUserButton.IsEnabled = makeAvailable;
        }

        private void PermissionsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {            
            //Custom permissions selection
            if (PermissionsComboBox.SelectedIndex == 5)
            {
                CustomPermissionsPanel.Visibility = Visibility.Visible;
            }
        }
    }
}
