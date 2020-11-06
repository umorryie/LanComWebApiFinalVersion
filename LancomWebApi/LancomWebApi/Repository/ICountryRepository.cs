using CountryWebApis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LancomWebApi.Repository
{
    public interface ICountryRepository
    {
        public string CreateCountries(string[] countries);

        public List<Country> GetCountries();

        public Country GetCountryById(int id);
    }
}
