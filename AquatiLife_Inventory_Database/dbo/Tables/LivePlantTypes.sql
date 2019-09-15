CREATE TABLE [dbo].[LivePlantTypes] (
    [pk_PlantID]          INT            IDENTITY (1, 1) NOT NULL,
    [PlantName]           NVARCHAR (50)  NOT NULL,
    [fk_LightingLevel]    INT            CONSTRAINT [DF_LivePlantTypes_fk_LightingLevel] DEFAULT ((1)) NOT NULL,
    [NeedsFertilizer]     BIT            CONSTRAINT [DF_LivePlantTypes_NeedsFertilizer] DEFAULT ((0)) NOT NULL,
    [CanFloat]            BIT            CONSTRAINT [DF_LivePlantTypes_CanFloat] DEFAULT ((0)) NOT NULL,
    [PlantMinTemp]        INT            CONSTRAINT [DF_LivePlantTypes_PlantMinTemp] DEFAULT ((70)) NOT NULL,
    [PlantMaxTemp]        INT            CONSTRAINT [DF_LivePlantTypes_PlantMaxTemp] DEFAULT ((90)) NOT NULL,
    [PlantIdealTemp]      INT            NULL,
    [PlantMaxHeight]      FLOAT (53)     NULL,
    [fk_PlantSizeClass]   INT            CONSTRAINT [DF_LivePlantTypes_fk_PlantSizeClass] DEFAULT ((1)) NOT NULL,
    [fk_PurchaseCategory] INT            CONSTRAINT [DF_LivePlantTypes_fk_PurchaseCategory] DEFAULT ((2)) NOT NULL,
    [PlantImage]          NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_LivePlantTypes] PRIMARY KEY CLUSTERED ([pk_PlantID] ASC),
    CONSTRAINT [FK_LivePlantTypes_List_PlantSizeClasses] FOREIGN KEY ([fk_PlantSizeClass]) REFERENCES [dbo].[List_PlantSizeClasses] ([pk_SizeClassID]),
    CONSTRAINT [FK_LivePlantTypes_List_TankLightingLevels] FOREIGN KEY ([fk_LightingLevel]) REFERENCES [dbo].[List_TankLightingLevels] ([pk_LightingLevelID])
);

