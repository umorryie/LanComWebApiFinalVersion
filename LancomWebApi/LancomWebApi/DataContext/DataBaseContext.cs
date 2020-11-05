using CountryWebApis.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LancomWebApi.DataContext
{
    public class DataBaseContext: DbContext
    {
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
    }
}
