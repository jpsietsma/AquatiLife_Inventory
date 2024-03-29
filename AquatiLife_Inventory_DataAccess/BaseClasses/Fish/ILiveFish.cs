﻿using System;
using System.Drawing;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
using AquatiLife_Inventory_DataAccess.enums.AccessoryOptions;
using AquatiLife_Inventory_DataAccess.enums.FishProperties;

namespace AquatiLife_Inventory_DataAccess.BaseClasses.Fish
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
        double? PurchasePrice { get; set; }
        string ScientificName { get; set; }
        double? Size { get; set; }
        FishSocialTemperament SocialLevel { get; set; }

        double? GetMaxSizeCM();
        double? GetMaxSizeInch();
    }
}