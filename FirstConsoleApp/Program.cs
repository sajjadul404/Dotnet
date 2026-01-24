using System;
using System.Security.Cryptography;
class Test
{
    public static void Main(string[] args)
    {  

        char letter;
        Console.Write("Enter a letter:");
        letter = Convert.ToChar(Console.ReadLine());

        switch (char.ToLower(letter))
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine($"{letter} is a vowel");
                break;
            default:
                if (char.IsLetter(letter))
                {
                    Console.WriteLine($"{letter} is a consonant");
                }
                else
                {
                    Console.WriteLine($"{letter} is not a letter");
                }
                break;
                
        }
    }
}