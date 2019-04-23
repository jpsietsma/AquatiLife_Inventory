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
    
    public partial class List_WaterTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public List_WaterTypes()
        {
            this.FishTypes = new HashSet<FishTypes>();
            this.List_ErrorTypes = new HashSet<List_ErrorTypes>();
            this.List_FishFamilyTypes = new HashSet<List_FishFamilyTypes>();
            this.UserFish = new HashSet<UserFish>();
            this.UserTanks = new HashSet<UserTanks>();
        }
    
        public int pk_WaterTypeID { get; set; }
        public string WaterTypeName { get; set; }
        public string WaterTypeSpecialTags { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FishTypes> FishTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<List_ErrorTypes> List_ErrorTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<List_FishFamilyTypes> List_FishFamilyTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFish> UserFish { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTanks> UserTanks { get; set; }
    }
}