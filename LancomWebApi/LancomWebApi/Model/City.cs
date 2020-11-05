using System;
using Microsoft.OData.Edm;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CountryWebApis.Model
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public int TemperatureCelsius { get; set; }
        public Date Date { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
