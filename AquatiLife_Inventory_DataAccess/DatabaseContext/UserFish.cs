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
    
    public partial class UserFish
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserFish()
        {
            this.CrustaceanMoltRecords = new HashSet<CrustaceanMoltRecords>();
            this.UserFishInventory = new HashSet<UserFishInventory>();
            this.UserPurchases = new HashSet<UserPurchases>();
        }
    
        public int pk_UserFishID { get; set; }
        public int IsAlive { get; set; }
        public string FishNotes { get; set; }
        public Nullable<double> SizeLength { get; set; }
        public string FriendlyName { get; set; }
        public Nullable<int> fk_fishColor { get; set; }
        public Nullable<int> fk_fishColorSecondary { get; set; }
        public Nullable<int> fk_fishSex { get; set; }
        public Nullable<System.DateTime> LastTankMove { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CrustaceanMoltRecords> CrustaceanMoltRecords { get; set; }
        public virtual List_FishColors List_FishColors { get; set; }
        public virtual List_FishColors List_FishColors1 { get; set; }
        public virtual List_FishSexes List_FishSexes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFishInventory> UserFishInventory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPurchases> UserPurchases { get; set; }
    }
}
