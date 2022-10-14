using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flex_Slippers.Models
{
    public class Slipper
    {
        public int Id { get; set; }


        [Display(Name = "Type of Slippers")]
        public string TypeOfProduct { get; set; }


        public string Department { get; set; }


        [Column(TypeName = "decimal(20, 2)")]
        public decimal Price { get; set; }

        public decimal Size { get; set; }
        
        
        public string Width { get; set; }

        
        public string Material { get; set; }


        [Display(Name = "Description of Slipper")]
        public string DescOfProduct { get; set; }


        [Display(Name = "Manufacturing Date")]
        [DataType(DataType.Date)]
        public DateTime ManufacturingDt { get; set;  }
    }
}
