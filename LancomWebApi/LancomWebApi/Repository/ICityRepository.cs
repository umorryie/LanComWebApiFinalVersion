using CountryWebApis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LancomWebApi.Repository
{
    public interface ICityRepository
    {
        public string CreateCity(string city);

        public List<City> ListCities();
    }
}
