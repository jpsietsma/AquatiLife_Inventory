CREATE TABLE [dbo].[UserAuthenticationRoles] (
    [pk_PermissionID] INT IDENTITY (1, 1) NOT NULL,
    [fk_UserID]       INT NOT NULL,
    [IsUser]          BIT CONSTRAINT [DF_UserAuthenticationRoles_IsUser] DEFAULT ((1)) NOT NULL,
    [IsModerator]     BIT CONSTRAINT [DF_UserAuthenticationRoles_IsModerator] DEFAULT ((0)) NOT NULL,
    [isAdmin]         BIT CONSTRAINT [DF_UserAuthenticationRoles_isAdmin] DEFAULT ((0)) NOT NULL,
    [isSuperAdmin]    BIT CONSTRAINT [DF_UserAuthenticationRoles_isSuperAdmin] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_UserAuthenticationRoles] PRIMARY KEY CLUSTERED ([pk_PermissionID] ASC)
);

