CREATE TABLE [dbo].[Stores] (
    [pk_StoreID]              INT           IDENTITY (1, 1) NOT NULL,
    [StoreName]               NVARCHAR (50) NOT NULL,
    [fk_ContactInfo]          INT           NULL,
    [fk_StoreWeeklySchedule]  INT           NULL,
    [fk_StoreHolidaySchedule] INT           NULL,
    [CanOrderOnline]          NVARCHAR (1)  CONSTRAINT [DF_PurchaseLocations_CanOrderOnline] DEFAULT (N'N') NOT NULL,
    CONSTRAINT [PK_PurchaseLocations] PRIMARY KEY CLUSTERED ([pk_StoreID] ASC),
    CONSTRAINT [FK_Stores_StoreHolidaySchedules] FOREIGN KEY ([fk_StoreHolidaySchedule]) REFERENCES [dbo].[StoreHolidaySchedules] ([pk_StoreHolidayScheduleID]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Stores_StoreWeeklySchedules] FOREIGN KEY ([fk_StoreWeeklySchedule]) REFERENCES [dbo].[StoreWeeklySchedules] ([pk_WeeklyScheduleID]) ON DELETE CASCADE ON UPDATE CASCADE
);

