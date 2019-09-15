CREATE TABLE [dbo].[List_MedicalSubClassifications] (
    [pk_SubClassificationID]    INT           IDENTITY (1, 1) NOT NULL,
    [fk_ParentClassificationID] INT           NOT NULL,
    [Classification]            NCHAR (10)    NOT NULL,
    [ShortDescription]          NVARCHAR (30) NOT NULL,
    [FullDescription]           TEXT          NOT NULL,
    CONSTRAINT [PK_List_CODClassifications] PRIMARY KEY CLUSTERED ([pk_SubClassificationID] ASC),
    CONSTRAINT [FK_List_MedicalSubClassifications_List_MedicalClassifications] FOREIGN KEY ([fk_ParentClassificationID]) REFERENCES [dbo].[List_MedicalClassifications] ([pk_ClassificationID])
);

