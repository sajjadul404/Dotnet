using System;
class Test
{
    public static void Main(string[] args)
    {  


        string? studentName;
        int studentAge;
        double studentGpa;
        bool studentRegistered;
        
        Console.Write("Enter your name:");
        studentName = Console.ReadLine();

        Console.Write("Enter your age:");
        studentAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your GPA:");
        studentGpa = Convert.ToDouble(Console.ReadLine());

        Console.Write("Have You already Register:");
        studentRegistered = Convert.ToBoolean(Console.ReadLine());



        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Age: " + studentAge + " years");
        Console.WriteLine ("GPA: " + studentGpa);
        Console.WriteLine ("Registered: " + studentRegistered);

    }
}