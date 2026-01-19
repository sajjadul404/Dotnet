using System;
class Test
{
    public static void Main(string[] args)
    {  
    
    Console.WriteLine("Enter Year:");
        int year = Convert.ToInt32(Console.ReadLine());

        if(year % 4 == 0)
        {
            Console.WriteLine("{0} is a Leap Year", year);
        }
        else if(year % 100 == 0)
        {
            Console.WriteLine("{0} is not a Leap Year", year);
        }
        else if(year % 400 == 0 && year % 100 == 0)
        {
            Console.WriteLine("{0} is a Leap Year", year);
        }
        else
        {
            Console.WriteLine("{0} is not a Leap Year", year);
        }

    
     Console.Write("Enter your Marks: ");
     double marks = Convert.ToDouble(Console.ReadLine());
    }
}