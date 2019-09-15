CREATE TABLE [dbo].[UserActionLogs] (
    [pk_ActionID]       INT IDENTITY (1, 1) NOT NULL,
    [fk_UserID]         INT NOT NULL,
    [fk_UserActionType] INT NOT NULL,
    CONSTRAINT [PK_UserActionLogs] PRIMARY KEY CLUSTERED ([pk_ActionID] ASC),
    CONSTRAINT [FK_UserActionLogs_List_ActionTypes] FOREIGN KEY ([fk_UserActionType]) REFERENCES [dbo].[List_ActionTypes] ([pk_ActionTypeID]),
    CONSTRAINT [FK_UserActionLogs_Users] FOREIGN KEY ([fk_UserID]) REFERENCES [dbo].[Users] ([pk_UserID])
);

