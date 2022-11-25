using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngestionLib.EntityFramework.DALModels
{
    public class propertyvalue
    {
        [Key]
        public int GUID { get; set; }
        public string SportsModel_ID { get; set; }
        public string? id { get; set; }
        public string? value { get; set; }
        public string properties_Key { get; set; }
    }
}
