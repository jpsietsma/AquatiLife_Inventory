CREATE TABLE [dbo].[List_TankLightingLevels] (
    [pk_LightingLevelID] INT           IDENTITY (1, 1) NOT NULL,
    [LightingLevelName]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_List_TankLightingLevels] PRIMARY KEY CLUSTERED ([pk_LightingLevelID] ASC)
);

