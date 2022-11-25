
 select*  FROM [DBSportsEvent].[dbo].[SportModel]
select * FROM [DBSportsEvent].[dbo].weather_conditions
select * FROM [DBSportsEvent].[dbo].metadata
select * FROM [DBSportsEvent].[dbo].dateandtimeinfo
select * FROM [DBSportsEvent].[dbo].parent_sports_event_id
select * FROM [DBSportsEvent].[dbo].sports_organization_id
select * FROM [DBSportsEvent].[dbo].[State]
select * FROM [DBSportsEvent].[dbo].navigation_info
select * FROM [DBSportsEvent].[dbo].navigationinfovalue
select * FROM [DBSportsEvent].[dbo].properties
select * FROM [DBSportsEvent].[dbo].propertyvalue
select * FROM [DBSportsEvent].[dbo].relatedsportsevents
select * FROM [DBSportsEvent].[dbo].RSEnavigationinfo

--sp_help 'RSEnavigationinfo'
 
----  -- Delete all records
--DELETE FROM  [DBSportsEvent].[dbo].weather_conditions
--DELETE FROM  [DBSportsEvent].[dbo].metadata
--DELETE FROM  [DBSportsEvent].[dbo].dateandtimeinfo
--DELETE FROM  [DBSportsEvent].[dbo].parent_sports_event_id
--DELETE FROM  [DBSportsEvent].[dbo].sports_organization_id
--DELETE FROM  [DBSportsEvent].[dbo].[State]
--DELETE FROM  [DBSportsEvent].[dbo].navigation_info
--DELETE FROM  [DBSportsEvent].[dbo].navigationinfovalue
--DELETE FROM  [DBSportsEvent].[dbo].properties
--DELETE FROM  [DBSportsEvent].[dbo].propertyvalue
--DELETE FROM  [DBSportsEvent].[dbo].relatedsportsevents
--DELETE FROM  [DBSportsEvent].[dbo].RSEnavigationinfo
--DELETE FROM [SportModel]
--DBCC CHECKIDENT ([weather_conditions], RESEED, 0)
--DBCC CHECKIDENT (metadata, RESEED, 0)
--DBCC CHECKIDENT (dateandtimeinfo, RESEED, 0)
--DBCC CHECKIDENT (parent_sports_event_id, RESEED, 0)
--DBCC CHECKIDENT (sports_organization_id, RESEED, 0)
--DBCC CHECKIDENT ([State], RESEED, 0)
--DBCC CHECKIDENT ([navigation_info], RESEED, 0)
--DBCC CHECKIDENT (navigationinfovalue, RESEED, 0)
--DBCC CHECKIDENT (properties, RESEED, 0)
--DBCC CHECKIDENT (propertyvalue, RESEED, 0)
--DBCC CHECKIDENT (relatedsportsevents, RESEED, 0)
--DBCC CHECKIDENT ([RSEnavigationinfo], RESEED, 0)
