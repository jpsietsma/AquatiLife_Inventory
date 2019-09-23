using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModelClasses.enums;

namespace ViewModelClasses.DictionaryEntries.Fish
{
    public class FreshwaterFish
    {
        public FishTemperament FishAgression { get; set; }
        public FishBirthType BirthingMethod { get; set; }
        public string CommonName { get; set; }
        public AccessoryType EntityType { get; set; }
        public FishFeederType FeederType { get; set; }
        public FishFamilyTypes FishFamily { get; set; }
        public double FishMaxPH { get; set; }
        public int FishMaxTemp { get; set; }
        public double FishMinPH { get; set; }
        public int FishMinTemp { get; set; }
        public bool IsAlive { get; set; }
        public string Name { get; set; }
        public string ScientificName { get; set; }
        public double? Size { get; set; }
        public FishSocialTemperament SocialLevel { get; set; }
    }
}