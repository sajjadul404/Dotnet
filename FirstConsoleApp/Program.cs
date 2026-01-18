using System;
class Test
{
    public static void Main(string[] args)
    {  
    
     Console.Write("Enter your Marks: ");
     double marks = Convert.ToDouble(Console.ReadLine());

    char Grade;
     if (marks >= 0 && marks <= 100)
        {
            if (marks >= 90)
            {
                Grade = 'A';
            }
            else if (marks >= 80)
            {
                Grade = 'A';
            }
            else if (marks >= 70)
            {
                Grade = 'B';
            }
            else if (marks >= 60)
            {
                Grade = 'B';
            }
            else if (marks >= 50)
            {
                Grade = 'C';
            }
            else if (marks >= 40)
            {
                Grade = 'C';
            }
            else if (marks >= 33)
            {
                Grade = 'D';
            }
            else
            {
                Grade = 'F';
            }
            Console.WriteLine($"Your Grade is = {Grade}");
        } 
        else
        {
            Console.WriteLine($"{marks} Invalid Marks");
        }
        
    }
}