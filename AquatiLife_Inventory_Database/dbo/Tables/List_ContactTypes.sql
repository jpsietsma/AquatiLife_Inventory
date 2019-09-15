CREATE TABLE [dbo].[List_ContactTypes] (
    [pk_ContactType]         INT           IDENTITY (1, 1) NOT NULL,
    [ContactTypeDisplayName] NVARCHAR (25) NULL,
    CONSTRAINT [PK_List_ContactTypes] PRIMARY KEY CLUSTERED ([pk_ContactType] ASC)
);

