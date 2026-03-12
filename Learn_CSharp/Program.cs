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
    public static void Main(string[] args)
    {
        Messege("Welcome to Calculator");
        int number1, number2, result;
       
        number1 = 10;
        number2 = 20;
        Add(number1, number2);
        Sub(number1, number2);

        number1 = 50;
        number2 = 20;
        Add(number1, number2);
        Sub(number1, number2);

    }
}