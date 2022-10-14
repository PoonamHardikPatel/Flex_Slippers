using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Flex_Slippers.Data;

namespace Flex_Slippers.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Flex_SlippersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Flex_SlippersContext>>()))
            {
                // Look for any Slippers.
                if (context.Slipper.Any())
                {
                    return;   // DB has been seeded
                }

                context.Slipper.AddRange(
                    new Slipper
                    {
                        TypeOfProduct = "Arch Support Slippers",
                        Department = "Women",
                        Price = 10.97M,
                        Size = 1.0M,
                        Width = "Narrow",
                        Material = "Rubber",
                        DescOfProduct = "Slippers have always been known to have a flat bottom. Most of the time, they are not known for supporting your foot and being good for your arches.",
                        Rating = 3,
                        ManufacturingDt = DateTime.Parse("2020-2-12")
                    },

                    new Slipper
                    {
                        TypeOfProduct = "Ballet",
                        Department = "Women",
                        Price = 21.49M,
                        Size = 8.5M,
                        Width = "Narrow",
                        Material = "Rubber",
                        DescOfProduct = "Ballet slippers are designed for women to wear. Typically, these slippers are going to look quite a bit like a ballet shoe.",
                        Rating = 2,
                        ManufacturingDt = DateTime.Parse("2020-5-20")
                    },

                    new Slipper
                    {
                        TypeOfProduct = "Bootie Slippers",
                        Department = "Women",
                        Price = 6.00M,
                        Size = 7.5M,
                        Width = "Narrow",
                        Material = "Fur",
                        DescOfProduct = "The bootie slippers are worn up a little higher than a traditional slipper. Bootie slippers are worn usually during the colder months because they will keep you very warm.",
                        Rating = 4,
                        ManufacturingDt = DateTime.Parse("2021-7-22")
                    },

                    new Slipper
                    {
                        TypeOfProduct = "Clog",
                        Department = "Men",
                        Price = 15.00M,
                        Size = 6.5M,
                        Width = "Narrow",
                        Material = "Fur",
                        DescOfProduct = "A clog slipper is similar to a slip-on that has an exposed back. The clogs traditionally have a bottom that is a little thicker and will hold up if you have to walk around outside.",
                        Rating = 1,
                        ManufacturingDt = DateTime.Parse("2019-9-19")
                    },

                    new Slipper
                    {
                        TypeOfProduct = "Flip Flop",
                        Department = "Men",
                        Price = 25.00M,
                        Size = 5.0M,
                        Width = "Medium",
                        Material = "Nylon",
                        DescOfProduct = "Yes, a flip flop slipper is a real thing. With flip flop slippers, the top of your foot will be exposed, but the bottom of your foot will be protected.",
                        Rating = 3,
                        ManufacturingDt = DateTime.Parse("1992-2-18")
                    },

                    new Slipper
                    {
                        TypeOfProduct = "House Slippers",
                        Department = "Men",
                        Price = 5.45M,
                        Size = 8.0M,
                        Width = "Medium",
                        Material = "Nylon",
                        DescOfProduct = "House slippers can refer to a few different things, but mostly, it is a generic slipper with a very soft sole. The house slippers are built for staying indoors.",
                        Rating = 2,
                        ManufacturingDt = DateTime.Parse("2011-5-10")
                    },

                    new Slipper
                    {
                        TypeOfProduct = "Knitted Booties",
                        Department = "Unisex",
                        Price = 8.99M,
                        Size = 2.5M,
                        Width = "Medium",
                        Material = "Genuine Leather",
                        DescOfProduct = "A knitted bootie is very similar to a bootie except that it is made with crochet or knit-type pattern. You very often see these used for babies and young children, but they work for adults as well.",
                        Rating = 5,
                        ManufacturingDt = DateTime.Parse("2022-4-14")
                    },

                    new Slipper
                    {
                        TypeOfProduct = "Slip-On Slippers",
                        Department = "Unisex",
                        Price = 9.99M,
                        Size = 4.0M,
                        Width = "Medium",
                        Material = "Genuine Leather",
                        DescOfProduct = "A slip-on slipper is one of the most convenient slippers to own. With the slip - on, you can quickly put your foot in and be on your way.",
                        Rating = 2,
                        ManufacturingDt = DateTime.Parse("2015-5-7")
                    },

                    new Slipper
                    {
                        TypeOfProduct = "Moccasins",
                        Department = "Unisex",
                        Price = 12.97M,
                        Size = 7.5M,
                        Width = "Wide",
                        Material = "Polyester",
                        DescOfProduct = "A moccasin is a ladies’ slipper that many women will wear around the house with pajamas or leggings. The nice thing about moccasins is that you can get them in a variety of different materials.",
                        Rating = 4,
                        ManufacturingDt = DateTime.Parse("1999-1-1")
                    },

                    new Slipper
                    {
                        TypeOfProduct = "Novelty Slippers",
                        Department = "Children",
                        Price = 6.79M,
                        Size = 6.5M,
                        Width = "Wide",
                        Material = "Polyester",
                        DescOfProduct = "Novelty slippers are made in many different styles, and they usually have characters or funny patterns on them. The novelty slippers are usually used for fun or as a joke gift.",
                        Rating = 5,
                        ManufacturingDt = DateTime.Parse("2022-6-8")
                    },

                    new Slipper
                    {
                        TypeOfProduct = "Outdoor Slippers",
                        Department = "Children",
                        Price = 3.00M,
                        Size = 5.5M,
                        Width = "Wide",
                        Material = "Cotton",
                        DescOfProduct = "The outdoor slippers have the thickest sole of any of the slippers on our list. These are built for heading outside to get the paper, walk the dog, water the garden, and more.",
                        Rating = 2,
                        ManufacturingDt = DateTime.Parse("2021-3-6")
                    },

                    new Slipper
                    {
                        TypeOfProduct = "Scuff",
                        Department = "Children",
                        Price = 11.97M,
                        Size = 4.5M,
                        Width = "Wide",
                        Material = "Cotton",
                        DescOfProduct = "The scuff slipper is usually a flat slipper with a very rough bottom. The rough bottom is used to ensure a person has traction as they are walking around the home.",
                        Rating = 3,
                        ManufacturingDt = DateTime.Parse("2012-12-16")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
