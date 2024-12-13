// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
        class Program
        {
                static void Main(string[] args)
                {
                        /** ASk the  user for the number
                         * Prnit a times table
                         */
                        Console.WriteLine("Multiplications Table");
                        Console.WriteLine("=====================");
                        Console.Write("Enter Number: ");
                        string? numInput = Console.ReadLine();

                        bool success = int.TryParse(numInput, out int num);
                        if (!success || num < 0)
                        {
                                Console.WriteLine("Enter a Valid Number");
                                return;
                        }
                        for (int i = 0; i <= num; i++)
                        {
                                for (int j = 0; j <= num; j++)
                                {
                                        int product = i * j;
                                        Console.Write($" {product:000.}");
                                }
                                Console.WriteLine();
                        }
                }
        }
}
