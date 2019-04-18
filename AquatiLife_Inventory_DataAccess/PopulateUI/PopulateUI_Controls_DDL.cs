using AquatiLife_Inventory_DataAccess.Authentication;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WFP_AquatiLife_Inventory_UI.PopulateUI
{
    public static class PopulateUI_Controls_DDL
    {
        public static void PopulateUI_DDL_PlantTypes(this ComboBox _combo)
        {
            using (Entities conn = new Entities())
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

        public static void PopulateUI_DDL_UserTanks(this ComboBox _combo, AuthenticatedUserSession _session)
        {
            using (Entities conn = new Entities())
            {
                var a = conn.vw_UserTanks.Where(x => x.UserName == _session.UserName).ToList();
                int idx = 0;

                _combo.Items.Insert(idx, " - Select User Tank -");

                foreach (var tank in a)
                {
                    idx++;
                    _combo.Items.Insert(idx, tank.Tank_ID);
                }

                if (_combo.SelectedValue == null)
                {
                    _combo.SelectedIndex = 0;
                }
            }
        }

        public static string PopulateUI_Image_PlantTypes(this Image _image, int pkType)
        {
            using (Entities conn = new Entities())
            {
                return conn.vw_PlantDictionary.Where(x => x.TypeID == pkType).Select(x => x.Image).First();
            }
        }

        public static void PopulateUI_DDL_PurchaseCategories(this ComboBox _combo, AuthenticatedUserSession _session)
        {

            using (Entities conn = new Entities())
            {
                var a = conn.List_PurchaseCategories.ToList();
                int idx = 0;

                _combo.Items.Insert(idx, " - Select Purchase Category -");

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

        public static void PopulateUI_DDL_Stores(this ComboBox _combo, AuthenticatedUserSession _session)
        {

            using (Entities conn = new Entities())
            {
                var a = conn.Stores.ToList();
                int idx = 0;

                _combo.Items.Insert(idx, " - Select Store -");

                foreach (var store in a)
                {
                    idx++;
                    _combo.Items.Insert(idx, store.StoreName);
                }

                if (_combo.SelectedValue == null)
                {
                    _combo.SelectedIndex = 0;
                }
            }

        }
    }
}
