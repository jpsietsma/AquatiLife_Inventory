CREATE TABLE [dbo].[List_FishAgressionLevels] (
    [pk_AgressionLevelID] INT           IDENTITY (1, 1) NOT NULL,
    [AgressionLevel]      NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_List_FishAgressionLevels] PRIMARY KEY CLUSTERED ([pk_AgressionLevelID] ASC)
);

