using CountryWebApis.Model;
using LancomWebApi.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LancomWebApi.Repository
{
    public class CountryRepository: ICountryRepository
    {
        private DataBaseContext _database;

        public CountryRepository(DataBaseContext dataBase)
        {
            _database = dataBase;
        }

        public string CreateCountries(string[] countries)
        {
            if (countries.Length == 0)
            {
                return "No countries provided.";
            }

            try
            {
                var counter = 0;

                foreach (string country in countries.Distinct().ToList())
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

        public List<Country> GetCountries()
        {
            return _database.Country.ToList<Country>();
        }

        public Country GetCountryById(int id)
        {
            var countries = _database.Country.ToList<Country>();
            var requiredCountry = countries.FirstOrDefault(countryId => countryId.Id == id);

            if(requiredCountry == null)
            {
                throw new Exception($"Country with {id} does not exist in database. First add country and then add its city");
            }

            return requiredCountry;
        }
    }
}
