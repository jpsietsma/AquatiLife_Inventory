using AquatiLife_Inventory_DataAccess.DatabaseContext;
using AquatiLife_Inventory_DataAccess.enums.AccessoryOptions;
using AquatiLife_Inventory_DataAccess.enums.FishProperties;
using AquatiLife_Inventory_DataAccess.ViewModels.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.ViewModels.DictionaryEntryViewModels
{
    public class FreshwaterFish : LiveFish, IFishTypes
    {
        public new List_FishAgressionLevels AgressionLevel { get; set; }
        public new List_FishBirthingTypes BirthingMethod { get; set; }
        public new string CommonName { get; set; }
        public new AccessoryType EntityType { get; set; }
        public new List_FishFeedingTypes FeederType { get; set; }
        public List_FishFamilyTypes FishFamily { get; set; }
        public new double FishMaxPH { get; set; }
        public new int FishMaxTemp { get; set; }
        public new double FishMinPH { get; set; }
        public new int FishMinTemp { get; set; }
        public new bool IsAlive { get; set; }
        public new string Name { get; set; }
        public UserPurchases PurchaseTransaction { get; set; }
        public new string ScientificName { get; set; }
        public new double? Size { get; set; }
        public new List_FishTerritorialLevels SocialLevel { get; set; }
        public List<List_FishSicknessTypes> PotentialSickness { get; set; }

        private int FishType { get; set; }

        public FreshwaterFish(FreshwaterFish _parent)
        {
            CommonName = _parent.CommonName;
            AgressionLevel = _parent.AgressionLevel;
            BirthingMethod = _parent.BirthingMethod;
            FishFamily = _parent.List_FishFamilyTypes;
            EntityType = AccessoryType.Fish;
            FeederType = _parent.List_FishFeedingTypes;
            FishMaxPH = _parent.FishMaxPH;
            FishMinPH = _parent.FishMinPH;
            FishMaxTemp = Convert.ToInt32(_parent.FishMaxTemp);
            FishMinTemp = Convert.ToInt32(_parent.FishMinTemp);
            IsAlive = Convert.ToBoolean(_parent.IsAlive);
            Name = _parent.Name;
            ScientificName = _parent.ScientificName;
            Size = _parent.Size;
            FishType = _parent.FishType;

            PotentialSickness = GetSicknessPossibilities();
        }

        public FreshwaterFish()
        {

        }

        /// <summary>
        /// Get list of diseases that could affect fish
        /// </summary>
        /// <returns>List of sickness types that affect this fish type</returns>
        private List<List_FishSicknessTypes> GetSicknessPossibilities()
        {
            List<List_FishSicknessTypes> _final = new List<List_FishSicknessTypes>();

            using (DatabaseEntities conn = new DatabaseEntities())
            {
                List<List_FishSicknessTypes> a = conn.List_FishSicknessTypes.Where(x => x.fk_AffectedTypes.ToString().Contains(FishType.ToString())).ToList();

                if (a.Count() > 0)
                {
                    _final = a;
                }                
            }

            return _final;
        }
    }
}
