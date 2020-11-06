using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountryWebApis.Model;
using LancomWebApi.DataContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LancomWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private DataBaseContext _database;
        public CityController(DataBaseContext dataBase)
        {
            _database = dataBase;
        }

        [HttpPost]
        public string CreateCity()
        {
            try
            {
                var newCity = new City()
                {
                    CountryId = 12,
                    Name = "matej",
                    TemperatureCelsius = 12,
                    Date = new DateTime(),
                    TimeStamp = new DateTime(),
                };
                _database.City.Add(newCity);
                _database.SaveChanges();

                return "City successfully inserted into database.";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpGet]
        public List<City> ListCities()
        {
            return _database.City.ToList<City>();
        }
    }
}
