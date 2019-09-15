CREATE TABLE [dbo].[List_TankTypes] (
    [pk_TankTypeID]   INT            IDENTITY (1, 1) NOT NULL,
    [TypeName]        NVARCHAR (255) NOT NULL,
    [TankSpecialTags] NVARCHAR (255) NULL,
    [TankShape]       NVARCHAR (50)  CONSTRAINT [DF__FishTankT__TankS__4F47C5E3] DEFAULT ('Rectangle') NOT NULL,
    CONSTRAINT [PK__FishTank__5A82FE9DE30EAE5D] PRIMARY KEY CLUSTERED ([pk_TankTypeID] ASC)
);

