public class MyClass
{
    public static void Main(string[] args)
    {
        while (true)
        {   
            Console.WriteLine($"Enter a number from 1 to 5");
            String input = Console.ReadLine() ?? "";

            input = input.ToLower().Trim();
            if (input == "quit")
            {
                Console.WriteLine("Thanks for using your app Goodbye!");
                break;
            }
            if (int.TryParse(input, out int number))
            {
                Console.WriteLine("Please enter a valaid input");
                continue;
            }

            int square = number * number;
            Console.WriteLine($"The square of {number} is {square}");
        }
        Console.ReadKey();
    }
}