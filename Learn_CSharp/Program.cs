using System;
using System.Diagnostics;
using System.Security.Cryptography;
class Test
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number 1 to 10:");
        int Number = Convert.ToInt32(Console.ReadLine());

        switch (Number)
        {
            case int num when num < 1 && num > 10:
                Console.WriteLine("Number is out of range.");
                break;
                case int num when num % 2 == 0:
                Console.WriteLine("Number is Even.");
                break;
            case int num when num % 2 != 0:
                Console.WriteLine("Number is Odd.");
                break;
            default:
                Console.WriteLine("Invalid Input.");
                break;       
        }
    }
}