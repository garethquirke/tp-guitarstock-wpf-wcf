using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuitarSOA
{
    public class Guitar
    {
        [Key]
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int? Stock { get; set; }
        // handle year of creation so they are not past current year
        public int Year { get; set; }
        public double Price { get; set; }

    }
}