using System;
class Test
{
    public static void Main(string[] args)
    {  
        int number1 = 10;
        int number2 = 3;

        int sum = number1 + number2;
        Console.WriteLine("sum : " + sum);

        int Sub = number1 - number2;
        Console.WriteLine("Sub : " + Sub);

        int Mul = number1 * number2;
        Console.WriteLine("Mul : " + Mul);

        double Div = (double)number1 / number2;
        Console.WriteLine("Div : " + Div.ToString("F2"));

        int Mod = number1 % number2;
        Console.WriteLine("Mod : " + Mod);

    }
}