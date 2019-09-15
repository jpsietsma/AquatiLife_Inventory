CREATE TABLE [dbo].[List_CollectionLocations] (
    [pk_locationID] INT           IDENTITY (1, 1) NOT NULL,
    [LocationName]  NVARCHAR (75) NOT NULL,
    [City]          NVARCHAR (50) NULL,
    [State]         NVARCHAR (2)  NULL,
    [Zip]           NVARCHAR (5)  NULL,
    CONSTRAINT [PK_List_CollectionLocations] PRIMARY KEY CLUSTERED ([pk_locationID] ASC)
);

