CREATE TABLE [dbo].[UserFishMedicalRecords] (
    [pk_MedRecordID]              INT           IDENTITY (1, 1) NOT NULL,
    [RecordDate]                  DATETIME2 (7) NOT NULL,
    [fk_FishID]                   INT           NOT NULL,
    [Description]                 TEXT          NULL,
    [fk_MedicalClassification]    INT           NULL,
    [fk_MedicalSubClassification] INT           NULL,
    CONSTRAINT [PK_MedicalRecords] PRIMARY KEY CLUSTERED ([pk_MedRecordID] ASC),
    CONSTRAINT [FK_UserFishMedicalRecords_UserFishInventory] FOREIGN KEY ([fk_FishID]) REFERENCES [dbo].[UserFishInventory] ([pk_FishID])
);

