using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngestionLib.EntityFramework.DALModels
{
    public class RSEnavigationinfo
    {
        [Key]
        public int GUID { get; set; }
        public string SportsModel_ID { get; set; }
        public bool? has_standings { get; set; }
        public bool? is_knockout { get; set; }
        public string RSE_ID { get; set; }
    }
}
