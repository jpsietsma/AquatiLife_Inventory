CREATE TABLE [dbo].[Users] (
    [pk_UserID]    INT            IDENTITY (1, 1) NOT NULL,
    [UserName]     NVARCHAR (50)  NOT NULL,
    [Password]     NVARCHAR (50)  NOT NULL,
    [EmailAddress] NVARCHAR (100) NULL,
    [UserRole]     NVARCHAR (50)  CONSTRAINT [DF__Users__UserRole__36B12243] DEFAULT (user_name()) NOT NULL,
    [fk_ProfileID] INT            NOT NULL,
    CONSTRAINT [PK__Users__1788CCACDBD79C0E] PRIMARY KEY CLUSTERED ([pk_UserID] ASC),
    CONSTRAINT [FK_Users_UserProfiles] FOREIGN KEY ([fk_ProfileID]) REFERENCES [dbo].[UserProfiles] ([pk_ProfileID])
);

