using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsEventAPI
{
    public class SportsEventModel
    {

        public string? description { get; set; }
        public int type { get; set; }
        public string? start_date_local { get; set; }
        public bool start_date_localSpecified { get; set; }
        public string? scheduled_start_time_utc { get; set; }
        public bool scheduled_start_time_utcSpecified { get; set; }
        public string? end_time { get; set; }
        public bool? end_timeSpecified { get; set; }
        public int? status { get; set; }
        public bool? statusSpecified { get; set; }
        public string? names { get; set; }
        public IEnumerable<State>? state { get; set; }
        public string? current_state { get; set; }
        public int? attendance { get; set; }
        public bool? attendanceSpecified { get; set; }
        public string? sport_id { get; set; }
        public string? venue_id { get; set; }
        public int? start_venue_id { get; set; }
        public int? finish_venue_id { get; set; }
        public string? phase_id { get; set; }
        public string[]? sports_organization_ids { get; set; }
        public string[]? parent_sports_event_ids { get; set; }
        public WeatherConditions? weather_conditions { get; set; }
        public string? event_attributes { get; set; }
        public string? sports_discipline_id { get; set; }
        public string? sports_gender_id { get; set; }
        public int? sibling_order { get; set; }
        public bool? sibling_orderSpecified { get; set; }
        public int? schedule_status { get; set; }
        public bool? schedule_statusSpecified { get; set; }
        public int? result_status { get; set; }
        public bool? result_statusSpecified { get; set; }
        public properties[]? properties { get; set; }
        public NavigationInfo[]? navigation_info { get; set; }
        public int? event_type_detail { get; set; }
        public bool? event_type_detailSpecified { get; set; }
        public string? direct_parent_sports_event_id { get; set; }
        public string? home_participant_id { get; set; }
        public string? away_participant_id { get; set; }
        public int? participant_type { get; set; }
        public bool? participant_typeSpecified { get; set; }

        public date_and_time_info? date_and_time_info { get; set; }
        public string? translation_reference_id { get; set; }
        public string? sports { get; set; }
        public string? sports_organizations { get; set; }
        public string? venues { get; set; }
        public string? child_sports_events { get; set; }
        public relatedsportsevents[]? related_sports_events { get; set; }
        public string? id { get; set; }

        public meta? meta { get; set; }
        public string? xids { get; set; }

    }

    public class State
    {
        public string? key { get; set; }
        public string? value { get; set; }
    }
    //public class sports_organization_id
    //{
    //    public string? id { get; set; }
    //}
    //public class parent_sports_event_id
    //{
    //    public string? id { get; set; }
    //}
    public class properties
    {
        public string? key { get; set; }
        public propertyvalue? value { get; set; }
    }
    public class propertyvalue
    {
        public string? id { get; set; }
        public string? value { get; set; }
    }


    public class NavigationInfo
    {
        public string? key { get; set; }
        public NavigationInfoValue? value { get; set; }
    }
    public class NavigationInfoValue
    {
        public string? id { get; set; }
        public string? value { get; set; }
    }

    public class date_and_time_info
    {
        public string? scheduled_start_time_utc { get; set; }
        public bool? scheduled_start_time_utcSpecified { get; set; }
        public string? scheduled_end_time_utc { get; set; }
        public bool? scheduled_end_time_utcSpecified { get; set; }
        public string? actual_start_time_utc { get; set; }
        public bool? actual_start_time_utcSpecified { get; set; }
        public string? actual_end_time_utc { get; set; }
        public bool? actual_end_time_utcSpecified { get; set; }
        public string? start_date_local { get; set; }
        public bool? start_date_localSpecified { get; set; }
        public string? end_date_local { get; set; }
        public bool? end_date_localSpecified { get; set; }
    }

    public class relatedsportsevents
    {
        public string? id { get; set; }
        public string? type { get; set; }
        public string? type_detail { get; set; }
        public string? depth { get; set; }
        public RSEnavigationinfo? navigation_info { get; set; }
    }

    public class RSEnavigationinfo
    {
        public bool? has_standings { get; set; }
        public bool? is_knockout { get; set; }
    }

     public class meta
    {
        public string? update_id { get; set; }
        public bool? update_idSpecified { get; set; }
        public string? update_action { get; set; }
        public string? update_date { get; set; }
        public string? language { get; set; }
    }

    public class WeatherConditions
    {
        public int? temperature_fahrenheit { get; set; }
        public bool? temperature_fahrenheitSpecified { get; set; }
        public decimal? temperature_celsius { get; set; }
        public bool? temperature_celsiusSpecified { get; set; }
        public int? wind_speed_miles { get; set; }
        public bool? wind_speed_milesSpecified { get; set; }
        public decimal? wind_speed_kilometers { get; set; }
        public bool? wind_speed_kilometersSpecified { get; set; }
        public int? wind_direction { get; set; }
        public bool? wind_directionSpecified { get; set; }
        public int? weather_type { get; set; }
        public bool? weather_typeSpecified { get; set; }
        public int? tail_wind_speed { get; set; }
        public int? baseball_home_plate_wind_direction { get; set; }
        public bool? baseball_home_plate_wind_directionSpecified { get; set; }
    }

}

