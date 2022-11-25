CREATE TABLE [dbo].[metadata]
(
	[GUID] INT IDENTITY(1,1) NOT NULL  PRIMARY KEY,
    [SportsModel_ID] VARCHAR(50) NOT NULL, 
    [update_id] VARCHAR(50) NULL, 
    [update_idSpecified] BIT NULL, 
    [update_action] VARCHAR(50) NULL, 
    [update_date] VARCHAR(50) NULL, 
    [language] VARCHAR(50) NULL

    CONSTRAINT [FK_SportModel_metadata_ID] FOREIGN KEY ([SportsModel_ID]) REFERENCES [SportModel]([ID])
)
