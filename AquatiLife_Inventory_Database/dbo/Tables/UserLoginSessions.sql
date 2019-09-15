CREATE TABLE [dbo].[UserLoginSessions] (
    [pk_SessionID]      NVARCHAR (255) NOT NULL,
    [fk_UserID]         INT            NOT NULL,
    [SessionBegin]      NVARCHAR (50)  NOT NULL,
    [SessionPermission] NVARCHAR (50)  NOT NULL,
    [SessionEnd]        NVARCHAR (50)  NULL,
    [IsActive]          BIT            CONSTRAINT [DF__UserLogin__IsAct__2FCF1A8A] DEFAULT ((1)) NOT NULL,
    [SessionDuration]   NVARCHAR (200) NULL,
    CONSTRAINT [PK__UserLogi__644032B13B98FA19] PRIMARY KEY CLUSTERED ([pk_SessionID] ASC),
    CONSTRAINT [FK_UserLoginSessions_Users] FOREIGN KEY ([fk_UserID]) REFERENCES [dbo].[Users] ([pk_UserID])
);

