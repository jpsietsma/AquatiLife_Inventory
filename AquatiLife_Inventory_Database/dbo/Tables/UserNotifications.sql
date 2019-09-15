CREATE TABLE [dbo].[UserNotifications] (
    [pk_NotificationID]     INT IDENTITY (1, 1) NOT NULL,
    [fk_ErrorTypeID]        INT NOT NULL,
    [fk_UserID]             INT NOT NULL,
    [fk_ErrorSeverityLevel] INT NOT NULL,
    CONSTRAINT [PK_UserNotifications] PRIMARY KEY CLUSTERED ([pk_NotificationID] ASC),
    CONSTRAINT [FK_UserNotifications_List_ErrorSeverityLevels] FOREIGN KEY ([fk_ErrorSeverityLevel]) REFERENCES [dbo].[List_ErrorSeverityLevels] ([pk_SeverityID]),
    CONSTRAINT [FK_UserNotifications_List_ErrorTypes] FOREIGN KEY ([fk_ErrorTypeID]) REFERENCES [dbo].[List_ErrorTypes] ([pk_ErrorTypeID]),
    CONSTRAINT [FK_UserNotifications_Users] FOREIGN KEY ([fk_UserID]) REFERENCES [dbo].[Users] ([pk_UserID])
);

