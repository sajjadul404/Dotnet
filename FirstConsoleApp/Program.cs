using System;
using System.Diagnostics;
using System.Security.Cryptography;
class Test
{
    public static void Main(string[] args)
    {
        object number = 42;
        switch (number)
        {
            case int:
                Console.WriteLine("It's an integer.");
                break;
            case string:
                Console.WriteLine("It's a string.");    
                break;
                case double:
                Console.WriteLine("It's a double.");
                break;
            default:
                Console.WriteLine("It's of an unknown type.");
                break;
        }
    }
}