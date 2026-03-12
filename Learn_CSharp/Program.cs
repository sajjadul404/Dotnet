using System;
using System.Diagnostics;
using System.Security.Cryptography;
class Test
{
    public static void Messege(string text)
    {
        Console.WriteLine(text);
    }
    public static void Add(int number1, int number2)
    {
        int result = number1 + number2;
        Console.WriteLine($"{number1} + {number2} = {result}");
    }
    public static void Sub(int number1, int number2)
    {
        int result = number1 - number2;
        Console.WriteLine($"{number1} - {number2} = {result}");
    }
    public static int Squre(int number)
    {
        return number * number;
        
    }
    public static void Main(string[] args)
    {
        Messege("Welcome to Calculator");
    
        Add(10, 20);
        Sub(50, 20);

        Add(80, 20);
        Sub(80, 20);

        int result = Squre(5);
        Console .WriteLine($"Squre of 5 is {result}");
        Messege("Thank you");
    }
}