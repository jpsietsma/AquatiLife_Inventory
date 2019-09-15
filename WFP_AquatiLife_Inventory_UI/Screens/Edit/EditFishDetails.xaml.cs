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
using WFP_AquatiLife_Inventory_UI.PopulateUI;

namespace WFP_AquatiLife_Inventory_UI.Screens.Edit
{
    /// <summary>
    /// Interaction logic for EditFishDetails.xaml
    /// </summary>
    public partial class EditFishDetails : Window
    {
        public vw_MasterFishView data { get; private set; }
        public EditFishDetails(int fishPK, AuthenticatedUserSession _session)
        {
            InitializeComponent();

            var a = new vw_MasterFishView();

            ddlFishHomeTank.PopulateUI_DDL_UserTanks(_session);
            ddlEditFishType.PopulateUI_DDL_FishTypes(_session);
            ddlFishFeederType.PopulateUI_DDL_FeederTypes(_session);
            ddlPurchaseStore.PopulateUI_DDL_Stores(_session);
            ddlBirthType.PopulateUI_DDL_BirthTypes(_session);

            using (DatabaseEntities conn = new DatabaseEntities())
            {
                a = conn.vw_MasterFishView.Where(x => x.fk_UserFish == fishPK).First();
            }

            data = a;

            Title = $@"Edit Live Animal Details | { data.FriendlyName.Replace(@"[Deceased] -", "") }";
            numPurchaseCost.Value = Convert.ToDouble(data.PurchaseCost);
            txtEditFriendlyName.Text = data.FriendlyName.Replace(@"[Deceased] - ", "");                     

            txtFishPrimaryColor.Text = data.ColorName;
            txtFishSecondaryColor.Text = data.SecondaryColor;
            dpPurchaseDate.DateTimeText = data.PurchaseDate;
            cbxEditFriendlyName.IsChecked = Convert.ToBoolean(data.IsAlive);
            EditDetailsImage.Source = new BitmapImage(new Uri(data.FishTypeImagePath,UriKind.RelativeOrAbsolute));
            ddlBirthType.SelectedItem = data.BirthingType;
            ddlEditFishType.SelectedItem = data.TypeName;
            ddlFishFeederType.SelectedItem = data.FeedingType;
            ddlFishHomeTank.SelectedItem = data.TankDisplayName;
            ddlPurchaseStore.SelectedItem = data.StoreName;

            //If our fish is deceased, set its usertank dropdown to disabled
            if (!Convert.ToBoolean(data.IsAlive))
            {
                ddlFishHomeTank.IsEnabled = false;
                ddlFishHomeTank.Items.Insert(0, new ComboBoxItem() { Content = @"[Deceased]"});
                ddlFishHomeTank.SelectedIndex = 0;

                btnRecordDeath.IsEnabled = false;
                btnRecordDeath.Content = "Deceased";

            }

        }
    }
}
