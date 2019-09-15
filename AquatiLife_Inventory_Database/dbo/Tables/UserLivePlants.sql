CREATE TABLE [dbo].[UserLivePlants] (
    [pk_UserPlantID] INT IDENTITY (1, 1) NOT NULL,
    [fk_UserID]      INT NOT NULL,
    [fk_TankID]      INT CONSTRAINT [DF_UserLivePlants_fk_TankID] DEFAULT ((10)) NOT NULL,
    [fk_PurchaseID]  INT NULL,
    [fk_PlantType]   INT NOT NULL,
    CONSTRAINT [PK_UserLivePlants] PRIMARY KEY CLUSTERED ([pk_UserPlantID] ASC),
    CONSTRAINT [FK_UserLivePlants_LivePlantTypes] FOREIGN KEY ([fk_PlantType]) REFERENCES [dbo].[LivePlantTypes] ([pk_PlantID]),
    CONSTRAINT [FK_UserLivePlants_Users] FOREIGN KEY ([fk_UserID]) REFERENCES [dbo].[Users] ([pk_UserID]),
    CONSTRAINT [FK_UserLivePlants_UserTanks] FOREIGN KEY ([fk_TankID]) REFERENCES [dbo].[UserTanks] ([pk_UserTankID]) ON DELETE SET DEFAULT
);

