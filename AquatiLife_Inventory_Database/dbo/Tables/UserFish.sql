CREATE TABLE [dbo].[UserFish] (
    [pk_UserFishID]         INT            IDENTITY (1, 1) NOT NULL,
    [IsAlive]               INT            CONSTRAINT [DF_UserFish_IsAlive] DEFAULT ((1)) NOT NULL,
    [FishNotes]             TEXT           NULL,
    [SizeLength]            FLOAT (53)     NULL,
    [FriendlyName]          NVARCHAR (100) NULL,
    [Color]                 NVARCHAR (100) CONSTRAINT [DF_UserFish_Color] DEFAULT (N'Unknown') NULL,
    [fk_fishColor]          INT            CONSTRAINT [DF_UserFish_fk_fishColor] DEFAULT ((16)) NULL,
    [fk_fishColorSecondary] INT            NULL,
    [fk_fishSex]            INT            CONSTRAINT [DF_UserFish_fk_fishSex] DEFAULT ((4)) NULL,
    [LastTankMove]          DATETIME       CONSTRAINT [DF_UserFish_LastTankMove] DEFAULT ('2019-01-01 12:00:00.000') NULL,
    CONSTRAINT [PK_UserFish] PRIMARY KEY CLUSTERED ([pk_UserFishID] ASC),
    CONSTRAINT [FK_UserFish_List_FishColors] FOREIGN KEY ([fk_fishColor]) REFERENCES [dbo].[List_FishColors] ([pk_colorID]) ON DELETE SET DEFAULT,
    CONSTRAINT [FK_UserFish_List_FishColorsSecondary] FOREIGN KEY ([fk_fishColorSecondary]) REFERENCES [dbo].[List_FishColors] ([pk_colorID]),
    CONSTRAINT [FK_UserFish_List_FishSexes] FOREIGN KEY ([fk_fishSex]) REFERENCES [dbo].[List_FishSexes] ([pk_SexID]) ON DELETE SET DEFAULT ON UPDATE SET DEFAULT
);

