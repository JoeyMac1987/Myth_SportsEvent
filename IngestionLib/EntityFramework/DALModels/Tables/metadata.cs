using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngestionLib.EntityFramework.DALModels
{
    public class metadata
    {
        [Key]
        public int GUID { get; set; }
        public string SportsModel_ID { get; set; }
        public string? update_id { get; set; }
        public bool? update_idSpecified { get; set; }
        public string? update_action { get; set; }
        public string? update_date { get; set; }
        public string? language { get; set; }
    }
}
