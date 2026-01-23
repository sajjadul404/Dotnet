using System;
class Test
{
    public static void Main(string[] args)
    {  
        char letter;

        Console.Write("Enter any letter:");
        letter = Convert.ToChar(Console.ReadLine());

        if(letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' ||
           letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            Console.WriteLine("The letter is a Vowel.");
        }
        else
        {
            Console.WriteLine("The letter is a Consonant.");
        }
    }
}