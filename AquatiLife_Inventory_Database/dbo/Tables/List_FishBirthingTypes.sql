CREATE TABLE [dbo].[List_FishBirthingTypes] (
    [pk_BirthTypeID] INT           IDENTITY (1, 1) NOT NULL,
    [BirthingType]   NVARCHAR (50) NULL,
    [SpecialNotes]   TEXT          NULL,
    CONSTRAINT [PK_List_FishBirthingTypes] PRIMARY KEY CLUSTERED ([pk_BirthTypeID] ASC)
);

