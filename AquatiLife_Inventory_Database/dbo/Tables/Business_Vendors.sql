CREATE TABLE [dbo].[Business_Vendors] (
    [pk_VendorID]    INT            NOT NULL,
    [VendorName]     NVARCHAR (255) NOT NULL,
    [fk_ContactInfo] INT            NULL,
    [fk_VendorType]  INT            NULL,
    CONSTRAINT [FK_Business_Vendors_Business_List_VendorTypes] FOREIGN KEY ([fk_VendorType]) REFERENCES [dbo].[Business_List_VendorTypes] ([pk_VendorTypeID]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Business_Vendors_ContactInfo] FOREIGN KEY ([fk_ContactInfo]) REFERENCES [dbo].[ContactInfo] ([pk_ContactID]) ON DELETE CASCADE ON UPDATE CASCADE
);

