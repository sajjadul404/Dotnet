using System;
class Test
{
    public static void Main(string[] args)
    {  
    
        Console.Write("Enter a Nulmber:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            Console.WriteLine("Posative Number");
        }
        else if (number < 0)
        {
            Console.WriteLine("Negative Number");
        }
        else
        {
            Console.WriteLine("Zero");



        }
    }
}