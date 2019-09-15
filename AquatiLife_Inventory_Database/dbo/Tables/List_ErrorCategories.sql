CREATE TABLE [dbo].[List_ErrorCategories] (
    [pk_CategoryID] INT           IDENTITY (1, 1) NOT NULL,
    [CategoryName]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_List_ErrorCategories] PRIMARY KEY CLUSTERED ([pk_CategoryID] ASC)
);

