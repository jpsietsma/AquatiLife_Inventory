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
    using System;
    using System.Collections.Generic;
    
    public partial class vw_MasterFishDictionary
    {
        public int pk_FishTypeID { get; set; }
        public string AnimalType { get; set; }
        public string FishType { get; set; }
        public string FishFamily { get; set; }
        public double TankEncumbrance { get; set; }
        public string FishTypeImagePath { get; set; }
        public string FeedingType { get; set; }
        public string BirthingType { get; set; }
        public Nullable<int> MinGallons { get; set; }
        public string Agressiveness { get; set; }
        public string TerritorialLevel { get; set; }
        public string WaterTypeName { get; set; }
        public string CareGuideDocumentPath { get; set; }
    }
}
