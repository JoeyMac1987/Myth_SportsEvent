CREATE TABLE [dbo].[sports_organization_id]
(
	[GUID] INT IDENTITY(1,1) NOT NULL  PRIMARY KEY,
    [SportsModel_ID] VARCHAR(50) NOT NULL , 
    [id] VARCHAR(50) NULL

    CONSTRAINT [FK_SportModel_sportsorganization_ID] FOREIGN KEY ([SportsModel_ID]) REFERENCES [SportModel]([ID])
)
