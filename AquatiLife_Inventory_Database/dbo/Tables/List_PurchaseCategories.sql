CREATE TABLE [dbo].[List_PurchaseCategories] (
    [pk_PurchaseTypeID]       INT           IDENTITY (1, 1) NOT NULL,
    [PurchaseTypeDescription] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_PurchaseTypes] PRIMARY KEY CLUSTERED ([pk_PurchaseTypeID] ASC)
);

