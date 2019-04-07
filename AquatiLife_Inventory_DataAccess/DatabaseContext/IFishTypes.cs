using System.Collections.Generic;

namespace AquatiLife_Inventory_DataAccess.DatabaseContext
{
    public interface IFishTypes
    {
        string FishAgressionLevel { get; set; }
        string FishBirthingType { get; set; }
        FishCareGuides FishCareGuides { get; set; }
        string FishFeederType { get; set; }
        int? FishMinTankSize { get; set; }
        string FishTerritorialLevel { get; set; }
        ICollection<FishTypeDiseaseAffection> FishTypeDiseaseAffection { get; set; }
        string FishTypeImagePath { get; set; }
        string FishTypeName { get; set; }
        int? fk_CareGuideID { get; set; }
        int fk_WaterType { get; set; }
        List_WaterTypes List_WaterTypes { get; set; }
        int pk_FishTypeID { get; set; }
    }
}