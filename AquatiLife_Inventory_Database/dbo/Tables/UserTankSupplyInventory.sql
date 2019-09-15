CREATE TABLE [dbo].[UserTankSupplyInventory] (
    [pk_SupplyID]    INT IDENTITY (1, 1) NOT NULL,
    [QuantityOnHand] INT CONSTRAINT [DF_UserTankSupplyInventory_Quantity] DEFAULT ((0)) NOT NULL,
    [fk_PurchaseID]  INT NOT NULL,
    [fk_UserID]      INT NOT NULL,
    [fk_UserTankID]  INT CONSTRAINT [DF_UserTankSupplyInventory_fk_UserTankID] DEFAULT ((10)) NOT NULL,
    [ExpirationDays] INT CONSTRAINT [DF_UserTankSupplyInventory_ExpirationDays] DEFAULT ((30)) NULL,
    CONSTRAINT [PK_UserTankSupplyInventory] PRIMARY KEY CLUSTERED ([pk_SupplyID] ASC),
    CONSTRAINT [FK_UserTankSupplyInventory_Users] FOREIGN KEY ([fk_UserID]) REFERENCES [dbo].[Users] ([pk_UserID]),
    CONSTRAINT [FK_UserTankSupplyInventory_UserTanks] FOREIGN KEY ([fk_UserTankID]) REFERENCES [dbo].[UserTanks] ([pk_UserTankID]) ON DELETE SET DEFAULT
);

