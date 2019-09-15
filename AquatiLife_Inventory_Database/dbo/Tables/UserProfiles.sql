CREATE TABLE [dbo].[UserProfiles] (
    [pk_ProfileID]       INT IDENTITY (1, 1) NOT NULL,
    [fk_userID]          INT NOT NULL,
    [fk_ContactInfo]     INT NOT NULL,
    [fk_UserPermissions] INT NULL,
    CONSTRAINT [PK_UserProfiles] PRIMARY KEY CLUSTERED ([pk_ProfileID] ASC),
    CONSTRAINT [FK_UserProfiles_ContactInfo] FOREIGN KEY ([fk_ContactInfo]) REFERENCES [dbo].[ContactInfo] ([pk_ContactID]),
    CONSTRAINT [FK_UserProfiles_UserPermissions] FOREIGN KEY ([fk_UserPermissions]) REFERENCES [dbo].[UserPermissions] ([pk_PermissionID])
);

