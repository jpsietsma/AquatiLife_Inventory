CREATE TABLE [dbo].[List_FishTerritorialLevels] (
    [pk_TerritorialLevelID] INT            IDENTITY (1, 1) NOT NULL,
    [TerritorialLevel]      NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_List_FishTerritorialLevels] PRIMARY KEY CLUSTERED ([pk_TerritorialLevelID] ASC)
);

