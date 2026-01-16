using System;
class Test
{
    public static void Main(string[] args)
    {  

        Console.Write("Enter a Number1:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a Number2:");
        int number2 = Convert.ToInt32(Console.ReadLine());


        if (number1 < number2)
        {
            Console.WriteLine($"{number1} is large number");
        }
        else if (number2 < number1)
        {
            Console.WriteLine($"{number2} is large number");
        }
        else
        {
            Console.WriteLine("Both numbers are equal");
        }

        
    }
}