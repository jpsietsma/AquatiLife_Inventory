using System.Collections.Generic;

namespace AquatiLife_Inventory_DataAccess.DatabaseContext
{
    public interface IFishTypes
    {
        FishCareGuides FishCareGuides { get; set; }
        int? FishMinTankSize { get; set; }
        ICollection<FishTypeDiseaseAffection> FishTypeDiseaseAffection { get; set; }
        string FishTypeImagePath { get; set; }
        int fk_BirthingType { get; set; }
        int? fk_CareGuideID { get; set; }
        int fk_FishAgressionLevel { get; set; }
        int fk_FishFamily { get; set; }
        int fk_FishFeederType { get; set; }
        int fk_FishTerritorialLevel { get; set; }
        int fk_WaterType { get; set; }
        List_FishAgressionLevels List_FishAgressionLevels { get; set; }
        List_FishFamilyTypes List_FishFamilyTypes { get; set; }
        List_FishFamilyTypes List_FishFamilyTypes1 { get; set; }
        List_FishFeedingTypes List_FishFeedingTypes { get; set; }
        List_FishTerritorialLevels List_FishTerritorialLevels { get; set; }
        List_WaterTypes List_WaterTypes { get; set; }
        int pk_FishTypeID { get; set; }
        string TypeName { get; set; }
    }
}