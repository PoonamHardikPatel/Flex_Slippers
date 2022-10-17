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

        [StringLength(40, MinimumLength = 5)]
        [Required]
        [Display(Name = "Type of Slippers")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string TypeOfProduct { get; set; }

        [StringLength(10)]
        [Required]
        public string Department { get; set; }


        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        [Column(TypeName = "decimal(18, 2)")]
        public decimal Size { get; set; }


        [StringLength(10)]
        [Required]
        public string Width { get; set; }


        [StringLength(20)]
        [Required]
        public string Material { get; set; }


        [Display(Name = "Description of Slipper")]
        [Required]
        [StringLength(500)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string DescOfProduct { get; set; }


        [Range(1, 5)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Rating { get; set; }


        [Display(Name = "Manufacturing Date")]
        [DataType(DataType.Date)]
        public DateTime ManufacturingDt { get; set;  }
    }
}
