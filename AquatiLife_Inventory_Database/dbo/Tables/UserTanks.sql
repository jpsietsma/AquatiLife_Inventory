CREATE TABLE [dbo].[UserTanks] (
    [pk_UserTankID]     INT            IDENTITY (1, 1) NOT NULL,
    [fk_TankOwner]      INT            CONSTRAINT [DF_UserTanks_fk_TankOwner] DEFAULT ((5)) NOT NULL,
    [TankSize]          INT            CONSTRAINT [DF__UserTanks__TankS__4F7CD00D] DEFAULT ((99999)) NOT NULL,
    [TankHeight]        NVARCHAR (10)  CONSTRAINT [DF__UserTanks__TankH__5070F446] DEFAULT ((999.99)) NOT NULL,
    [TankWidth]         NVARCHAR (10)  CONSTRAINT [DF__UserTanks__TankW__5165187F] DEFAULT ((999.99)) NOT NULL,
    [fk_TankWaterType]  INT            CONSTRAINT [DF__UserTanks__TankW__52593CB8] DEFAULT ((1)) NOT NULL,
    [fk_TankType]       INT            CONSTRAINT [DF_UserTanks_fk_TankType] DEFAULT ((27)) NOT NULL,
    [TankDisplayName]   NVARCHAR (200) CONSTRAINT [DF_UserTanks_TankDisplayName] DEFAULT (N'-none-') NOT NULL,
    [IsActiveTank]      BIT            CONSTRAINT [DF_UserTanks_IsActiveTank] DEFAULT ((1)) NOT NULL,
    [fk_UserPurchaseID] INT            NULL,
    CONSTRAINT [PK__UserTank__A92E8C8E4B73D28C] PRIMARY KEY CLUSTERED ([pk_UserTankID] ASC),
    CONSTRAINT [FK_UserTanks_List_TankTypes] FOREIGN KEY ([fk_TankType]) REFERENCES [dbo].[List_TankTypes] ([pk_TankTypeID]) ON DELETE SET DEFAULT,
    CONSTRAINT [FK_UserTanks_Users] FOREIGN KEY ([fk_TankOwner]) REFERENCES [dbo].[Users] ([pk_UserID]) ON DELETE SET DEFAULT,
    CONSTRAINT [FK_UserTanks_WaterType] FOREIGN KEY ([fk_TankWaterType]) REFERENCES [dbo].[List_WaterTypes] ([pk_WaterTypeID])
);

