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
        public List_FishAgressionLevels AgressionLevel { get; set; }
        public List_FishBirthingTypes BirthingMethod { get; set; }
        public string CommonName { get; set; }
        public AccessoryType EntityType { get; set; }
        public List_FishFeedingTypes FeederType { get; set; }
        public List_FishFamilyTypes FishFamily { get; set; }
        public double FishMaxPH { get; set; }
        public int FishMaxTemp { get; set; }
        public double FishMinPH { get; set; }
        public int FishMinTemp { get; set; }
        public bool IsAlive { get; set; }
        public string Name { get; set; }
        public UserPurchases PurchaseTransaction { get; set; }
        public string ScientificName { get; set; }
        public double? Size { get; set; }
        public List_FishTerritorialLevels SocialLevel { get; set; }
        public List<List_FishSicknessTypes> PotentialSickness { get; set; }

        private int FishType { get; set; }

        public FreshwaterFish(UserFish _parent)
        {
            CommonName = _parent.CommonName;
            AgressionLevel = _parent.List_FishAgressionLevels;
            BirthingMethod = _parent.List_FishBirthingTypes;
            FishFamily = _parent.List_FishFamilyTypes;
            EntityType = AccessoryType.Fish;
            FeederType = _parent.List_FishFeedingTypes;
            FishMaxPH = _parent.FishMaxPH.Value;
            FishMinPH = _parent.FishMinPH.Value;
            FishMaxTemp = Convert.ToInt32(_parent.FishMaxTemp.Value);
            FishMinTemp = Convert.ToInt32(_parent.FishMinTemp.Value);
            IsAlive = Convert.ToBoolean(_parent.IsAlive);
            Name = _parent.FriendlyName;
            ScientificName = _parent.ScientificName;
            Size = _parent.SizeLength.Value;
            FishType = _parent.fk_FishTypeID;

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

            using (Entities conn = new Entities())
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
