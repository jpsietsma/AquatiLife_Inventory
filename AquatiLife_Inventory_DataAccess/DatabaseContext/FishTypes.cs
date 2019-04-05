//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AquatiLife_Inventory_DataAccess.DatabaseContext
{
    using AquaModClasses.BaseClassModels;
    using System;
    using System.Collections.Generic;
    
    public partial class FishTypes
    {
        public int pk_FishTypeID { get; set; }
        public string FishTypeName { get; set; }
        public string FishTypeImagePath { get; set; }
        public string FishFeederType { get; set; }
        public string FishBirthingType { get; set; }
        public Nullable<int> FishMinTankSize { get; set; }
        public string FishAgressionLevel { get; set; }
        public string FishTerritorialLevel { get; set; }
        public int fk_WaterType { get; set; }
        public Nullable<int> fk_CareGuideID { get; set; }
    
        public virtual FishCareGuides FishCareGuides { get; set; }
        public virtual WaterTypes WaterTypes { get; set; }
    }
}
