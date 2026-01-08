using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
class Test
{
    public static void Main(string[] args)
    {  
    
    double  Fahreheit, Celsius;
    Console.Write("Fahreheit Temperature : ");
    Celsius = Convert.ToDouble(Console.ReadLine());

    Fahreheit = 1.8*Celsius + 32;
    Console.WriteLine($"Fahreheit Temperature = {Fahreheit.ToString("F2")}");


    }
}