using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
class Test
{
    public static void Main(string[] args)
    {  
    
    double  Fahreheit, Celsius;
    Console.Write("Fahreheit Temperature : ");
    Fahreheit = Convert.ToDouble(Console.ReadLine());

    Celsius = (Fahreheit - 32) * 5 / 9;
    Console.WriteLine($"Celsius Temperature = {Celsius.ToString("F2")}");


    }
}