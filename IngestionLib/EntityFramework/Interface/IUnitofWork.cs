using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngestionLib.EntityFramework.Interface
{
    public interface IUnitofWork
    {

        iSportsEventDBContext SportsEventDBContext { get; }
        IDateandtimeinfoRepository DateandtimeinfoRepository { get; }
        IMetadataRepository MetadataRepository { get; }
        INavigation_infoRepository Navigation_infoRepository { get; }
        INavigationinfovalueRepository NavigationinfovalueRepository { get; }
        IPropertiesRepository PropertiesRepository { get; }
        IPropertyvalueRepository PropertyvalueRepository { get; }
        IRelatedsportseventsRepository RelatedsportseventsRepository { get; }
        IRSEnavigationinfoRepository RSEnavigationinfoRepository { get; }
        IStateRepository StateRepository { get; }
        IWeather_conditionsRepository Weather_conditionsRepository { get; }
        ISportsModelRepository SportsModelRepository { get; }
    }
}
