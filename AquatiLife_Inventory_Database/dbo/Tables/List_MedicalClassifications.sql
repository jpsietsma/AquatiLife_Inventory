CREATE TABLE [dbo].[List_MedicalClassifications] (
    [pk_ClassificationID] INT           IDENTITY (1, 1) NOT NULL,
    [Classification]      NVARCHAR (50) NOT NULL,
    [Description]         TEXT          NOT NULL,
    CONSTRAINT [PK_List_MedicalClassifications] PRIMARY KEY CLUSTERED ([pk_ClassificationID] ASC)
);

