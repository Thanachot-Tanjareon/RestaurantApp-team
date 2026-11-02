using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Restaurant
{
    private uint _id;
    private string name;
    private string category;
    private float rating;


    public Restaurant(uint id)
    {
        this._id = id;
    }

    public Restaurant setName(string name)
    {
        this.name = name;
        return this;
    }

    public string getName() { return this.name; }

    public Restaurant setCategory(string category)
    {
        this.category = category;
        return this;
    }

    public string getCategory() { return this.category; }

    public Restaurant setRating(float rating)
    {
        this.rating = rating;
        return this;
    }

    public float getRating() { return this.rating; }
}

class AutoID
{
    static uint id;

    public uint generate()
    {
        id = (uint)id++;
        return id;
    }
}

class TUI
{
    public static readonly TUI instance = new TUI();
    private List<Restaurant> restaurants = new List<Restaurant>();
    private AutoID autoID = new AutoID();


    private TUI() { }

    public void generateUI()
    {
        Restaurant restaurant = new Restaurant(autoID.generate());

        Console.WriteLine("+----- Add a restaurant -----+");

        Console.Write("Enter a name: ");
        restaurant.setName(Console.ReadLine());

        Console.Write("Enter a category: ");
        restaurant.setCategory(Console.ReadLine());

        Console.Write("Enter a rating: ");
        restaurant.setRating(float.Parse(Console.ReadLine()));

        restaurants.Add(restaurant);
    }

    public void showAll()
    {
        foreach (var restaurant in restaurants)
        {
            Console.WriteLine("+------ Restaurant list ------+");
            Console.WriteLine($"Name: {restaurant.getName()}");
            Console.WriteLine($"Catagory: {restaurant.getCategory()}");
            Console.WriteLine($"Rating: {restaurant.getRating()}");
        }
    }
}

namespace work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TUI ui = TUI.instance;
            ui.generateUI();
        }
    }
}
