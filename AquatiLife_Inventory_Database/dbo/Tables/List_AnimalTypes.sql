CREATE TABLE [dbo].[List_AnimalTypes] (
    [pk_AnimalTypeID]    INT            IDENTITY (1, 1) NOT NULL,
    [fk_FishCareGuideID] INT            NULL,
    [AnimalTypeName]     NVARCHAR (255) NULL,
    CONSTRAINT [PK_AnimalTypes] PRIMARY KEY CLUSTERED ([pk_AnimalTypeID] ASC),
    CONSTRAINT [FK_AnimalTypes_FishCareGuides] FOREIGN KEY ([fk_FishCareGuideID]) REFERENCES [dbo].[FishCareGuides] ([pk_CareGuideID])
);

