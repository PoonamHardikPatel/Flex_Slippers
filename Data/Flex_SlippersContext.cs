using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Flex_Slippers.Models;

namespace Flex_Slippers.Data
{
    public class Flex_SlippersContext : DbContext
    {
        public Flex_SlippersContext (DbContextOptions<Flex_SlippersContext> options)
            : base(options)
        {

        }
         
        public DbSet<Slipper> Slipper { get; set; }
    }
}
