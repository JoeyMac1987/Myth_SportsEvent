CREATE TABLE [dbo].[parent_sports_event_id]
(
	[GUID] INT IDENTITY(1,1) NOT NULL  PRIMARY KEY,
    [SportsModel_ID] VARCHAR(50) NOT NULL ,
    [ID] VARCHAR(50) NULL

    CONSTRAINT [FK_SportModel_parentsportsevent_ID] FOREIGN KEY ([SportsModel_ID]) REFERENCES [SportModel]([ID])
)
