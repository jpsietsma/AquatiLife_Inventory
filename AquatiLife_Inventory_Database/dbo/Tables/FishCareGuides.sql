CREATE TABLE [dbo].[FishCareGuides] (
    [pk_CareGuideID] INT            IDENTITY (1, 1) NOT NULL,
    [DocumentPath]   NVARCHAR (255) NOT NULL,
    [fk_AnimalType]  INT            NULL,
    [fk_FishType]    INT            NULL,
    CONSTRAINT [PK_FishCareGuides] PRIMARY KEY CLUSTERED ([pk_CareGuideID] ASC)
);

