CREATE TABLE [dbo].[State]
(
	[GUID] INT IDENTITY(1,1) NOT NULL  PRIMARY KEY,
    [SportsModel_ID] VARCHAR(50) NOT NULL , 
    [key] VARCHAR(50) NULL, 
    [value] VARCHAR(50) NULL

    CONSTRAINT [FK_SportModel_State_ID] FOREIGN KEY ([SportsModel_ID]) REFERENCES [SportModel]([ID])
)
