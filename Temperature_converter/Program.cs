using System;
using System.Diagnostics;
using System.Security.Cryptography;
class Test
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Temperature Converter started.");
        Console.WriteLine("Choose 1. Farenheit to Celsius");
        Console.WriteLine("Choose 2. Celsius to Farenheit");
        
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
              Console.WriteLine("Enter Farenheit value:");
                double f = Convert.ToDouble(Console.ReadLine());
                double c = (f - 32) * 5 / 9;
                Console.WriteLine($"{f} Farenheit is {c} Celsius.");
                break;
            case 2:
              Console.WriteLine("Enter Celsius value:");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius} Celsius is {fahrenheit} Farenheit.");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}