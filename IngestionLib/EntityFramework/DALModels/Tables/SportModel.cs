using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngestionLib.EntityFramework.DALModels
{
    public class SportModel
    {
        [Key]
        public string id { get; set; }
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

        public string? current_state { get; set; }
        public int? attendance { get; set; }
        public bool? attendanceSpecified { get; set; }
        public string? sport_id { get; set; }
        public string? venue_id { get; set; }
        public int? start_venue_id { get; set; }
        public int? finish_venue_id { get; set; }
        public string? phase_id { get; set; }

        public string? event_attributes { get; set; }
        public string? sports_discipline_id { get; set; }
        public string? sports_gender_id { get; set; }
        public int? sibling_order { get; set; }
        public bool? sibling_orderSpecified { get; set; }
        public int? schedule_status { get; set; }
        public bool? schedule_statusSpecified { get; set; }
        public int? result_status { get; set; }
        public bool? result_statusSpecified { get; set; }

        public int? event_type_detail { get; set; }
        public bool? event_type_detailSpecified { get; set; }
        public string? direct_parent_sports_event_id { get; set; }
        public string? home_participant_id { get; set; }
        public string? away_participant_id { get; set; }
        public int? participant_type { get; set; }
        public bool? participant_typeSpecified { get; set; }


        public string? translation_reference_id { get; set; }
        public string? sports { get; set; }
        public string? sports_organizations { get; set; }
        public string? venues { get; set; }
        public string? child_sports_events { get; set; }

        public string? xids { get; set; }

        //public ICollection<metadata>? Metadatas { get; set; }


        [NotMapped]
        public State[]? state { get; set; }
        [NotMapped]
        public sports_organization_id[]? sports_organization_ids { get; set; }
        [NotMapped]
        public parent_sports_event_id[]? parent_sports_event_ids { get; set; }
        [NotMapped]
        public weather_conditions? weather_conditions { get; set; }
        [NotMapped]
        public properties[]? properties { get; set; }
        [NotMapped]
        public propertyvalue[]? propertyvalue { get; set; }
        [NotMapped]
        public navigation_info[]? navigation_info { get; set; }
        [NotMapped]
        public navigationinfovalue[]? navigationinfovalue { get; set; }
        [NotMapped]
        public dateandtimeinfo? date_and_time_info { get; set; }
        [NotMapped]
        public relatedsportsevents[]? related_sports_events { get; set; }
        [NotMapped]
        public RSEnavigationinfo[]? RSEnavigationinfo { get; set; }
        [NotMapped]
        public metadata? meta { get; set; }


    }
}
