CREATE TABLE [dbo].[CrustaceanMoltRecords] (
    [pk_MoltRecordID] INT      IDENTITY (1, 1) NOT NULL,
    [fk_UserFishID]   INT      NOT NULL,
    [MoltDate]        DATETIME NOT NULL,
    CONSTRAINT [PK_CrustaceanMoltRecords] PRIMARY KEY CLUSTERED ([pk_MoltRecordID] ASC),
    CONSTRAINT [FK_CrustaceanMoltRecords_UserFish] FOREIGN KEY ([fk_UserFishID]) REFERENCES [dbo].[UserFish] ([pk_UserFishID])
);

