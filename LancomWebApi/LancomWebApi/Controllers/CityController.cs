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
    public class CityController : ControllerBase
    {
        private ICityRepository _cityRepository;
        public CityController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        [HttpPost]
        public string CreateCity([FromBody] string city)
        {
            return _cityRepository.CreateCity(city);
        }

        [HttpGet]
        public List<City> ListCities()
        {
            return _cityRepository.ListCities();
        }
    }
}
