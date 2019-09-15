CREATE TABLE [dbo].[UserFishInventory] (
    [pk_FishID]         INT NOT NULL,
    [fk_UserID]         INT NULL,
    [fk_UserFishID]     INT NOT NULL,
    [fk_UserPurchaseID] INT NULL,
    [fk_FishType]       INT NULL,
    [fk_UserTank]       INT CONSTRAINT [DF_UserFishInventory_fk_UserTank] DEFAULT ((10)) NULL,
    CONSTRAINT [PK_UserFishInventory] PRIMARY KEY CLUSTERED ([pk_FishID] ASC),
    CONSTRAINT [FK_UserFishInventory_FishTypes] FOREIGN KEY ([fk_FishType]) REFERENCES [dbo].[FishTypes] ([pk_FishTypeID]),
    CONSTRAINT [FK_UserFishInventory_UserFish] FOREIGN KEY ([fk_UserFishID]) REFERENCES [dbo].[UserFish] ([pk_UserFishID]) ON DELETE CASCADE,
    CONSTRAINT [FK_UserFishInventory_Users] FOREIGN KEY ([fk_UserID]) REFERENCES [dbo].[Users] ([pk_UserID]),
    CONSTRAINT [FK_UserFishInventory_UserTanks] FOREIGN KEY ([fk_UserTank]) REFERENCES [dbo].[UserTanks] ([pk_UserTankID]) ON DELETE SET DEFAULT,
    CONSTRAINT [IX_UserFishInventory] UNIQUE NONCLUSTERED ([fk_UserFishID] ASC)
);

