using System;
using System.Windows.Media;
using AquatiLife_Inventory.AccessoryOptions;
using AquatiLife_Inventory.FishProperties;
using AquatiLife_Inventory.PurchaseOptions;

namespace AquatiLife_Inventory.ModelBaseClasses
{
    public interface ILiveFish
    {
        FishTemperament AgressionLevel { get; set; }
        FishBirthType BirthingMethod { get; set; }
        string CommonName { get; set; }
        AccessoryType EntityType { get; set; }
        FishFeederType FeederType { get; set; }
        double FishMaxPH { get; set; }
        int FishMaxTemp { get; set; }
        double FishMinPH { get; set; }
        int FishMinTemp { get; set; }
        bool IsAlive { get; set; }
        string Name { get; set; }
        Color PrimaryColor { get; set; }
        DateTime PurchaseDate { get; set; }
        Locations PurchaseLocation { get; set; }
        double? PurchasePrice { get; set; }
        string ScientificName { get; set; }
        Color SecondaryColor { get; set; }
        double? Size { get; set; }
        FishSocialTemperament SocialLevel { get; set; }

        double? GetMaxSizeCM();
        double? GetMaxSizeInch();
    }
}