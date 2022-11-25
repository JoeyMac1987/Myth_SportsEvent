CREATE TABLE [dbo].[navigation_info]
(
	[GUID] INT IDENTITY(1,1) NOT NULL  PRIMARY KEY,
    [SportsModel_ID] VARCHAR(50) NOT NULL , 
    [key] VARCHAR(50) NULL 

    CONSTRAINT [FK_SportModel_navigationinfo_ID] FOREIGN KEY ([SportsModel_ID]) REFERENCES [SportModel]([ID]) 
)
