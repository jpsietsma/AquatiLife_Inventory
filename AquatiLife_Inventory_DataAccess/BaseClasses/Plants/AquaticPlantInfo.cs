using AquatiLife_Inventory_DataAccess.BaseClasses.Accessories;
using AquatiLife_Inventory_DataAccess.BaseClasses.Tank;
using AquatiLife_Inventory_DataAccess.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquatiLife_Inventory_DataAccess.BaseClasses.Plants
{
    /// <summary>
    /// Base class for Live Plants added to tanks
    /// </summary>
    public class AquaticPlantInfo : TankAccessory, ITankAccessory, ILivePlantType
    {
        public bool CanFloat { get; set; }
        public int fk_LightingLevel { get; set; }
        public int fk_PlantSizeClass { get; set; }
        public int fk_PurchaseCategory { get; set; }
        public List_PlantSizeClasses List_PlantSizeClasses { get; set; }
        public List_TankLightingLevels List_TankLightingLevels { get; set; }
        public bool NeedsFertilizer { get; set; }
        public int pk_PlantID { get; set; }
        public int? PlantIdealTemp { get; set; }
        public string PlantImage { get; set; }
        public double? PlantMaxHeight { get; set; }
        public int PlantMaxTemp { get; set; }
        public int PlantMinTemp { get; set; }
        public string PlantName { get; set; }

    }
}
