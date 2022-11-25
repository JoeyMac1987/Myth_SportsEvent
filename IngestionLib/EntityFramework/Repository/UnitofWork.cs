using IngestionLib.EntityFramework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngestionLib.EntityFramework.Repository
{
    public class UnitofWork : IUnitofWork
    {
        //Databases
        private readonly iSportsEventDBContext _context;

        //Table Interfaces
        private readonly IDateandtimeinfoRepository _dateandtimeinfoRepository;
        private readonly IMetadataRepository _metadataRepository;
        private readonly INavigation_infoRepository _navigation_InfoRepository;
        private readonly INavigationinfovalueRepository _navigationinfovalueRepository;
        private readonly IPropertiesRepository _propertiesRepository;
        private readonly IPropertyvalueRepository _propertyvalueRepository;
        private readonly IRelatedsportseventsRepository _relatedsportseventsRepository;
        private readonly IRSEnavigationinfoRepository _rSEnavigationinfoRepository;
        private readonly IStateRepository _stateRepository;
        private readonly IWeather_conditionsRepository _weather_ConditionsRepository;
        private readonly ISportsModelRepository _sportsModelRepository;

        private bool _disposed;

        public UnitofWork( iSportsEventDBContext context,
                                    IDateandtimeinfoRepository dateandtimeinfoRepository,
                                    IMetadataRepository metadataRepository,
                                    INavigation_infoRepository navigation_InfoRepository,
                                    INavigationinfovalueRepository navigationinfovalueRepository,
                                    IPropertiesRepository propertiesRepository,
                                    IPropertyvalueRepository propertyvalueRepository,
                                    IRelatedsportseventsRepository relatedsportseventsRepository,
                                    IRSEnavigationinfoRepository rSEnavigationinfoRepository,
                                    IStateRepository stateRepository,
                                    IWeather_conditionsRepository weather_ConditionsRepository,
                                    ISportsModelRepository sportsModelRepository)
        {
            //Databases
            _context = context;

            //Table interfaces
            _dateandtimeinfoRepository = dateandtimeinfoRepository;
            _metadataRepository = metadataRepository;
            _navigation_InfoRepository = navigation_InfoRepository;
            _navigationinfovalueRepository = navigationinfovalueRepository;
            _propertiesRepository = propertiesRepository;
            _propertyvalueRepository = propertyvalueRepository;
            _relatedsportseventsRepository = relatedsportseventsRepository;
            _rSEnavigationinfoRepository = rSEnavigationinfoRepository;
            _stateRepository = stateRepository;
            _weather_ConditionsRepository = weather_ConditionsRepository;
            _sportsModelRepository = sportsModelRepository;
        }

        public iSportsEventDBContext SportsEventDBContext
        {
            get { return _context; }
        }
        #region InterfaceAccess
        public IDateandtimeinfoRepository DateandtimeinfoRepository
        {
            get { return _dateandtimeinfoRepository; }
        }
        public IMetadataRepository MetadataRepository
        {
            get { return _metadataRepository; }
        }
        public INavigation_infoRepository Navigation_infoRepository
        {
            get { return _navigation_InfoRepository; }
        }
        public INavigationinfovalueRepository NavigationinfovalueRepository
        {
            get { return _navigationinfovalueRepository; }
        }
        public IPropertiesRepository PropertiesRepository
        {
            get { return _propertiesRepository; }
        }
        public IPropertyvalueRepository PropertyvalueRepository
        {
            get { return _propertyvalueRepository; }
        }
        public IRelatedsportseventsRepository RelatedsportseventsRepository
        {
            get { return _relatedsportseventsRepository; }
        }
        public IRSEnavigationinfoRepository RSEnavigationinfoRepository
        {
            get { return _rSEnavigationinfoRepository; }
        }
        public IStateRepository StateRepository
        {
            get { return _stateRepository; }
        }

        public IWeather_conditionsRepository Weather_conditionsRepository
        {
            get { return _weather_ConditionsRepository; }
        }

        public ISportsModelRepository SportsModelRepository
        {
            get { return _sportsModelRepository; }
        }
        #endregion
    }
}
