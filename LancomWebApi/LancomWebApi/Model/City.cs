using System;
using Microsoft.OData.Edm;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryWebApis.Model
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        public Country Country { get; set; }
        public int CountryId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int TemperatureCelsius { get; set; }

        public DateTime Date { get; set; }

        public DateTime TimeStamp { get; set; }

    }
}
