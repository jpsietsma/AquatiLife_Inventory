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
    
    public partial class List_TankTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public List_TankTypes()
        {
            this.UserTanks = new HashSet<UserTanks>();
        }
    
        public int pk_TankTypeID { get; set; }
        public string TypeName { get; set; }
        public string TankSpecialTags { get; set; }
        public string TankShape { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTanks> UserTanks { get; set; }
    }
}
