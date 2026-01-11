using System;
class Test
{
    public static void Main(string[] args)
    {  
    
        int num1 = 15;
        int num2 = 12;
        int result ;

        result = num1 & num2;
        Console.WriteLine($"{ num1} & {num2} = {result}");

        result = num1 | num2;
        Console.WriteLine($"{ num1} | {num2} = {result}");

        result = num1 ^ num2;
        Console.WriteLine($"{ num1} ^ {num2} = {result}");

        }
    }