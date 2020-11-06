using CountryWebApis.Model;
using LancomWebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LancomWebApi.Repository
{
    public interface ICityRepository
    {
        public string CreateCity(CityHelper city);

        public List<City> ListCities();
    }
}
