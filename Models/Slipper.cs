using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Flex_Slippers.Models
{
    public class Slipper
    {
        public int Id { get; set; }
        public string TypeOfProduct { get; set; }

        public string Department { get; set; }
        public decimal Price { get; set; }

        public decimal Size { get; set; }
        public string Width { get; set; }

        public string Material { get; set; }
        public string DescOfProduct { get; set; }

        [DataType(DataType.Date)]
        public DateTime ManufacturingDt { get; set;  }
    }
}
