using CountryWebApis.Model;
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

        public CityRepository(DataBaseContext dataBase)
        {
            _database = dataBase;
        }

        public string CreateCity(string city)
        {
            if (string.IsNullOrEmpty(city) || string.IsNullOrWhiteSpace(city))
            {
                return "No city provided.";
            }

            try
            {
                var alreadyExistingCountry = _database.City.ToList<City>().FirstOrDefault(neke => neke.Name == city);

                if (alreadyExistingCountry != null)
                {
                    return "City already exists in data base.";
                }

                Random rnd = new Random();
                var newCity = new City()
                {
                    Name = city,
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
