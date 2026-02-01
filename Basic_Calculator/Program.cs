using System;
class Calculator
{
    public static void Main(string[] args)
    {
        int number1, number2;
        char operation;

        Console.Write("Enter an Operation: ");
        operation = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter Number1: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Number2: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case '+':
                Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                break;
            case '-':
                Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
                break;
            case '*':
                Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
                break;
            case '/':   
                Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
                break;
            default:
                Console.WriteLine("Invalid Operation");
                break;

                
        }

    }
}