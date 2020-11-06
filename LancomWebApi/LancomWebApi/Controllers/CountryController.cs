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
    public class CountryController : ControllerBase
    {
        private DataBaseContext _database;
        public CountryController(DataBaseContext dataBase)
        {
            _database = dataBase;
        }
        [HttpPost]
        public string CreateCountries([FromBody] string[] countries )
        {
            try
            {
                foreach(string country in countries.Distinct().ToList())
                {
                    _database.Country.Add(new Country() 
                    { 
                        Name = country
                    });
                }
                _database.SaveChanges();
                
                return "Countries successfully inserted into database.";
            }
            catch (Exception e)
            {
                return @$"Something went wrong. Error: {e.Message}";
            }
        }

        [HttpGet]
        public List<Country> GetCountries()
        {
            return _database.Country.ToList<Country>();
        }
    }
}
