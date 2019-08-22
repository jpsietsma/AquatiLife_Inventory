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
    
    public partial class Stores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stores()
        {
            this.Business_Customers = new HashSet<Business_Customers>();
            this.ContactInfo = new HashSet<ContactInfo>();
            this.UserPurchases = new HashSet<UserPurchases>();
        }
    
        public int pk_StoreID { get; set; }
        public string StoreName { get; set; }
        public Nullable<int> fk_ContactInfo { get; set; }
        public Nullable<int> fk_StoreWeeklySchedule { get; set; }
        public Nullable<int> fk_StoreHolidaySchedule { get; set; }
        public string CanOrderOnline { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Business_Customers> Business_Customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactInfo> ContactInfo { get; set; }
        public virtual StoreHolidaySchedules StoreHolidaySchedules { get; set; }
        public virtual StoreWeeklySchedules StoreWeeklySchedules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPurchases> UserPurchases { get; set; }
    }
}
