using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CountryWebApis.Model
{
    [Table("Country", Schema = "dbo")]
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
