CREATE TABLE [dbo].[List_SupplyCategories] (
    [pk_SupplyCategory] INT            NOT NULL,
    [CategoryName]      NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_List_SupplyCategories] PRIMARY KEY CLUSTERED ([pk_SupplyCategory] ASC)
);

