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
            List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5f),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6f),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7f),
                new Restaurant(4, "Huguosi Snacks", "Snacks", 4.2f),
                new Restaurant(5, "Haidilao Hot Pot", "Hot Pot", 4.8f)
            };


            foreach (var restaurant in restaurants)
            {
                Console.WriteLine($"ID: {restaurant.id}");
                Console.WriteLine($"Name: {restaurant.name}");
                Console.WriteLine($"Category: {restaurant.category}");
                Console.WriteLine($"Rate: {restaurant.rate}");
                Console.Write("\n");
            }


            Console.WriteLine("Thanachot Tanjareon");
            Console.WriteLine("Thanakorn Kongcharoen");
            Console.WriteLine("Phutawan");


            // ค้นหาร้านที่มีคะแนนสูงสุดและต่ำสุด
            var highestRate = restaurants.Max(r => r.rate);
            var lowestRate = restaurants.Min(r => r.rate);

            var topRestaurants = restaurants.Where(r => r.rate == highestRate);
            var bottomRestaurants = restaurants.Where(r => r.rate == lowestRate);

            // แสดงผลร้านที่คะแนนสูงสุด
            Console.WriteLine("--- ร้านที่มีคะแนนสูงสุด ---");
            foreach (var r in topRestaurants)
            {
                Console.WriteLine($"ID: {r.id} | Name: {r.name} | Category: {r.category} | Rate: {r.rate}");
            }

            Console.WriteLine("\n--- ร้านที่มีคะแนนต่ำสุด ---");
            // แสดงผลร้านที่คะแนนต่ำสุด
            foreach (var r in bottomRestaurants)
            {
                Console.WriteLine($"ID: {r.id} | Name: {r.name} | Category: {r.category} | Rate: {r.rate}");
            }













            Console.WriteLine("Gus");
        }
    }
}
