CREATE TABLE [dbo].[propertyvalue]
(
	[GUID] INT IDENTITY(1,1) NOT NULL  PRIMARY KEY,
    [SportsModel_ID] VARCHAR(50) NOT NULL , 
    [Id] VARCHAR(50) NULL, 
    [value] VARCHAR(50) NULL,
    [properties_Key] VARCHAR(50) NULL

    CONSTRAINT [FK_SportModel_propertyvalue_ID] FOREIGN KEY ([SportsModel_ID]) REFERENCES [SportModel]([ID]) 
    
)
