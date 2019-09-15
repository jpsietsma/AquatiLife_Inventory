CREATE TABLE [dbo].[List_FishSexes] (
    [pk_SexID] INT           IDENTITY (1, 1) NOT NULL,
    [FishSex]  NVARCHAR (25) NULL,
    CONSTRAINT [PK_List_FishSexes] PRIMARY KEY CLUSTERED ([pk_SexID] ASC)
);

