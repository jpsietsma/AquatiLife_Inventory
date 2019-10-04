using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Telerik.Windows.Controls;

namespace WFP_AquatiLife_Inventory_UI.PopulateUI
{
    public static class PopulateUI_Controls_DDL
    {

        /// <summary>
        /// Populate combobox with plant type names
        /// </summary>
        /// <param name="_combo"></param>
        public static void PopulateUI_DDL_PlantTypes(this RadComboBox _combo)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.vw_PlantDictionary.Select(x => x.PlantType).ToList();
                int idx = 0;

                _combo.Items.Insert(idx, "- Select Plant Type -");

                foreach (var _type in a)
                {
                    idx++;
                    _combo.Items.Insert(idx, _type);
                }

                if (_combo.SelectedValue == null)
                {
                    _combo.SelectedIndex = 0;
                }
            }
            
        }

        /// <summary>
        /// Populate combobox with a list of tanks owned by the user in the passed session
        /// </summary>
        /// <param name="_combo"></param>
        /// <param name="_session"></param>
        public static void PopulateUI_DDL_UserTanks(this RadComboBox _combo, AuthenticatedUserSession _session)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.vw_UserTanks.Where(x => x.UserName == _session.UserName).ToList();
                int idx = 0;

                _combo.Items.Insert(idx, " - Select User Tank -");

                foreach (var tank in a)
                {
                    idx++;
                    _combo.Items.Insert(idx, tank.TankSize + "gal -" + tank.TankDisplayName);
                }

                if (_combo.SelectedValue == null)
                {
                    _combo.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// Get plant type image path
        /// </summary>
        /// <param name="_image">image object to populate with plant image</param>
        /// <param name="pkType">PK of plant type for image</param>
        /// <returns>string path to image of plant type</returns>
        public static string PopulateUI_Image_PlantTypes(this Image _image, int pkType)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                return conn.vw_PlantDictionary.Where(x => x.TypeID == pkType).Select(x => x.Image).First();
            }
        }

        /// <summary>
        /// Populate combobox with Purchase Categories
        /// </summary>
        /// <param name="_combo"></param>
        /// <param name="_session"></param>
        public static void PopulateUI_DDL_PurchaseCategories(this RadComboBox _combo, AuthenticatedUserSession _session)
        {

            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.List_PurchaseCategories.ToList();
                int idx = 0;

                _combo.Items.Insert(idx, " - Select Category -");

                foreach (var category in a)
                {
                    idx++;
                    _combo.Items.Insert(idx, category.PurchaseTypeDescription);
                }

                if (_combo.SelectedValue == null)
                {
                    _combo.SelectedIndex = 0;
                }
            }

        }

        /// <summary>
        /// Populate combobox items with Stores
        /// </summary>
        /// <param name="_combo"></param>
        /// <param name="_session"></param>
        public static void PopulateUI_DDL_Stores(this RadComboBox _combo, AuthenticatedUserSession _session)
        {
            _combo.Items.Insert(0, " - Select Store -");

            if (_combo.SelectedValue == null)
            {
                _combo.SelectedIndex = 0;
            }

            using (DatabaseEntities conn = new DatabaseEntities())
            {             
                foreach (var store in conn.Stores.ToList())
                {
                    _combo.Items.Insert(store.pk_StoreID, store.StoreName);
                }
                
            }

        }

        /// <summary>
        /// Populate combobox items with usernames
        /// </summary>
        /// <param name="_combo"></param>
        /// <param name="_session"></param>
        public static void PopulateUI_DDL_Users(this RadComboBox _combo, AuthenticatedUserSession _session)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.Users.Select(x => x.UserName).ToList();
                int idx = 0;

                _combo.Items.Insert(idx, "- Select User -");

                foreach (var username in a)
                {
                    idx++;
                    _combo.Items.Insert(idx, username);
                }

                if (_session.UserPermissions.AddPurchase || _session.UserPermissions.ViewGlobalProgramUsers)
                {
                    _combo.IsEnabled = true;
                }

                _combo.SelectedValue = _session.UserName;
                
            }
        }

        /// <summary>
        /// Populate combobox items with watertypes
        /// </summary>
        /// <param name="_combo"></param>
        /// <param name="_session"></param>
        public static void PopulateUI_DDL_TankWaterTypes (this RadComboBox _combo, AuthenticatedUserSession _session)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.List_WaterTypes.Select(x => x.WaterTypeName).ToList();
                int idx = 0;

                _combo.Items.Insert(idx, "-- Select Water Type --");

                foreach (var _waterType in a)
                {
                    idx++;
                    _combo.Items.Insert(idx, _waterType);
                }

                _combo.SelectedIndex = 0;
            }
        }


        public static void PopulateUI_DDL_FishTypes(this RadComboBox _combo, AuthenticatedUserSession _session)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.FishTypes.Select(x => x.TypeName).ToList();
                int idx = 0;

                _combo.Items.Insert(idx, "-- Select Fish Type --");

                foreach (var _fishType in a)
                {
                    idx++;
                    _combo.Items.Insert(idx, _fishType);
                }

                _combo.SelectedIndex = 0;
            }
        }


        public static void PopulateUI_DDL_FeederTypes(this RadComboBox _combo, AuthenticatedUserSession _session)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.List_FishFeedingTypes.Select(x => x.FeedingType).ToList();
                int idx = 0;

                _combo.Items.Insert(idx, "-- Select Feeder Type --");

                foreach (var _feedType in a)
                {
                    idx++;
                    _combo.Items.Insert(idx, _feedType);
                }

                _combo.SelectedIndex = 0;
            }
        }

        public static void PopulateUI_DDL_BirthTypes(this RadComboBox _combo, AuthenticatedUserSession _session)
        {
            using (DatabaseEntities conn = new DatabaseEntities())
            {
                var a = conn.List_FishBirthingTypes.Select(x => x.BirthingType).ToList();
                int idx = 0;

                _combo.Items.Insert(idx, "-- Select Birth Type --");

                foreach (var _fishType in a)
                {
                    idx++;
                    _combo.Items.Insert(idx, _fishType);
                }

                _combo.SelectedIndex = 0;
            }
        }

    }
}
