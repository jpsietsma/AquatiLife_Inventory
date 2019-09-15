CREATE TABLE [dbo].[List_FishColors] (
    [pk_colorID] INT            IDENTITY (1, 1) NOT NULL,
    [ColorName]  NVARCHAR (150) NULL,
    CONSTRAINT [PK_List_FishColors] PRIMARY KEY CLUSTERED ([pk_colorID] ASC)
);

