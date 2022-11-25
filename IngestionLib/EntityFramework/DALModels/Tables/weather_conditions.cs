using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngestionLib.EntityFramework.DALModels
{
    public class weather_conditions
    {
        [Key]
        public int GUID { get; set; }
        public string SportsModel_ID { get; set; }
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

