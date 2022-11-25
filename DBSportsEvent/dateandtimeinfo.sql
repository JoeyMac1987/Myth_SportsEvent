CREATE TABLE [dbo].[dateandtimeinfo]
(
    [GUID] INT IDENTITY(1,1) NOT NULL  PRIMARY KEY,
    [SportsModel_ID] VARCHAR(50) NOT NULL , 
    [scheduled_start_time_utc] VARCHAR(50) NULL, 
    [scheduled_start_time_utcSpecified] BIT NULL, 
    [scheduled_end_time_utc] VARCHAR(50) NULL, 
    [scheduled_end_time_utcSpecified] BIT NULL, 
    [actual_start_time_utc] VARCHAR(50) NULL, 
    [actual_start_time_utcSpecified] BIT NULL, 
    [actual_end_time_utc] VARCHAR(50) NULL, 
    [actual_end_time_utcSpecified] BIT NULL, 
    [start_date_local] VARCHAR(50) NULL, 
    [start_date_localSpecified] BIT NULL, 
    [end_date_local] VARCHAR(50) NULL, 
    [end_date_localSpecified] BIT NULL

    CONSTRAINT [FK_SportModel_dateandtimeinfo_ID] FOREIGN KEY ([SportsModel_ID]) REFERENCES [SportModel]([ID])
)
