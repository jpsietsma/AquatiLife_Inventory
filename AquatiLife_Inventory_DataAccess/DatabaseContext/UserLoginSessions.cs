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
    
    public partial class UserLoginSessions
    {
        public string pk_SessionID { get; set; }
        public int fk_UserID { get; set; }
        public string SessionBegin { get; set; }
        public string SessionPermission { get; set; }
        public string SessionEnd { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
