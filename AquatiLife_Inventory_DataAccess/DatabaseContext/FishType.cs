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
    
    public partial class FishType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FishType()
        {
            this.UserFish = new HashSet<UserFish>();
        }
    
        public int pk_FishTypeID { get; set; }
        public string FishTypeName { get; set; }
        public string FishTypeImagePath { get; set; }
        public string FishFeederType { get; set; }
        public string FishBirthingType { get; set; }
        public Nullable<int> FishMinTankSize { get; set; }
        public string FishAgressionLevel { get; set; }
        public string FishTerritorialLevel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFish> UserFish { get; set; }
    }
}