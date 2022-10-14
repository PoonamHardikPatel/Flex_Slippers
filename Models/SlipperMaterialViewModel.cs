using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Flex_Slippers.Models
{
    public class SlipperMaterialViewModel
    {
        public List<Slipper> Slippers { get; set; }
        public SelectList Materials { get; set; }
        public string SlipperMaterial { get; set; }
        public string SearchString { get; set; }
    }
}
