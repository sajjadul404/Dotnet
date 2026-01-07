using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
class Test
{
    public static void Main(string[] args)
    {  
    
    double baseLength, hight, TriangleArea;
    Console.WriteLine("Triangle Area Calculator");

    Console.Write("Base: ");
    baseLength = Convert.ToDouble(Console.ReadLine());

    Console.Write("Height: ");
    hight = Convert.ToDouble(Console.ReadLine());

    TriangleArea = (baseLength * hight) / 2;
    Console.WriteLine($"Triangle Area is: {TriangleArea.ToString("F2")}");

    }
}