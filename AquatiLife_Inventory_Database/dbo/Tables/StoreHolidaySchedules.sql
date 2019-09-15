CREATE TABLE [dbo].[StoreHolidaySchedules] (
    [pk_StoreHolidayScheduleID] INT          NOT NULL,
    [NewYearsEve]               NVARCHAR (1) CONSTRAINT [DF_StoreHolidaySchedules_NewYearsEve] DEFAULT (N'Y') NOT NULL,
    [NewYearsDay]               NVARCHAR (1) CONSTRAINT [DF_StoreHolidaySchedules_NewYearsDay] DEFAULT (N'Y') NOT NULL,
    [ChristmasEve]              NVARCHAR (1) CONSTRAINT [DF_StoreHolidaySchedules_ChristmasEve] DEFAULT (N'Y') NOT NULL,
    [ChristmasDay]              NVARCHAR (1) CONSTRAINT [DF_StoreHolidaySchedules_ChristmasDay] DEFAULT (N'Y') NOT NULL,
    [ValentinesDay]             NVARCHAR (1) CONSTRAINT [DF_StoreHolidaySchedules_ValentinesDay] DEFAULT (N'Y') NOT NULL,
    [LaborDay]                  NVARCHAR (1) CONSTRAINT [DF_StoreHolidaySchedules_LaborDay] DEFAULT (N'Y') NOT NULL,
    [MemorialDay]               NVARCHAR (1) CONSTRAINT [DF_StoreHolidaySchedules_MemorialDay] DEFAULT (N'Y') NOT NULL,
    [IndependenceDay]           NVARCHAR (1) CONSTRAINT [DF_StoreHolidaySchedules_IndependenceDay] DEFAULT (N'Y') NOT NULL,
    [VeteransDay]               NVARCHAR (1) CONSTRAINT [DF_StoreHolidaySchedules_VeteransDay] DEFAULT (N'Y') NOT NULL,
    [PresidentsDay]             NVARCHAR (1) CONSTRAINT [DF_StoreHolidaySchedules_PresidentsDay] DEFAULT (N'Y') NOT NULL,
    [Halloween]                 NVARCHAR (1) CONSTRAINT [DF_StoreHolidaySchedules_Halloween] DEFAULT (N'Y') NOT NULL,
    [Thanksgiving]              NVARCHAR (1) CONSTRAINT [DF_StoreHolidaySchedules_Thanksgiving] DEFAULT (N'Y') NOT NULL,
    [BlackFriday]               NVARCHAR (1) CONSTRAINT [DF_StoreHolidaySchedules_BlackFriday] DEFAULT (N'Y') NOT NULL,
    [ColumbusDay]               NVARCHAR (1) CONSTRAINT [DF_StoreHolidaySchedules_ColumbusDay] DEFAULT (N'Y') NOT NULL,
    [MartinLutherKingJrDay]     NVARCHAR (1) CONSTRAINT [DF_StoreHolidaySchedules_MartinLutherKingJrDay] DEFAULT (N'Y') NOT NULL,
    CONSTRAINT [PK_StoreHolidaySchedules] PRIMARY KEY CLUSTERED ([pk_StoreHolidayScheduleID] ASC)
);

