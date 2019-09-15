CREATE TABLE [dbo].[List_FishSicknessTypes] (
    [pk_FishSicknesses] INT            IDENTITY (1, 1) NOT NULL,
    [SicknessName]      NVARCHAR (100) NOT NULL,
    [IsFatal]           NVARCHAR (1)   CONSTRAINT [DF_List_FishSicknessTypes_IsFatal] DEFAULT (N'N') NOT NULL,
    [Symptoms]          TEXT           NULL,
    [CareNeeded]        TEXT           NULL,
    [RecoveryTime]      TEXT           NULL,
    [fk_AffectedTypes]  INT            CONSTRAINT [DF_List_FishSicknessTypes_fk_AffectedTypes] DEFAULT ((0)) NULL,
    CONSTRAINT [PK_List_FishSicknessTypes] PRIMARY KEY CLUSTERED ([pk_FishSicknesses] ASC),
    CONSTRAINT [FK_List_FishSicknessTypes_FishTypeDiseaseAffection] FOREIGN KEY ([fk_AffectedTypes]) REFERENCES [dbo].[FishTypeDiseaseAffection] ([pk_AffectedTypesID])
);

