CREATE TABLE [dbo].[relatedsportsevents]
(
	[GUID] INT IDENTITY(1,1) NOT NULL  PRIMARY KEY,
    [SportsModel_ID] VARCHAR(50) NOT NULL , 
    [ID] VARCHAR(50) NULL, 
    [type] VARCHAR(50) NULL, 
    [type_detail] VARCHAR(50) NULL, 
    [depth] VARCHAR(50) NULL 

    CONSTRAINT [FK_SportModel_RSE_ID] FOREIGN KEY ([SportsModel_ID]) REFERENCES [SportModel]([ID])
)
