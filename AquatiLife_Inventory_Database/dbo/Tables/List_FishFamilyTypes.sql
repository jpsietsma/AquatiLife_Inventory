CREATE TABLE [dbo].[List_FishFamilyTypes] (
    [pk_FamilyID]    INT            IDENTITY (1, 1) NOT NULL,
    [FishFamilyName] NVARCHAR (MAX) NOT NULL,
    [fk_WaterType]   INT            NOT NULL,
    [fk_AnimalType]  INT            CONSTRAINT [DF_List_FishFamilyTypes_fk_AnimalType] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_List_FishFamilyTypes] PRIMARY KEY CLUSTERED ([pk_FamilyID] ASC),
    CONSTRAINT [FK_List_FishFamilies] FOREIGN KEY ([fk_WaterType]) REFERENCES [dbo].[List_WaterTypes] ([pk_WaterTypeID]),
    CONSTRAINT [FK_List_FishFamilyTypes_List_AnimalTypes] FOREIGN KEY ([fk_AnimalType]) REFERENCES [dbo].[List_AnimalTypes] ([pk_AnimalTypeID])
);

