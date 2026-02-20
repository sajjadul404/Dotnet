using System;
using System.Diagnostics;
using System.Security.Cryptography;
class Test
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        for (int i=1; i <= number; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine($"Factorial ({number}) =  {fact}");
    }
}