using System;
using System.Security.Cryptography;
class Test
{
    public static void Main(string[] args)
    {  

       Console.Write("Enter a day of weak : ");
       string day = Console.ReadLine();

        switch (day.ToLower())
        {
            case "monday":
            case "tuesday":
            case "wednesday":
            case "thursday":
            case "friday":
            Console.WriteLine("It's a weekday.");
            break;
            case "saturday":
            case "sunday":
            Console.WriteLine("It's a weekend.");
            break;
            default:
            Console.WriteLine("Invalid day entered.");
            break; 
        }
                
        
    }
}