CREATE TABLE [dbo].[List_ActionTypes] (
    [pk_ActionTypeID]       INT            IDENTITY (1, 1) NOT NULL,
    [ActionTypeDescription] NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_List_ActionTypes] PRIMARY KEY CLUSTERED ([pk_ActionTypeID] ASC)
);

