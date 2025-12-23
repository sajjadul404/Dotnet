using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
class Test
{
    public static void Main(string[] args)
    {
          string  name = "Sajjadul Islam";
          double price = 4999.50;
          bool available = true;
          int sold =5;
          string category = "Electronics";


        Console.WriteLine("Name:" + name);
        Console.WriteLine("Price: $" + price);
        Console.WriteLine("Category:" + category);
        Console.WriteLine("Available:" + available);
        Console.WriteLine("Sold:" + sold);

    }
}