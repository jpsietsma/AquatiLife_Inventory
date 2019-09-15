CREATE TABLE [dbo].[List_LivePlantDiseases] (
    [pk_PlantDiseaseID]     INT            IDENTITY (1, 1) NOT NULL,
    [DiseaseName]           NVARCHAR (100) CONSTRAINT [DF_List_LivePlantDiseases_DiseaseName] DEFAULT (N'- no name given -') NOT NULL,
    [DiseaseDescription]    TEXT           CONSTRAINT [DF_List_LivePlantDiseases_DiseaseDescription] DEFAULT ('- no description -') NOT NULL,
    [DiseasePhoto]          NVARCHAR (255) NULL,
    [DiseaseCause]          TEXT           CONSTRAINT [DF_List_LivePlantDiseases_DiseaseCause] DEFAULT ('-unknown cause-') NOT NULL,
    [DiseaseControlMeasure] TEXT           CONSTRAINT [DF_List_LivePlantDiseases_DiseaseControlMeasure] DEFAULT ('- no prescribed control measure -') NOT NULL,
    [fk_AffectedPlants]     INT            NULL,
    CONSTRAINT [PK_List_LivePlantDiseases] PRIMARY KEY CLUSTERED ([pk_PlantDiseaseID] ASC)
);

