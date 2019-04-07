﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DatabaseEntities : DbContext
    {
        public DatabaseEntities()
            : base("name=DatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C_List_TankTypes> C_List_TankTypes { get; set; }
        public virtual DbSet<AnimalTypes> AnimalTypes { get; set; }
        public virtual DbSet<Business_Customers> Business_Customers { get; set; }
        public virtual DbSet<Business_List_VendorTypes> Business_List_VendorTypes { get; set; }
        public virtual DbSet<ContactInfo> ContactInfo { get; set; }
        public virtual DbSet<FishCareGuides> FishCareGuides { get; set; }
        public virtual DbSet<FishTypeDiseaseAffection> FishTypeDiseaseAffection { get; set; }
        public virtual DbSet<FishTypes> FishTypes { get; set; }
        public virtual DbSet<List_ErrorSeverityLevels> List_ErrorSeverityLevels { get; set; }
        public virtual DbSet<List_ErrorTypes> List_ErrorTypes { get; set; }
        public virtual DbSet<List_FishSicknessTypes> List_FishSicknessTypes { get; set; }
        public virtual DbSet<List_PurchaseTypes> List_PurchaseTypes { get; set; }
        public virtual DbSet<List_WaterTypes> List_WaterTypes { get; set; }
        public virtual DbSet<MedicalRecords> MedicalRecords { get; set; }
        public virtual DbSet<Purchases> Purchases { get; set; }
        public virtual DbSet<StoreHolidaySchedules> StoreHolidaySchedules { get; set; }
        public virtual DbSet<Stores> Stores { get; set; }
        public virtual DbSet<StoreWeeklySchedules> StoreWeeklySchedules { get; set; }
        public virtual DbSet<UserFish> UserFish { get; set; }
        public virtual DbSet<UserLoginSessions> UserLoginSessions { get; set; }
        public virtual DbSet<UserProfiles> UserProfiles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserTanks> UserTanks { get; set; }
        public virtual DbSet<Business_Vendors> Business_Vendors { get; set; }
        public virtual DbSet<Errorlogs> Errorlogs { get; set; }
        public virtual DbSet<Get_AllFishTypeOverview> Get_AllFishTypeOverview { get; set; }
    
        public virtual ObjectResult<GetActiveLoginSessions_Result> GetActiveLoginSessions(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetActiveLoginSessions_Result>("GetActiveLoginSessions", userIDParameter);
        }
    }
}
