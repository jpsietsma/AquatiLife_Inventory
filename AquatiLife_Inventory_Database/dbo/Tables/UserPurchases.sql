CREATE TABLE [dbo].[UserPurchases] (
    [pk_PurchaseID]          INT            IDENTITY (1, 1) NOT NULL,
    [Date]                   NVARCHAR (50)  NULL,
    [Quantity]               INT            NOT NULL,
    [fk_StoreID]             INT            NULL,
    [fk_PurchaseCategory]    INT            NULL,
    [Cost]                   DECIMAL (6, 2) NOT NULL,
    [fk_UserID]              INT            NOT NULL,
    [Description]            NVARCHAR (255) CONSTRAINT [DF_UserPurchases_PurchaseDescription] DEFAULT (N'none') NULL,
    [ExtCost]                AS             ([Quantity]*[Cost]),
    [fk_UserFish]            INT            CONSTRAINT [DF_UserPurchases_fk_UserFish] DEFAULT (NULL) NULL,
    [fk_UserSupplyInventory] INT            CONSTRAINT [DF_UserPurchases_fk_UserSupplyInventory] DEFAULT (NULL) NULL,
    [fk_UserTank]            INT            CONSTRAINT [DF_UserPurchases_fk_UserTank] DEFAULT (NULL) NULL,
    [fk_UserPlant]           INT            CONSTRAINT [DF_UserPurchases_fk_UserPlant] DEFAULT (NULL) NULL,
    CONSTRAINT [PK_Purchases] PRIMARY KEY CLUSTERED ([pk_PurchaseID] ASC),
    CONSTRAINT [FK_UserPurchases_PurchaseCategories] FOREIGN KEY ([fk_PurchaseCategory]) REFERENCES [dbo].[List_PurchaseCategories] ([pk_PurchaseTypeID]),
    CONSTRAINT [FK_UserPurchases_Stores] FOREIGN KEY ([fk_StoreID]) REFERENCES [dbo].[Stores] ([pk_StoreID]),
    CONSTRAINT [FK_UserPurchases_UserFish] FOREIGN KEY ([fk_UserFish]) REFERENCES [dbo].[UserFish] ([pk_UserFishID]) ON DELETE SET NULL,
    CONSTRAINT [FK_UserPurchases_UserFishInventory] FOREIGN KEY ([fk_UserFish]) REFERENCES [dbo].[UserFishInventory] ([fk_UserFishID]),
    CONSTRAINT [FK_UserPurchases_UserLivePlants] FOREIGN KEY ([fk_UserPlant]) REFERENCES [dbo].[UserLivePlants] ([pk_UserPlantID]) ON DELETE SET NULL,
    CONSTRAINT [FK_UserPurchases_UserTank] FOREIGN KEY ([fk_UserTank]) REFERENCES [dbo].[UserTanks] ([pk_UserTankID]) ON DELETE SET NULL,
    CONSTRAINT [FK_UserPurchases_UserTankSupplyInventory] FOREIGN KEY ([fk_UserSupplyInventory]) REFERENCES [dbo].[UserTankSupplyInventory] ([pk_SupplyID]) ON DELETE SET NULL
);

