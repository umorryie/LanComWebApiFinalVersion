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
        [Route("CreateCountries")]
        public string CreateCountries([FromBody] string[] countries )
        {
            return _countryRepository.CreateCountries(countries);
        }

        [HttpGet]
        [Route("GetCountries")]
        public List<Country> GetCountries()
        {
            return _countryRepository.GetCountries();
        }

        [HttpPost]
        [Route("GetCountryById")]
        public Country GetCountryById([FromBody] int id)
        {
            return _countryRepository.GetCountryById(id);
        }
    }
}
