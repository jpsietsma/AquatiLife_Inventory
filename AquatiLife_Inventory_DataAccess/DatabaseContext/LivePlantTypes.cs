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
    
    public partial class LivePlantTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LivePlantTypes()
        {
            this.UserLivePlants = new HashSet<UserLivePlants>();
        }
    
        public int pk_PlantID { get; set; }
        public string PlantName { get; set; }
        public int fk_LightingLevel { get; set; }
        public bool NeedsFertilizer { get; set; }
        public bool CanFloat { get; set; }
        public int PlantMinTemp { get; set; }
        public int PlantMaxTemp { get; set; }
        public Nullable<int> PlantIdealTemp { get; set; }
        public Nullable<double> PlantMaxHeight { get; set; }
        public int fk_PlantSizeClass { get; set; }
        public int fk_PurchaseCategory { get; set; }
        public string PlantImage { get; set; }
    
        public virtual List_PlantSizeClasses List_PlantSizeClasses { get; set; }
        public virtual List_TankLightingLevels List_TankLightingLevels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserLivePlants> UserLivePlants { get; set; }
    }
}
