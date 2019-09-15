CREATE TABLE [dbo].[List_ErrorTypes] (
    [pk_ErrorTypeID]       INT            IDENTITY (1, 1) NOT NULL,
    [ErrorTypeDescription] NVARCHAR (100) NOT NULL,
    [fk_ErrorSeverity]     INT            NOT NULL,
    [fk_ErrorWaterType]    INT            NULL,
    [fk_ErrorCategory]     INT            CONSTRAINT [DF_List_ErrorTypes_fk_ErrorCategory] DEFAULT ((5)) NOT NULL,
    CONSTRAINT [PK_List_ErrorTypes] PRIMARY KEY CLUSTERED ([pk_ErrorTypeID] ASC),
    CONSTRAINT [FK_List_ErrorTypes_List_ErrorCategories] FOREIGN KEY ([fk_ErrorCategory]) REFERENCES [dbo].[List_ErrorCategories] ([pk_CategoryID]),
    CONSTRAINT [FK_List_ErrorTypes_List_WaterTypes] FOREIGN KEY ([fk_ErrorWaterType]) REFERENCES [dbo].[List_WaterTypes] ([pk_WaterTypeID])
);

