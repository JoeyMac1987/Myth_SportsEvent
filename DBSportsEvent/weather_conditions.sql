CREATE TABLE [dbo].[weather_conditions]
(
	[GUID] INT IDENTITY(1,1) NOT NULL  PRIMARY KEY,
    [SportsModel_ID] VARCHAR(50) NOT NULL , 
	temperature_fahrenheit int,
    temperature_fahrenheitSpecified bit,
    temperature_celsius decimal ,
    temperature_celsiusSpecified bit,
    wind_speed_miles int,
    wind_speed_milesSpecified bit,
    wind_speed_kilometers decimal,
    wind_speed_kilometersSpecified bit,
    wind_direction int,
    wind_directionSpecified bit,
    weather_type int,
    weather_typeSpecified bit,
    tail_wind_speed int,
    baseball_home_plate_wind_direction int,
    baseball_home_plate_wind_directionSpecified bit,

    CONSTRAINT [FK_SportModel_weathercondition_ID] FOREIGN KEY ([SportsModel_ID]) REFERENCES [SportModel]([ID])
)
