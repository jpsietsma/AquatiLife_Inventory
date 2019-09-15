CREATE TABLE [dbo].[UserTankTemperatureLogs] (
    [pk_TempLogID] INT        IDENTITY (1, 1) NOT NULL,
    [fk_UserTank]  INT        NOT NULL,
    [Temperature]  FLOAT (53) NOT NULL,
    [Date]         DATETIME   NOT NULL,
    [Notes]        TEXT       NULL,
    CONSTRAINT [PK_TankTemperatureLogs] PRIMARY KEY CLUSTERED ([pk_TempLogID] ASC),
    CONSTRAINT [FK_UserTankTemperatureLogs_UserTanks] FOREIGN KEY ([fk_UserTank]) REFERENCES [dbo].[UserTanks] ([pk_UserTankID]) ON DELETE CASCADE
);

