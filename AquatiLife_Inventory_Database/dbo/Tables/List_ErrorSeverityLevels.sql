CREATE TABLE [dbo].[List_ErrorSeverityLevels] (
    [pk_SeverityID]     INT           IDENTITY (1, 1) NOT NULL,
    [SeverityLevelText] NVARCHAR (50) NOT NULL,
    [SeverityLevelNum]  INT           NOT NULL,
    CONSTRAINT [PK_List_ErrorSeverityLevels] PRIMARY KEY CLUSTERED ([pk_SeverityID] ASC)
);

