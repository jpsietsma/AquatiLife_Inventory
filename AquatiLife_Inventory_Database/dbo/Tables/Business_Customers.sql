CREATE TABLE [dbo].[Business_Customers] (
    [pk_CustomerID]     INT            IDENTITY (1, 1) NOT NULL,
    [CustomerFirstName] NVARCHAR (50)  NOT NULL,
    [CustomerLastName]  NVARCHAR (100) NOT NULL,
    [fk_StoreID]        INT            NULL,
    [fk_UserProfileID]  INT            NULL,
    CONSTRAINT [PK_Business_Customers] PRIMARY KEY CLUSTERED ([pk_CustomerID] ASC),
    CONSTRAINT [FK_Business_Customers_Stores] FOREIGN KEY ([fk_StoreID]) REFERENCES [dbo].[Stores] ([pk_StoreID]),
    CONSTRAINT [FK_Business_Customers_UserProfiles] FOREIGN KEY ([fk_UserProfileID]) REFERENCES [dbo].[UserProfiles] ([pk_ProfileID]) ON DELETE CASCADE ON UPDATE CASCADE
);

