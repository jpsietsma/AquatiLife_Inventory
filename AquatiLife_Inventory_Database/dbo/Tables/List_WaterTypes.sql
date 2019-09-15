CREATE TABLE [dbo].[List_WaterTypes] (
    [pk_WaterTypeID]       INT            IDENTITY (1, 1) NOT NULL,
    [WaterTypeName]        NVARCHAR (50)  NOT NULL,
    [WaterTypeSpecialTags] NVARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([pk_WaterTypeID] ASC)
);

