using IngestionLib.EntityFramework.DALModels;
using IngestionLib.EntityFramework.DAL;
using IngestionLib.EntityFramework.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngestionLib.EntityFramework.Repository
{
    public class Weather_conditionsRepository : RepositoryBase<weather_conditions>, IWeather_conditionsRepository
    {
        public Weather_conditionsRepository(SportsEventDBContext context) : base(context)
        {
            this.dbSet = context.Set<weather_conditions>();
        }
    }
}
