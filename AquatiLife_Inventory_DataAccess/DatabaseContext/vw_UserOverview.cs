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
    
    public partial class vw_UserOverview
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string UserRole { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName_FL { get; set; }
        public string FullName_LF { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneFormatted { get; set; }
        public string PhoneNumber { get; set; }
        public string AltEmail { get; set; }
        public string Website { get; set; }
        public string ContactTypeDisplayName { get; set; }
        public bool AddProgramUsers { get; set; }
        public bool AddPurchase { get; set; }
        public bool AddSupply { get; set; }
        public bool AddDecoration { get; set; }
        public bool AddFish { get; set; }
        public bool AddLivePlant { get; set; }
        public bool AddTank { get; set; }
        public bool EditProgramUsers { get; set; }
        public bool EditPurchases { get; set; }
        public bool EditSupply { get; set; }
        public bool EditDecorations { get; set; }
        public bool EditFish { get; set; }
        public bool EditTanks { get; set; }
        public bool EditLivePlants { get; set; }
        public bool ViewGlobalPurchases { get; set; }
        public bool DeleteProgramUsers { get; set; }
        public bool DeletePurchases { get; set; }
        public bool DeleteSupply { get; set; }
        public bool DeleteDecoration { get; set; }
        public bool DeleteFish { get; set; }
        public bool DeletePlants { get; set; }
        public bool DeleteTanks { get; set; }
        public bool RecordDeath { get; set; }
        public bool RecordGlobalDeath { get; set; }
        public bool PerformMaintenance { get; set; }
        public bool PerformGlobalMaintenance { get; set; }
        public bool LoginWeb { get; set; }
        public bool LoginMobile { get; set; }
        public bool LoginAPI { get; set; }
    }
}