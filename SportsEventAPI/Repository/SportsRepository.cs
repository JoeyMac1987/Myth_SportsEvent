using IngestionLib.EntityFramework.DAL;
using IngestionLib.EntityFramework.DALModels;
using IngestionLib.EntityFramework.Interface;
using IngestionLib.EntityFramework.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SportsEventAPI.Interfaces;
using System.Text.Json.Nodes;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace SportsEventAPI.Repository
{
    public class SportsRepository 
    {

        private SportsEventDBContext _repository;
        private IUnitofWork _unitofWork;
        private IConfiguration _config;

        public SportsRepository(SportsEventDBContext repository, IUnitofWork unitofWork, IConfiguration config)
        {
            _repository = repository;
            _config = config;
            _unitofWork = unitofWork;
        }

        public void AddRecord(List<SportsEventModel> jsonModels)
        {
            try
            {
                foreach (var jsonModel in jsonModels)
                {

                    #region sportsmodel
                    SportModel databaseModel = new SportModel();
                    databaseModel.id = jsonModel.id;
                    databaseModel.description = jsonModel.description;
                    databaseModel.type = jsonModel.type;
                    databaseModel.start_date_local = jsonModel.start_date_local;
                    databaseModel.start_date_localSpecified = jsonModel.start_date_localSpecified;
                    databaseModel.scheduled_start_time_utc = jsonModel.scheduled_start_time_utc;
                    databaseModel.scheduled_start_time_utcSpecified = jsonModel.scheduled_start_time_utcSpecified;
                    databaseModel.end_time = jsonModel.end_time;
                    databaseModel.end_timeSpecified = jsonModel.end_timeSpecified;
                    databaseModel.status = jsonModel.status;
                    databaseModel.statusSpecified = jsonModel.statusSpecified;
                    databaseModel.names = jsonModel.names;
                    databaseModel.current_state = jsonModel.current_state;
                    databaseModel.attendance = jsonModel.attendance;
                    databaseModel.attendanceSpecified = jsonModel.attendanceSpecified;
                    databaseModel.sport_id = jsonModel.sport_id;
                    databaseModel.venue_id = jsonModel.venue_id;
                    databaseModel.start_venue_id = jsonModel.start_venue_id;
                    databaseModel.finish_venue_id = jsonModel.finish_venue_id;
                    databaseModel.phase_id = jsonModel.phase_id;
                    databaseModel.event_attributes = jsonModel.event_attributes;
                    databaseModel.sports_discipline_id = jsonModel.sports_discipline_id;
                    databaseModel.sports_gender_id = jsonModel.sports_gender_id;
                    databaseModel.sibling_order = jsonModel.sibling_order;
                    databaseModel.sibling_orderSpecified = jsonModel.sibling_orderSpecified;
                    databaseModel.schedule_status = jsonModel.schedule_status;
                    databaseModel.schedule_statusSpecified = jsonModel.schedule_statusSpecified;
                    databaseModel.result_status = jsonModel.result_status;
                    databaseModel.result_statusSpecified = jsonModel.result_statusSpecified;
                    databaseModel.event_type_detail = jsonModel.event_type_detail;
                    databaseModel.event_type_detailSpecified = jsonModel.event_type_detailSpecified;
                    databaseModel.direct_parent_sports_event_id = jsonModel.direct_parent_sports_event_id;
                    databaseModel.home_participant_id = jsonModel.home_participant_id;
                    databaseModel.away_participant_id = jsonModel.away_participant_id;
                    databaseModel.participant_type = jsonModel.participant_type;
                    databaseModel.participant_typeSpecified = jsonModel.participant_typeSpecified;
                    databaseModel.translation_reference_id = jsonModel.translation_reference_id;
                    databaseModel.sports = jsonModel.sports;
                    databaseModel.sports_organizations = jsonModel.sports_organizations;
                    databaseModel.venues = jsonModel.venues;
                    databaseModel.child_sports_events = jsonModel.child_sports_events;
                    databaseModel.xids = jsonModel.xids;
                    _repository.SportModel.Add(databaseModel);
                    #endregion

                    if (jsonModel.weather_conditions != null)
                    {
                        weather_conditions weather_Conditions = new weather_conditions();

                        weather_Conditions.SportsModel_ID = jsonModel.id;
                        weather_Conditions.temperature_fahrenheit = jsonModel.weather_conditions.temperature_fahrenheit;
                        weather_Conditions.temperature_fahrenheitSpecified = jsonModel.weather_conditions.temperature_fahrenheitSpecified;
                        weather_Conditions.temperature_celsius = jsonModel.weather_conditions.temperature_celsius;
                        weather_Conditions.temperature_celsiusSpecified = jsonModel.weather_conditions.temperature_celsiusSpecified;
                        weather_Conditions.wind_speed_miles = jsonModel.weather_conditions.wind_speed_miles;
                        weather_Conditions.wind_speed_milesSpecified = jsonModel.weather_conditions.wind_speed_milesSpecified;
                        weather_Conditions.wind_speed_kilometers = jsonModel.weather_conditions.wind_speed_kilometers;
                        weather_Conditions.wind_speed_kilometersSpecified = jsonModel.weather_conditions.wind_speed_kilometersSpecified;
                        weather_Conditions.wind_direction = jsonModel.weather_conditions.wind_direction;
                        weather_Conditions.wind_directionSpecified = jsonModel.weather_conditions.wind_directionSpecified;
                        weather_Conditions.weather_type = jsonModel.weather_conditions.weather_type;
                        weather_Conditions.weather_typeSpecified = jsonModel.weather_conditions.weather_typeSpecified;
                        weather_Conditions.tail_wind_speed = jsonModel.weather_conditions.tail_wind_speed;
                        weather_Conditions.baseball_home_plate_wind_direction = jsonModel.weather_conditions.baseball_home_plate_wind_direction;
                        weather_Conditions.baseball_home_plate_wind_directionSpecified = jsonModel.weather_conditions.baseball_home_plate_wind_directionSpecified;
                        _repository.weather_conditions.Add(weather_Conditions);
                    }

                    if (jsonModel.date_and_time_info != null)
                    {
                        dateandtimeinfo dateandtimeinfo = new dateandtimeinfo();
                        dateandtimeinfo.SportsModel_ID = jsonModel.id;
                        dateandtimeinfo.scheduled_start_time_utc = jsonModel.date_and_time_info.scheduled_start_time_utc;
                        dateandtimeinfo.scheduled_start_time_utcSpecified = jsonModel.date_and_time_info.scheduled_start_time_utcSpecified;
                        dateandtimeinfo.scheduled_end_time_utc = jsonModel.date_and_time_info.scheduled_end_time_utc;
                        dateandtimeinfo.scheduled_end_time_utcSpecified = jsonModel.date_and_time_info.scheduled_end_time_utcSpecified;
                        dateandtimeinfo.actual_start_time_utc = jsonModel.date_and_time_info.actual_start_time_utc;
                        dateandtimeinfo.actual_start_time_utcSpecified = jsonModel.date_and_time_info.actual_start_time_utcSpecified;
                        dateandtimeinfo.actual_end_time_utc = jsonModel.date_and_time_info.actual_end_time_utc;
                        dateandtimeinfo.actual_end_time_utcSpecified = jsonModel.date_and_time_info.actual_end_time_utcSpecified;
                        dateandtimeinfo.start_date_local = jsonModel.date_and_time_info.start_date_local;
                        dateandtimeinfo.start_date_localSpecified = jsonModel.date_and_time_info.start_date_localSpecified;
                        dateandtimeinfo.end_date_local = jsonModel.date_and_time_info.end_date_local;
                        dateandtimeinfo.end_date_localSpecified = jsonModel.date_and_time_info.end_date_localSpecified;
                        _repository.dateandtimeinfo.Add(dateandtimeinfo);
                    }

                    if (jsonModel.meta != null)
                    {
                        metadata metadata = new metadata();
                        metadata.SportsModel_ID = jsonModel.id;
                        metadata.update_id = jsonModel.meta.update_id;
                        metadata.update_idSpecified = jsonModel.meta.update_idSpecified;
                        metadata.update_action = jsonModel.meta.update_action;
                        metadata.update_date = jsonModel.meta.update_date;
                        metadata.language = jsonModel.meta.language;
                        _repository.metadata.Add(metadata);

                    }

                    if (jsonModel.parent_sports_event_ids != null)
                    {
                        //iterate number of ids
                        for (int i = 0; i < jsonModel.parent_sports_event_ids.Length; i++)
                        {
                            parent_sports_event_id parent_Sports_Event_Id = new parent_sports_event_id();
                            parent_Sports_Event_Id.SportsModel_ID = jsonModel.id;
                            parent_Sports_Event_Id.ID = jsonModel.parent_sports_event_ids[i];
                            _repository.parent_sports_event_id.Add(parent_Sports_Event_Id);
                        }
                    }

                    if (jsonModel.sports_organization_ids != null)
                    {

                        //iterate number of ids
                        for (int i = 0; i < jsonModel.sports_organization_ids.Length; i++)
                        {
                            sports_organization_id sports_Organization_Id = new sports_organization_id();
                            sports_Organization_Id.SportsModel_ID = jsonModel.id;
                            sports_Organization_Id.id = jsonModel.sports_organization_ids[i];
                            _repository.sports_organization_id.Add(sports_Organization_Id);
                        }
                    }

                    if (jsonModel.state != null)
                    {
                        //iterate each of array
                        foreach (var state in jsonModel.state)
                        {
                            IngestionLib.EntityFramework.DALModels.State states = new IngestionLib.EntityFramework.DALModels.State();
                            states.SportsModel_ID = jsonModel.id;
                            states.key = state.key;
                            states.value = state.value;
                            _repository.State.Add(states);
                        }
                    }


                    if (jsonModel.navigation_info != null)
                    {
                        //iterate each of array
                        foreach (var record in jsonModel.navigation_info)
                        {
                            navigation_info navigation_Info = new navigation_info();
                            navigation_Info.SportsModel_ID = jsonModel.id;
                            navigation_Info.key = record.key;

                            navigationinfovalue navigationInfoValue = new navigationinfovalue();
                            navigationInfoValue.SportsModel_ID = jsonModel.id;
                            navigationInfoValue.id = record.value.id;
                            navigationInfoValue.value = record.value.value;
                            navigationInfoValue.navigation_info_key = record.key;



                            _repository.navigation_info.Add(navigation_Info);
                            _repository.navigationinfovalue.Add(navigationInfoValue);
                        }
                    }

                    if (jsonModel.properties != null)
                    {
                        //iterate each of array
                        foreach (var record in jsonModel.properties)
                        {
                            IngestionLib.EntityFramework.DALModels.properties properties = new IngestionLib.EntityFramework.DALModels.properties();
                            properties.SportsModel_ID = jsonModel.id;
                            properties.key = record.key;

                            IngestionLib.EntityFramework.DALModels.propertyvalue propertyvalue = new IngestionLib.EntityFramework.DALModels.propertyvalue();
                            propertyvalue.SportsModel_ID = jsonModel.id;
                            propertyvalue.id = record.value.id;
                            propertyvalue.value = record.value.value;
                            propertyvalue.properties_Key = record.key;

                            _repository.properties.Add(properties);
                            _repository.propertyvalue.Add(propertyvalue);
                        }
                    }


                    if (jsonModel.related_sports_events != null)
                    {
                        //iterate each of array
                        foreach (var record in jsonModel.related_sports_events)
                        {
                            IngestionLib.EntityFramework.DALModels.relatedsportsevents relatedSportsEvents = new IngestionLib.EntityFramework.DALModels.relatedsportsevents();
                            relatedSportsEvents.SportsModel_ID = jsonModel.id;
                            relatedSportsEvents.id = record.id;
                            relatedSportsEvents.type = record.type;
                            relatedSportsEvents.type_detail = record.type_detail;
                            relatedSportsEvents.depth = record.depth;

                            IngestionLib.EntityFramework.DALModels.RSEnavigationinfo rSEnavigationinfo = new IngestionLib.EntityFramework.DALModels.RSEnavigationinfo();
                            rSEnavigationinfo.SportsModel_ID = jsonModel.id;
                            if (record.navigation_info != null)
                            {
                                rSEnavigationinfo.has_standings = record.navigation_info.has_standings;
                                rSEnavigationinfo.is_knockout = record.navigation_info.is_knockout;
                            }
                            rSEnavigationinfo.RSE_ID = record.id;
                            _repository.RSEnavigationinfo.Add(rSEnavigationinfo);


                            _repository.relatedsportsevents.Add(relatedSportsEvents);

                        }
                    }



                    //save everything via EFcore
                    _repository.SaveChanges();

                }

                }
            catch (Exception ex)
            {
                var placeholder = ex.Message;
            }

        }



        public SportsEventModel SearchEventByID (string id)
        {
            SportModel sportModel = new SportModel();
            SportsEventModel returnModel = new SportsEventModel();

            try
            {                
                var data = (from a in _repository.SportModel
                            join b in _repository.metadata
                            on new { id = a.id } equals new { id = b.SportsModel_ID } into md
                            from MetaD in md.DefaultIfEmpty()
                            join c in _repository.weather_conditions
                            on new { id = a.id } equals new { id = c.SportsModel_ID } into wc
                            from weatherCond in wc.DefaultIfEmpty()  //left join
                            join d in _repository.dateandtimeinfo
                            on new { id = a.id } equals new { id = d.SportsModel_ID } into dati
                            from DateNTimeInfo in dati.DefaultIfEmpty()
                            where a.id == id
                            select new ModelContainer
                            {
                                SportModel = a
                                                        ,
                                MetaData = MetaD
                                                        ,
                                Weather_Conditions = weatherCond
                                                        ,
                                DateAndTimeInfo = DateNTimeInfo

                            }).FirstOrDefault(); ; //, dateandtimeinfo = d });

                if (data != null)
                {
                    data.Properties = _repository.properties.Where(x => x.SportsModel_ID == id).ToArray();
                    data.PropertyValues = _repository.propertyvalue.Where(x => x.SportsModel_ID == id).ToArray();
                    data.NavigationInfo = _repository.navigation_info.Where(x => x.SportsModel_ID == id).ToArray();
                    data.NavigationInfoValue =_repository.navigationinfovalue.Where(x => x.SportsModel_ID == id) .ToArray();
                    data.RelatedSportsEvents = _repository.relatedsportsevents.Where(x => x.SportsModel_ID == id).ToArray();
                    data.RSENavigationInfo = _repository.RSEnavigationinfo.Where(x => x.SportsModel_ID == id).ToArray();
                    data.Sports_Organization_Id = _repository.sports_organization_id.Where(x => x.SportsModel_ID == id).ToArray();
                    data.ParentSports_Event_Id = _repository.parent_sports_event_id.Where(x => x.SportsModel_ID == id).ToArray();
                    data.State = _repository.State.Where(x => x.SportsModel_ID == id).ToArray();

                    sportModel = data.SportModel;
                    sportModel.date_and_time_info = data.DateAndTimeInfo;
                    sportModel.meta = data.MetaData;
                    sportModel.navigation_info = data.NavigationInfo;
                    sportModel.navigationinfovalue = data.NavigationInfoValue;
                    sportModel.parent_sports_event_ids = data.ParentSports_Event_Id;
                    sportModel.sports_organization_ids = data.Sports_Organization_Id;
                    sportModel.properties = data.Properties; 
                    sportModel.propertyvalue = data.PropertyValues;
                    sportModel.related_sports_events = data.RelatedSportsEvents;
                    sportModel.RSEnavigationinfo = data.RSENavigationInfo;
                    sportModel.state = data.State;
                    sportModel.weather_conditions = data.Weather_Conditions;

                
                    returnModel = DTOEvent(sportModel);
                
                }
                return returnModel;
            }
            catch(Exception ex)
            {
                var message = ex.Message;
                return returnModel;
            }



        }



        public SportsEventModel DTOEvent (SportModel model)
        {
            
            SportsEventModel sportModel = new SportsEventModel();
            try
            {
                sportModel.id = model.id;
                sportModel.description = model.description;
                sportModel.type = model.type;
                sportModel.start_date_local = model.start_date_local;
                sportModel.start_date_localSpecified = model.start_date_localSpecified;
                sportModel.scheduled_start_time_utc = model.scheduled_start_time_utc;
                sportModel.scheduled_start_time_utcSpecified = model.scheduled_start_time_utcSpecified;
                sportModel.end_time = model.end_time;
                sportModel.end_timeSpecified = model.end_timeSpecified;
                sportModel.status = model.status;
                sportModel.statusSpecified = model.statusSpecified;
                sportModel.names = model.names;
                sportModel.current_state = model.current_state;
                sportModel.attendance = model.attendance;
                sportModel.attendanceSpecified = model.attendanceSpecified;
                sportModel.sport_id = model.sport_id;
                sportModel.venue_id = model.venue_id;
                sportModel.start_venue_id = model.start_venue_id;
                sportModel.finish_venue_id = model.finish_venue_id;
                sportModel.phase_id = model.phase_id;
                sportModel.event_attributes = model.event_attributes;
                sportModel.sports_discipline_id = model.sports_discipline_id;
                sportModel.sports_gender_id = model.sports_gender_id;
                sportModel.sibling_order = model.sibling_order;
                sportModel.sibling_orderSpecified = model.sibling_orderSpecified;
                sportModel.schedule_status = model.schedule_status;
                sportModel.schedule_statusSpecified = model.schedule_statusSpecified;
                sportModel.result_status = model.result_status;
                sportModel.result_statusSpecified = model.result_statusSpecified;
                sportModel.event_type_detail = model.event_type_detail;
                sportModel.event_type_detailSpecified = model.event_type_detailSpecified;
                sportModel.direct_parent_sports_event_id = model.direct_parent_sports_event_id;
                sportModel.home_participant_id = model.home_participant_id;
                sportModel.away_participant_id = model.away_participant_id;
                sportModel.participant_type = model.participant_type;
                sportModel.participant_typeSpecified = model.participant_typeSpecified;
                sportModel.translation_reference_id = model.translation_reference_id;
                sportModel.sports = model.sports;
                sportModel.sports_organizations = model.sports_organizations;
                sportModel.venues = model.venues;
                sportModel.child_sports_events = model.child_sports_events;
                sportModel.xids = model.xids;


                if (model.weather_conditions != null)
                {
                    WeatherConditions weather_Conditions = new WeatherConditions();

                    weather_Conditions.temperature_fahrenheit = model.weather_conditions.temperature_fahrenheit;
                    weather_Conditions.temperature_fahrenheitSpecified = model.weather_conditions.temperature_fahrenheitSpecified;
                    weather_Conditions.temperature_celsius = model.weather_conditions.temperature_celsius;
                    weather_Conditions.temperature_celsiusSpecified = model.weather_conditions.temperature_celsiusSpecified;
                    weather_Conditions.wind_speed_miles = model.weather_conditions.wind_speed_miles;
                    weather_Conditions.wind_speed_milesSpecified = model.weather_conditions.wind_speed_milesSpecified;
                    weather_Conditions.wind_speed_kilometers = model.weather_conditions.wind_speed_kilometers;
                    weather_Conditions.wind_speed_kilometersSpecified = model.weather_conditions.wind_speed_kilometersSpecified;
                    weather_Conditions.wind_direction = model.weather_conditions.wind_direction;
                    weather_Conditions.wind_directionSpecified = model.weather_conditions.wind_directionSpecified;
                    weather_Conditions.weather_type = model.weather_conditions.weather_type;
                    weather_Conditions.weather_typeSpecified = model.weather_conditions.weather_typeSpecified;
                    weather_Conditions.tail_wind_speed = model.weather_conditions.tail_wind_speed;
                    weather_Conditions.baseball_home_plate_wind_direction = model.weather_conditions.baseball_home_plate_wind_direction;
                    weather_Conditions.baseball_home_plate_wind_directionSpecified = model.weather_conditions.baseball_home_plate_wind_directionSpecified;
                    sportModel.weather_conditions = weather_Conditions;
                }

                if (model.date_and_time_info != null)
                {
                    date_and_time_info dateandtimeinfo = new date_and_time_info();
                    dateandtimeinfo.scheduled_start_time_utc = model.date_and_time_info.scheduled_start_time_utc;
                    dateandtimeinfo.scheduled_start_time_utcSpecified = model.date_and_time_info.scheduled_start_time_utcSpecified;
                    dateandtimeinfo.scheduled_end_time_utc = model.date_and_time_info.scheduled_end_time_utc;
                    dateandtimeinfo.scheduled_end_time_utcSpecified = model.date_and_time_info.scheduled_end_time_utcSpecified;
                    dateandtimeinfo.actual_start_time_utc = model.date_and_time_info.actual_start_time_utc;
                    dateandtimeinfo.actual_start_time_utcSpecified = model.date_and_time_info.actual_start_time_utcSpecified;
                    dateandtimeinfo.actual_end_time_utc = model.date_and_time_info.actual_end_time_utc;
                    dateandtimeinfo.actual_end_time_utcSpecified = model.date_and_time_info.actual_end_time_utcSpecified;
                    dateandtimeinfo.start_date_local = model.date_and_time_info.start_date_local;
                    dateandtimeinfo.start_date_localSpecified = model.date_and_time_info.start_date_localSpecified;
                    dateandtimeinfo.end_date_local = model.date_and_time_info.end_date_local;
                    dateandtimeinfo.end_date_localSpecified = model.date_and_time_info.end_date_localSpecified;
                    sportModel.date_and_time_info = dateandtimeinfo;
                }

                if (model.meta != null)
                {
                    meta metadata = new meta();
                    metadata.update_id = model.meta.update_id;
                    metadata.update_idSpecified = model.meta.update_idSpecified;
                    metadata.update_action = model.meta.update_action;
                    metadata.update_date = model.meta.update_date;
                    metadata.language = model.meta.language;
                    sportModel.meta = metadata;

                }

                if (model.parent_sports_event_ids != null)
                {
                    List<string> parentList = new List<string>();

                    //iterate number of ids
                    for (int i = 0; i < model.parent_sports_event_ids.Length; i++)
                    {
                        parentList.Add(model.parent_sports_event_ids[i].ToString());
                    }
                    if (parentList.Count > 0)
                    {
                        sportModel.parent_sports_event_ids = parentList.ToArray();
                    }
                }

                if (model.sports_organization_ids != null)
                {

                    List<string> sportsList = new List<string>();

                    //iterate number of ids
                    for (int i = 0; i < model.sports_organization_ids.Length; i++)
                    {
                        sportsList.Add(model.sports_organization_ids[i].ToString());
                    }
                    if (sportsList.Count > 0)
                    {
                        sportModel.sports_organization_ids = sportsList.ToArray();
                    }
                }

                if (model.state != null)
                {
                    List<State> stateList = new List<State>();
                    //iterate each of array
                    foreach (var state in model.state)
                    {
                        State states = new State();
                        states.key = state.key;
                        states.value = state.value;
                        stateList.Add(states);
                    }
                    sportModel.state = stateList.ToArray();

                }


                if (model.navigation_info != null)
                {
                    List<NavigationInfo> navList = new List<NavigationInfo>();
                    //iterate each of array
                    for (var i = 0; i < model.navigation_info.Length; i++)
                    {
                        NavigationInfo navigation_Info = new NavigationInfo();
                        NavigationInfoValue Navigationinfovalues = new NavigationInfoValue(); 
                        navigation_Info.key = model.navigation_info[i].key;
                        if (model.navigationinfovalue[i].value != null)
                        {
                            Navigationinfovalues.id = model.navigationinfovalue[i].id;
                            Navigationinfovalues.value = model.navigationinfovalue[i].value;
                        }
                        navigation_Info.value = Navigationinfovalues;
                        navList.Add(navigation_Info);
                    }

                    sportModel.navigation_info = navList.ToArray();
                }

                if (model.properties != null)
                {

                    List<properties> list = new List<properties>();
                    //iterate each of array
                    for (var i = 0; i < model.properties.Length; i++)
                    {
                        properties Properties = new properties();
                        propertyvalue propertyvalue = new propertyvalue();
                        Properties.key = model.properties[i].key;
                        if (model.propertyvalue[i].value != null)
                        {
                            propertyvalue.id = model.propertyvalue[i].id;
                            propertyvalue.value = model.propertyvalue[i].value;
                        }
                        Properties.value = propertyvalue;
                        list.Add(Properties);
                    }

                    sportModel.properties = list.ToArray();
                }


                if (model.related_sports_events != null)
                {
                    List<relatedsportsevents> list = new List<relatedsportsevents>();
                    //iterate each of array
                    for (var i = 0; i < model.related_sports_events.Length; i++)
                    {
                        relatedsportsevents rse = new relatedsportsevents();
                        RSEnavigationinfo rseNI = new RSEnavigationinfo();
                        rse.id = model.related_sports_events[i].id;
                        rse.type = model.related_sports_events[i].type;
                        rse.type_detail = model.related_sports_events[i].type_detail;
                        rse.depth = model.related_sports_events[i].depth;
                        if (model.RSEnavigationinfo[i].is_knockout != null)
                        {
                            rseNI.is_knockout = model.RSEnavigationinfo[i].is_knockout.Value ;
                            rseNI.has_standings = model.RSEnavigationinfo[i].has_standings.Value;
                        }
                        rse.navigation_info = rseNI;
                        list.Add(rse);
                    }

                    sportModel.related_sports_events = list.ToArray();
                }
            }
            catch(Exception EX)
            {
                var PLACEHOLDER = "ERROR";
                sportModel = new SportsEventModel();
            }
            return sportModel;
        }


    }
}
