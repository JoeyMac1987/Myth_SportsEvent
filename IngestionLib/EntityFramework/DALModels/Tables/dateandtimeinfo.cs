using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngestionLib.EntityFramework.DALModels
{
    public class dateandtimeinfo
    {
        [Key]
        public int GUID { get; set; }
        public string SportsModel_ID { get; set; }

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
}
