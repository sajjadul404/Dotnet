using System;
using System.Diagnostics;
using System.Security.Cryptography;
class Test
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your Num:");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine($"{i}: Odd");
            }
            
        }
    }
}