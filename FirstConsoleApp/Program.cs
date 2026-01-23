using System;
class Test
{
    public static void Main(string[] args)
    {  
        char letter;

        Console.Write("Enter any letter:");
        letter = Convert.ToChar(Console.ReadLine());

        if(letter >= 'A' && letter <= 'Z')
        {
            Console.WriteLine($"{letter} is Capital Letter");
        }
        else if(letter >= 'a' && letter <= 'z')
        {
            Console.WriteLine($"{letter} is Small Letter");
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}