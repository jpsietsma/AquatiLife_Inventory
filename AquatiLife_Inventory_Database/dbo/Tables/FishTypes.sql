CREATE TABLE [dbo].[FishTypes] (
    [pk_FishTypeID]             INT            IDENTITY (1, 1) NOT NULL,
    [TypeName]                  NVARCHAR (50)  NOT NULL,
    [fk_FishFamily]             INT            CONSTRAINT [DF_FishTypes_FishFamilyName] DEFAULT ((1)) NOT NULL,
    [TankPopulationEncumbrance] FLOAT (53)     CONSTRAINT [DF_FishTypes_TankPopulationEncumbrance] DEFAULT ((1)) NOT NULL,
    [FishTypeImagePath]         NVARCHAR (100) CONSTRAINT [DF_FishTypes_FishTypeImagePath] DEFAULT (N'/images/Fish/default.png') NULL,
    [fk_FishFeederType]         INT            NOT NULL,
    [fk_BirthingType]           INT            CONSTRAINT [DF_FishTypes_fk_BirthingType] DEFAULT ((6)) NOT NULL,
    [FishMinTankSize]           INT            NULL,
    [fk_FishAgressionLevel]     INT            CONSTRAINT [DF_FishTypes_fk_FishAgressionLevel] DEFAULT ((6)) NOT NULL,
    [fk_FishTerritorialLevel]   INT            CONSTRAINT [DF_FishTypes_fk_FishTerritorialLevel] DEFAULT ((1)) NOT NULL,
    [fk_WaterType]              INT            CONSTRAINT [DF_FishTypes_fk_FishWaterType] DEFAULT ((1)) NOT NULL,
    [fk_CareGuideID]            INT            NULL,
    CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([pk_FishTypeID] ASC),
    CONSTRAINT [FK_FishTypes_FishAgressionLevels] FOREIGN KEY ([fk_FishAgressionLevel]) REFERENCES [dbo].[List_FishAgressionLevels] ([pk_AgressionLevelID]),
    CONSTRAINT [FK_FishTypes_FishCareGuides] FOREIGN KEY ([fk_CareGuideID]) REFERENCES [dbo].[FishCareGuides] ([pk_CareGuideID]),
    CONSTRAINT [FK_FishTypes_FishFamilyTypes] FOREIGN KEY ([fk_FishFamily]) REFERENCES [dbo].[List_FishFamilyTypes] ([pk_FamilyID]),
    CONSTRAINT [FK_FishTypes_FishFeederTypes] FOREIGN KEY ([fk_FishFeederType]) REFERENCES [dbo].[List_FishFeedingTypes] ([pk_FeedingTypeID]),
    CONSTRAINT [FK_FishTypes_FishTerritorialLevels] FOREIGN KEY ([fk_FishTerritorialLevel]) REFERENCES [dbo].[List_FishTerritorialLevels] ([pk_TerritorialLevelID]),
    CONSTRAINT [FK_FishTypes_List_FishFamilyTypes] FOREIGN KEY ([fk_FishFamily]) REFERENCES [dbo].[List_FishFamilyTypes] ([pk_FamilyID]),
    CONSTRAINT [FK_FishTypes_WaterTypes] FOREIGN KEY ([fk_WaterType]) REFERENCES [dbo].[List_WaterTypes] ([pk_WaterTypeID])
);

