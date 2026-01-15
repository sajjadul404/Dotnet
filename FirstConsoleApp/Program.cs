using System;
class Test
{
    public static void Main(string[] args)
    {  
    
        Console.Write("Enter a Nulmber:");
        int number = Convert.ToInt32(Console.ReadLine());


        if (number % 2 == 0)
        {
            Console.WriteLine("The number is Even");
        }
        else
        {
            Console.WriteLine("The number is Odd");
        }
        
    }
}