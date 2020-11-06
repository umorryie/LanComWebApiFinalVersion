using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountryWebApis.Model;
using LancomWebApi.DataContext;
using LancomWebApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LancomWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private ICountryRepository _countryRepository;
        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        [HttpPost]
        public string CreateCountries([FromBody] string[] countries )
        {
            return _countryRepository.CreateCountries(countries);
        }

        [HttpGet]
        public List<Country> GetCountries()
        {
            return _countryRepository.GetCountries();
        }
    }
}
