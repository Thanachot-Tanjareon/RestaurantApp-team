using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Restaurant
{
    public uint id = 0;
    public string name = "";
    public string category = "";
    public float rate = 0;

    public Restaurant(uint id, string name, string category, float rate)
    {
        this.id = id;
        this.name = name;
        this.category = category;
        this.rate = rate;
    }
}

namespace work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Restaurant> restaurantsTest = new List<Restaurant>()
            {
                new Restaurant(1, "Somtum A", "อาหารอีสาน", 4.8f),
                new Restaurant(2, "Noodle B", "ก๋วยเตี๋ยว", 4.2f),
                new Restaurant(3, "Steak C", "สเต๊ก", 4.5f),
                new Restaurant(4, "Pizza D", "อาหารตะวันตก", 3.9f),
                new Restaurant(5, "Shabu E", "ชาบู", 4.9f)
            };

            List<Restaurant> goodRatingTest = restaurantsTest
                .Where(r => r.rate >= 4.5f)
                .ToList();

            Console.WriteLine("===== Good Rating =====");

            foreach (Restaurant foodTest in goodRatingTest)
            {
                Console.WriteLine("ID: " + foodTest.id);
                Console.WriteLine("Name: " + foodTest.name);
                Console.WriteLine("Category: " + foodTest.category);
                Console.WriteLine("Rating: " + foodTest.rate);
            }
        }

    }
}