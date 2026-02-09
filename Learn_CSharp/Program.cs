using System;
using System.Diagnostics;
using System.Security.Cryptography;
class Test
{
    public static void Main(string[] args)
    {
        Console.Write("Enter The Start Num:");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter The End Num:");
        int end = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter The diff Num:");
        int diff = Convert.ToInt32(Console.ReadLine());
        for (int i = start; i <= end; i=i+diff)
        {
            Console.WriteLine(i);
        }
    }
}