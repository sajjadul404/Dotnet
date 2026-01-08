using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
class Test
{
    public static void Main(string[] args)
    {  
    
        int number = 20;

        number += 10;
        Console.WriteLine($"{number}");

        number -= 5;
        Console.WriteLine($"{number}");

         number *=2;
         Console.WriteLine($"{number}");

         number /=5;
         Console.WriteLine($"{number}");

         number %=6;
         Console.WriteLine($"{number}");


    }
}