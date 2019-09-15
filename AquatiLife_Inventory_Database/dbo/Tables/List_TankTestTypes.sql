CREATE TABLE [dbo].[List_TankTestTypes] (
    [pk_TestTypeID] INT            IDENTITY (1, 1) NOT NULL,
    [TestType]      NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_List_TankTestTypes] PRIMARY KEY CLUSTERED ([pk_TestTypeID] ASC)
);

