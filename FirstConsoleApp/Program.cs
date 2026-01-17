using System;
class Test
{
    public static void Main(string[] args)
    {  
    
     Console.Write("Enter your Marks: ");
     double marks = Convert.ToDouble(Console.ReadLine());


     if (marks >= 0 && marks <= 100)
        {
            if (marks >= 90)
            {
                Console.WriteLine ("A+");
            }
            else if (marks >= 80)
            {
                Console.WriteLine ("A");
            }
            else if (marks >= 70)
            {
                Console.WriteLine ("B+");
            }
            else if (marks >= 60)
            {
                Console.WriteLine ("B");
            }
            else if (marks >= 50)
            {
                Console.WriteLine ("C+");
            }
            else if (marks >= 40)
            {
                Console.WriteLine ("C");
            }
            else if (marks >= 33)
            {
                Console.WriteLine ("D");
            }
            else
            {
                Console.WriteLine ("F");
            }
        } 
        else
        {
            Console.WriteLine($"{marks} Invalid Marks");
        }
        
  
    }
}