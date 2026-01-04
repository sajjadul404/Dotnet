using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
class Test
{
    public static void Main(string[] args)
    {  
        int number1,number2,number3;
        double average;

        Console.Write("number1 = ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("number2 = ");
        number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("number3 = ");
        number3 = Convert.ToInt32(Console.ReadLine());

        int Sum = number1 + number2 + number3;
        Console.WriteLine($"Sum = {Sum}");

        average = (double)Sum / 3;
        Console.WriteLine($"average = {average.ToString("F2")}");

    }
}