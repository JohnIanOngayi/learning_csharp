// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
        class Program
        {
                static void Main(string[] args)
                {
                        Console.WriteLine("Fizzbuzz!");
                        Console.WriteLine();

                        Console.Write("Enter The Range: ");
                        string? rangeInput = Console.ReadLine();

                        bool success = int.TryParse(rangeInput, out int range);
                        if (!success || range <= 0)
                        {
                                Console.WriteLine("Invalid: Enter range > 0");
                                return;
                        }

                        for (int num = 1; num <= range; num++)
                        {
                                if (num % 3 == 0 && num % 5 == 0) Console.WriteLine("FizzBuzz");
                                else if (num % 3 == 0) Console.WriteLine("Fizz");
                                else if (num % 5 == 0) Console.WriteLine("Buzz");
                                else Console.WriteLine(num);
                        }
                }
        }
}
