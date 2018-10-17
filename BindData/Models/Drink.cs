using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindData.Models
{
    public class Drink
    {
        public int DrinkId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string CoverImage { get; set; }
    }

    public class ManagerDrink
    {
        public static List<Drink> GetDrinks()
        {
            var drinks = new List<Drink>
            {
                new Drink {DrinkId = 1, Name = "Drink_1", Price = "20.000", CoverImage = "Assets/Drinks/1.jpeg"},
                new Drink {DrinkId = 2, Name = "Drink_2", Price = "20.000", CoverImage = "Assets/Drinks/2.jpeg"},
                new Drink {DrinkId = 3, Name = "Drink_3", Price = "20.000", CoverImage = "Assets/Drinks/3.jpeg"},
                new Drink {DrinkId = 4, Name = "Drink_4", Price = "20.000", CoverImage = "Assets/Drinks/4.jpeg"},
                new Drink {DrinkId = 5, Name = "Drink_5", Price = "20.000", CoverImage = "Assets/Drinks/5.jpeg"},
                new Drink {DrinkId = 6, Name = "Drink_6", Price = "20.000", CoverImage = "Assets/Drinks/6.jpeg"},
                new Drink {DrinkId = 7, Name = "Drink_7", Price = "20.000", CoverImage = "Assets/Drinks/7.jpeg"},
                new Drink {DrinkId = 8, Name = "Drink_8", Price = "20.000", CoverImage = "Assets/Drinks/8.jpeg"},
                new Drink {DrinkId = 9, Name = "Drink_9", Price = "20.000", CoverImage = "Assets/Drinks/9.jpeg"},
                new Drink {DrinkId = 10, Name = "Drink_10", Price = "20.000", CoverImage = "Assets/Drinks/10.jpeg"},
                new Drink {DrinkId = 11, Name = "Drink_11", Price = "20.000", CoverImage = "Assets/Drinks/11.jpeg"},
                new Drink {DrinkId = 12, Name = "Drink_12", Price = "20.000", CoverImage = "Assets/Drinks/12.jpeg"},
                new Drink {DrinkId = 13, Name = "Drink_13", Price = "20.000", CoverImage = "Assets/Drinks/13.jpeg"},
                new Drink {DrinkId = 14, Name = "Drink_14", Price = "20.000", CoverImage = "Assets/Drinks/14.jpeg"},
                new Drink {DrinkId = 15, Name = "Drink_15", Price = "20.000", CoverImage = "Assets/Drinks/15.jpeg"}
            };

            return drinks;
        }
    }
}
