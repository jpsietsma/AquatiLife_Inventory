CREATE TABLE [dbo].[List_PlantSizeClasses] (
    [pk_SizeClassID]     INT           IDENTITY (1, 1) NOT NULL,
    [PlantSizeClassName] NVARCHAR (20) NOT NULL,
    CONSTRAINT [PK_List_PlantSizeClasses] PRIMARY KEY CLUSTERED ([pk_SizeClassID] ASC)
);

