CREATE TABLE [dbo].[UserTankTests] (
    [pk_TestID]    INT           IDENTITY (1, 1) NOT NULL,
    [TestDate]     DATETIME2 (7) NULL,
    [fk_UserTank]  INT           NOT NULL,
    [fk_TestType]  INT           NOT NULL,
    [NitriteLevel] FLOAT (53)    NULL,
    [NitrateLevel] FLOAT (53)    NULL,
    [gHLevel]      FLOAT (53)    NULL,
    [cHLevel]      FLOAT (53)    NULL,
    [pHLevel]      FLOAT (53)    NULL,
    [ActionsTaken] TEXT          NULL,
    CONSTRAINT [PK_UserTankTests] PRIMARY KEY CLUSTERED ([pk_TestID] ASC),
    CONSTRAINT [FK_UserTankTests_List_TankTestTypes] FOREIGN KEY ([fk_TestType]) REFERENCES [dbo].[List_TankTestTypes] ([pk_TestTypeID]),
    CONSTRAINT [FK_UserTankTests_UserTanks] FOREIGN KEY ([fk_UserTank]) REFERENCES [dbo].[UserTanks] ([pk_UserTankID]) ON DELETE CASCADE
);

