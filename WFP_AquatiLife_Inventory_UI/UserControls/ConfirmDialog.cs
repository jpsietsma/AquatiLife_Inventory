using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.ViewModels.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;

namespace WFP_AquatiLife_Inventory_UI.UserControls
{
    public class ConfirmDialog : RadWindow
    {
        public DialogType _dialogType { get; set; }
        public AuthenticatedUserSession _userSession { get; set; }
        public DashboardWindow _parentWindow { get; set; }
        public bool UserChoice { get; set; }

        public void ShowConfirm()
        {
            RadWindow.Confirm(Content, this.OnClosed);
        }

        private void OnClosed(object sender, WindowClosedEventArgs e)
        {
            switch (e.DialogResult)
            {
                //User clicked OK button
                case true:
                    {
                        UserChoice = true;
                        
                        break;
                    }

                //User clicked cancel button or cloesd window
                case null:
                case false:
                    {
                        UserChoice = false;
                        break;
                    }
            }
        }

        public ConfirmDialog(DialogType _type, AuthenticatedUserSession _session)
        {
            _userSession = _session;
            _dialogType = _type;

            if (_dialogType == DialogType.LOGOUT)
            {
                Content = "Are you sure you want to log out?";
            }
            else
            {
                Content = "Are you sure you want to exit the program?";
            }
        }

        public enum DialogType
        {
            EXIT, LOGOUT, 
        }
    }
}
