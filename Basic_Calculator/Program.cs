using System;
class Calculator
{
    public static void Main(string[] args)
    {
        Double number1, number2;
        char operation;

        Console.Write("Enter an Operation(+,-,*,/): ");
        operation = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter Number1: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Number2: ");
        number2 = Convert.ToDouble(Console.ReadLine());

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
                if(number2 != 0)
                {
                    Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid Operation");
                break;       
        }

    }
}