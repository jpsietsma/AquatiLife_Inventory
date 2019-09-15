CREATE TABLE [dbo].[List_FishFeedingTypes] (
    [pk_FeedingTypeID] INT           IDENTITY (1, 1) NOT NULL,
    [FeedingType]      NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_List_FishFeedingTypes] PRIMARY KEY CLUSTERED ([pk_FeedingTypeID] ASC)
);

