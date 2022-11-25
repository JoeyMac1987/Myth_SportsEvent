using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IngestionLib.EntityFramework.DALModels;


namespace IngestionLib.EntityFramework.Interface
{
    public interface IWeather_conditionsRepository : IRepositoryBase<weather_conditions>
    {
    }
}
