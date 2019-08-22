using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
using AquatiLife_Inventory_DataAccess.GlobalMethods;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using WFP_AquatiLife_Inventory_UI.PopulateUI;

namespace WFP_AquatiLife_Inventory_UI.Screens
{
    /// <summary>
    /// Interaction logic for AddTank.xaml
    /// </summary>
    public partial class AddTank : Window
    {
        public AuthenticatedUserSession _userSession { get; set; }

        public UserTanks NewTank { get; set; }

        public AddTank(AuthenticatedUserSession _session)
        {
            InitializeComponent();

            _userSession = _session;

            ddlWaterType.PopulateUI_DDL_TankWaterTypes(_session);

        }

        /// <summary>
        /// Add new tank to database for user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewTank_ButtonClicked(object sender, RoutedEventArgs e)
        {
            NewTank.TankDisplayName = TankNameTxt.Text;
            NewTank.fk_TankWaterType = DatabaseRetrieval.GetWaterTypeIDByName(ddlWaterType.SelectedValue.ToString());
            NewTank.fk_TankOwner = _userSession.UserID;
            NewTank.fk_TankType = 1;

            switch (sldCapacityGallon.Value)
            {
                case 5:
                    {
                        switch (ddlTankStyle.SelectedValue)
                        {

                            case TankBuildStyles.Standard:
                                {
                                    NewTank.TankWidth = "17";
                                    NewTank.TankHeight = "11";
                                    break;
                                }

                        }

                        break;
                    }

                case 10:
                    {
                        switch (ddlTankStyle.SelectedValue)
                        {

                            case TankBuildStyles.Standard:
                                {
                                    NewTank.TankWidth = "20";
                                    NewTank.TankHeight = "13";
                                    break;
                                }

                            case TankBuildStyles.Long:
                                {
                                    NewTank.TankWidth = "24";
                                    NewTank.TankHeight = "13";
                                    break;
                                }

                            case TankBuildStyles.Tall:
                                {
                                    NewTank.TankWidth = "20";
                                    NewTank.TankHeight = "17";
                                    break;
                                }
                        }

                        break;
                    }

                case 20:
                    {
                        switch (ddlTankStyle.SelectedValue)
                        {

                            case TankBuildStyles.Standard:
                                {
                                    NewTank.TankWidth = "24";
                                    NewTank.TankHeight = "13";
                                    break;
                                }

                            case TankBuildStyles.Tall:
                                {
                                    NewTank.TankWidth = "24";
                                    NewTank.TankHeight = "17";
                                    break;
                                }

                            case TankBuildStyles.Long:
                                {
                                    NewTank.TankWidth = "30";
                                    NewTank.TankHeight = "13";
                                    break;
                                }
                        }

                        break;
                    }

                case 30:
                    {
                        switch (ddlTankStyle.SelectedValue)
                        {

                            case TankBuildStyles.Standard:
                                {
                                    NewTank.TankWidth = "36";
                                    NewTank.TankHeight = "16";
                                    break;
                                }

                            case TankBuildStyles.Tall:
                                {
                                    NewTank.TankWidth = "24";
                                    NewTank.TankHeight = "24";
                                    break;
                                }

                            case TankBuildStyles.Long:
                                {
                                    NewTank.TankWidth = "36";
                                    NewTank.TankHeight = "16";
                                    break;
                                }
                        }

                        break;
                    }

                case 55:
                    {
                        switch (ddlTankStyle.SelectedValue)
                        {

                            case TankBuildStyles.Standard:
                                {
                                    NewTank.TankWidth = "48";
                                    NewTank.TankHeight = "21";
                                    break;
                                }

                            case TankBuildStyles.Tall:
                                {
                                    NewTank.TankWidth = "0";
                                    NewTank.TankHeight = "1";
                                    break;
                                }

                            case TankBuildStyles.Long:
                                {
                                    NewTank.TankWidth = "1";
                                    NewTank.TankHeight = "0";
                                    break;
                                }
                        }

                        break;
                    }

                case 75:
                    {
                        switch (ddlTankStyle.SelectedValue)
                        {

                            case TankBuildStyles.Standard:
                                {
                                    NewTank.TankWidth = "0";
                                    NewTank.TankHeight = "0";
                                    break;
                                }

                            case TankBuildStyles.Tall:
                                {
                                    NewTank.TankWidth = "0";
                                    NewTank.TankHeight = "1";
                                    break;
                                }

                            case TankBuildStyles.Long:
                                {
                                    NewTank.TankWidth = "1";
                                    NewTank.TankHeight = "0";
                                    break;
                                }
                        }

                        break;
                    }

                case 100:
                    {
                        switch (ddlTankStyle.SelectedValue)
                        {

                            case TankBuildStyles.Standard:
                                {
                                    NewTank.TankWidth = "0";
                                    NewTank.TankHeight = "0";
                                    break;
                                }

                            case TankBuildStyles.Tall:
                                {
                                    NewTank.TankWidth = "0";
                                    NewTank.TankHeight = "1";
                                    break;
                                }

                            case TankBuildStyles.Long:
                                {
                                    NewTank.TankWidth = "1";
                                    NewTank.TankHeight = "0";
                                    break;
                                }
                        }

                        break;
                    }

                case 125:
                    {
                        switch (ddlTankStyle.SelectedValue)
                        {

                            case TankBuildStyles.Standard:
                                {
                                    NewTank.TankWidth = "0";
                                    NewTank.TankHeight = "0";
                                    break;
                                }

                            case TankBuildStyles.Tall:
                                {
                                    NewTank.TankWidth = "0";
                                    NewTank.TankHeight = "1";
                                    break;
                                }

                            case TankBuildStyles.Long:
                                {
                                    NewTank.TankWidth = "1";
                                    NewTank.TankHeight = "0";
                                    break;
                                }
                        }

                        break;
                    }

                case 150:
                    {
                        switch (ddlTankStyle.SelectedValue)
                        {

                            case TankBuildStyles.Standard:
                                {
                                    NewTank.TankWidth = "0";
                                    NewTank.TankHeight = "0";
                                    break;
                                }

                            case TankBuildStyles.Tall:
                                {
                                    NewTank.TankWidth = "0";
                                    NewTank.TankHeight = "1";
                                    break;
                                }

                            case TankBuildStyles.Long:
                                {
                                    NewTank.TankWidth = "1";
                                    NewTank.TankHeight = "0";
                                    break;
                                }
                        }

                        break;
                    }

                case 175:
                    {
                        switch (ddlTankStyle.SelectedValue)
                        {

                            case TankBuildStyles.Standard:
                                {
                                    NewTank.TankWidth = "0";
                                    NewTank.TankHeight = "0";
                                    break;
                                }

                            case TankBuildStyles.Tall:
                                {
                                    NewTank.TankWidth = "0";
                                    NewTank.TankHeight = "1";
                                    break;
                                }

                            case TankBuildStyles.Long:
                                {
                                    NewTank.TankWidth = "1";
                                    NewTank.TankHeight = "0";
                                    break;
                                }
                        }

                        break;
                    }

                case 200:
                    {
                        switch (ddlTankStyle.SelectedValue)
                        {

                            case TankBuildStyles.Standard:
                                {
                                    NewTank.TankWidth = "0";
                                    NewTank.TankHeight = "0";
                                    break;
                                }

                            case TankBuildStyles.Tall:
                                {
                                    NewTank.TankWidth = "0";
                                    NewTank.TankHeight = "1";
                                    break;
                                }

                            case TankBuildStyles.Long:
                                {
                                    NewTank.TankWidth = "1";
                                    NewTank.TankHeight = "0";
                                    break;
                                }
                        }

                        break;
                    }

            }

            using (DatabaseEntities conn = new DatabaseEntities())
            {
                try
                {
                    var a = conn.UserTanks.Add(NewTank);
                    conn.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to save changes: " + ex.Message);
                }
                
            }
        }

        private enum TankBuildStyles
        {
            Standard, Tall, Long
        }

        private enum TankShapes
        {
            Rectangle, Cube, Octagon, Bow_Front
        }

    }
}
