using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngestionLib.EntityFramework.DALModels
{
    public class navigation_info
    {
        [Key]
        public int GUID { get; set; }
        public string SportsModel_ID { get; set; }
        public string? key { get; set; }
    }
}
