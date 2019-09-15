CREATE TABLE [dbo].[Business_List_VendorTypes] (
    [pk_VendorTypeID] INT            IDENTITY (1, 1) NOT NULL,
    [VendorType]      NVARCHAR (200) NOT NULL,
    CONSTRAINT [PK_Business_List_VendorTypes] PRIMARY KEY CLUSTERED ([pk_VendorTypeID] ASC)
);

