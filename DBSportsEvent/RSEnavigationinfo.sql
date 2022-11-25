CREATE TABLE [dbo].[RSEnavigationinfo]
(
	[GUID] INT IDENTITY(1,1) NOT NULL  PRIMARY KEY,
    [SportsModel_ID] VARCHAR(50) NOT NULL ,  
	[has_standings] BIT NULL,
	[is_knockout] BIT NULL,
	[RSE_ID] VARCHAR(50) NULL

)
