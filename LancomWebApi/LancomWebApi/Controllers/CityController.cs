using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LancomWebApi.DataContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LancomWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private DataBaseContext _database;
        public CityController(DataBaseContext dataBase)
        {
            _database = dataBase;
        }
        [HttpGet]
        public bool getCountryList()
        {
            return true;
        }
    }
}
