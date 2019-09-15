CREATE TABLE [dbo].[FishTypeDiseaseAffection] (
    [pk_AffectedTypesID] INT IDENTITY (1, 1) NOT NULL,
    [fk_SicknessID]      INT NOT NULL,
    [fk_FishTypeID]      INT NOT NULL,
    CONSTRAINT [PK_FishTypeDiseaseAffection] PRIMARY KEY CLUSTERED ([pk_AffectedTypesID] ASC),
    CONSTRAINT [FK_FishTypeDiseaseAffection_FishTypes] FOREIGN KEY ([fk_FishTypeID]) REFERENCES [dbo].[FishTypes] ([pk_FishTypeID])
);

