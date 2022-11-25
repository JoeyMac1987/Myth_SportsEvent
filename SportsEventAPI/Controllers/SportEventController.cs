using IngestionLib.EntityFramework.DAL;
using IngestionLib.EntityFramework.DALModels;
using IngestionLib.EntityFramework.Interface;
using IngestionLib.EntityFramework.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SportsEventAPI.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SportsEventAPI.Controllers
{
    [Route("API/{controller}/{action}")]
    [ApiController]
    public class SportEventController : ControllerBase
    {

        private SportsEventDBContext _repository;
        private IUnitofWork _unitofWork;
        private IConfiguration _config;

        public SportEventController(SportsEventDBContext repository, IUnitofWork unitofWork, IConfiguration config)
        {
            _repository = repository;
            _config = config;
            _unitofWork = unitofWork;
        }

        public string TESTAPI()
        {
            return "API IS RUNNING";
        }

        // GET api/<SportEventController>/5
        [HttpGet("{id}")]
        public SportsEventModel GetSportsEventByID(string id)
        {
            SportsRepository sportsRepository = new SportsRepository(_repository, _unitofWork, _config);

            var result = sportsRepository.SearchEventByID(id);

            return  result;
        }

        public string LoadJsonFile()
        {
            SportsRepository sportsRepository = new SportsRepository(_repository, _unitofWork, _config);
            List<SportsEventModel> results = new List<SportsEventModel>();
            string _filePath = @"C:\Users\joseph.mcilmurray\source\repos\WebAPI\SportsEventAPI\json\myth.json";
            TextReader tr = new StreamReader(_filePath);

            using (StreamReader r = new StreamReader(_filePath))
            {
                string json = r.ReadToEnd();
                results = JsonConvert.DeserializeObject<List<SportsEventModel>>(json);

            }

            sportsRepository.AddRecord(results);


            return "Success";
        }
    }
}
