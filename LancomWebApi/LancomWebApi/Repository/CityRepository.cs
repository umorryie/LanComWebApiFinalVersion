using CountryWebApis.Model;
using LancomWebApi.Controllers;
using LancomWebApi.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LancomWebApi.Repository
{
    public class CityRepository: ICityRepository
    {
        private DataBaseContext _database;
        private ICountryRepository _countryRepository;

        public CityRepository(DataBaseContext dataBase, ICountryRepository countryRepository)
        {
            _database = dataBase;
            _countryRepository = countryRepository;
        }

        public string CreateCity(CityHelper city)
        {
            if (string.IsNullOrEmpty(city.name) || string.IsNullOrWhiteSpace(city.name))
            {
                return "No city provided.";
            }

            try
            {
                var alreadyExistingCountry = _database.City.ToList<City>().FirstOrDefault(singleCity => singleCity.Name == city.name);

                if (alreadyExistingCountry != null)
                {
                    return "City already exists in data base.";
                }

                Random rnd = new Random();
                var newCity = new City()
                {
                    Name = city.name,
                    CountryId = _countryRepository.GetCountryById(city.coutryId).Id,
                    TemperatureCelsius = rnd.Next(-10, 30),
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

        public List<City> ListCities()
        {
            return _database.City.ToList<City>();
        }
    }
}
