using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
class Test
{
    public static void Main(string[] args)
    {  
    
    double Radius, Area;
    Console.WriteLine("Area of Circle Calculator");

    Console.Write("Radius: ");
    Radius = Convert.ToDouble(Console.ReadLine());

    Area = 3.116 * Radius * Radius;
    Console.WriteLine($"Area: {Area.ToString("F2")}");


    }
}