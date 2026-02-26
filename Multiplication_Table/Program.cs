using System;
class Test
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number:");
        int Startnumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a number:");
        int Endnumber = Convert.ToInt32(Console.ReadLine());

        for (int i = Startnumber; i <= Endnumber; i++)
        {
            for(int j=1; j <=10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            Console.WriteLine("-----------------------------");
        }
    }
}