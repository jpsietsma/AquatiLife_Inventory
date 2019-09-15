CREATE TABLE [dbo].[StoreWeeklySchedules] (
    [pk_WeeklyScheduleID] INT          IDENTITY (1, 1) NOT NULL,
    [IsOpenMonday]        NVARCHAR (1) NOT NULL,
    [IsOpenTuesday]       NVARCHAR (1) NOT NULL,
    [IsOpenWednesday]     NVARCHAR (1) NOT NULL,
    [IsOpenThursday]      NVARCHAR (1) NOT NULL,
    [IsOpenFriday]        NVARCHAR (1) NOT NULL,
    [IsOpenSaturday]      NVARCHAR (1) NOT NULL,
    [IsOpenSunday]        NVARCHAR (1) NOT NULL,
    [MondayHours]         DATETIME     NULL,
    [TuesdayHours]        DATETIME     NULL,
    [WednesdayHours]      DATETIME     NULL,
    [ThursdayHours]       DATETIME     NULL,
    [FridayHours]         DATETIME     NULL,
    [SaturdayHours]       DATETIME     NULL,
    [SundayHours]         DATETIME     NULL,
    CONSTRAINT [PK_PurchaseLocationsSchedule] PRIMARY KEY CLUSTERED ([pk_WeeklyScheduleID] ASC)
);

