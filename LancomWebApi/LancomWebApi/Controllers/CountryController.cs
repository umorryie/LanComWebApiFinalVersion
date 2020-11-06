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
                var counter = 0;

                foreach(string country in countries.Distinct().ToList())
                {
                    var alreadyExistingCountry = _database.Country.ToList<Country>().FirstOrDefault(neke => neke.Name == country);
                    if (alreadyExistingCountry == null)
                    {
                        counter += 1;
                        _database.Country.Add(new Country()
                        {
                            Name = country
                        });
                    }
                }
                _database.SaveChanges();

                return counter > 0 ? "Countries successfully inserted into database." : "All countries are already in data base";
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
