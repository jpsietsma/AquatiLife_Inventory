CREATE TABLE [dbo].[ContactInfo] (
    [pk_ContactID]   INT            IDENTITY (1, 1) NOT NULL,
    [fk_StoreID]     INT            NULL,
    [FirstName]      NVARCHAR (25)  NULL,
    [LastName]       NVARCHAR (50)  NULL,
    [StreetAddress]  NVARCHAR (100) NULL,
    [City]           NVARCHAR (100) NOT NULL,
    [State]          NVARCHAR (50)  NOT NULL,
    [ZipCode]        NVARCHAR (5)   NULL,
    [PhoneNumber]    NVARCHAR (20)  NULL,
    [AltEmail]       NVARCHAR (150) NULL,
    [Website]        NVARCHAR (255) NULL,
    [fk_UserID]      INT            NULL,
    [fk_ContactType] INT            CONSTRAINT [DF_ContactInfo_fk_ContractType] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED ([pk_ContactID] ASC),
    CONSTRAINT [FK_ContactInfo_ContactType] FOREIGN KEY ([fk_ContactType]) REFERENCES [dbo].[List_ContactTypes] ([pk_ContactType]),
    CONSTRAINT [FK_ContactInfo_Stores] FOREIGN KEY ([fk_StoreID]) REFERENCES [dbo].[Stores] ([pk_StoreID]),
    CONSTRAINT [FK_ContactInfo_Users] FOREIGN KEY ([fk_UserID]) REFERENCES [dbo].[Users] ([pk_UserID])
);

