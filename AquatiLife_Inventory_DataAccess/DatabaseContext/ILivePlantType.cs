using System.Collections.Generic;

namespace AquatiLife_Inventory_DataAccess.DatabaseContext
{
    public interface ILivePlantType
    {
        bool CanFloat { get; set; }
        int fk_LightingLevel { get; set; }
        int fk_PlantSizeClass { get; set; }
        int fk_PurchaseCategory { get; set; }
        List_PlantSizeClasses List_PlantSizeClasses { get; set; }
        List_TankLightingLevels List_TankLightingLevels { get; set; }
        bool NeedsFertilizer { get; set; }
        int pk_PlantID { get; set; }
        int? PlantIdealTemp { get; set; }
        string PlantImage { get; set; }
        double? PlantMaxHeight { get; set; }
        int PlantMaxTemp { get; set; }
        int PlantMinTemp { get; set; }
        string PlantName { get; set; }
    }
}