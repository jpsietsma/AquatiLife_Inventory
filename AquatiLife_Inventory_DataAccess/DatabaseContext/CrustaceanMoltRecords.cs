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
    
    public partial class CrustaceanMoltRecords
    {
        public int pk_MoltRecordID { get; set; }
        public int fk_UserFishID { get; set; }
        public System.DateTime MoltDate { get; set; }
    
        public virtual UserFish UserFish { get; set; }
    }
}
