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
    
    public partial class Errorlogs
    {
        public int pk_errorID { get; set; }
        public int fk_ErrorType { get; set; }
        public System.DateTime ErrorDate { get; set; }
        public Nullable<int> fk_errorUser { get; set; }
        public string ErrorTitle { get; set; }
        public string ErrorDetails { get; set; }
        public string ErrorSourceScreen { get; set; }
        public string ErrorSourceAction { get; set; }
        public string ErrorRecommendedResolution { get; set; }
    
        public virtual Users Users { get; set; }
    }
}