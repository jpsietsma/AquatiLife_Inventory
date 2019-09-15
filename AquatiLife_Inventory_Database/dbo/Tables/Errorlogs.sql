CREATE TABLE [dbo].[Errorlogs] (
    [pk_errorID]                 INT            IDENTITY (1, 1) NOT NULL,
    [fk_ErrorType]               INT            NOT NULL,
    [ErrorDate]                  DATETIME       NOT NULL,
    [fk_errorUser]               INT            NULL,
    [ErrorTitle]                 NVARCHAR (100) NOT NULL,
    [ErrorDetails]               NVARCHAR (MAX) NOT NULL,
    [ErrorSourceScreen]          NVARCHAR (150) NULL,
    [ErrorSourceAction]          NVARCHAR (150) NULL,
    [ErrorRecommendedResolution] TEXT           NULL,
    CONSTRAINT [FK_Errorlogs_Users] FOREIGN KEY ([fk_errorUser]) REFERENCES [dbo].[Users] ([pk_UserID]) ON DELETE SET NULL ON UPDATE CASCADE
);

