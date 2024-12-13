// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
        class Program
        {
                static void Main(string[] args)
                {
                        Console.Write("How many prints: ");
                        string? countInput = Console.ReadLine();

                        int count = Convert.ToInt32(countInput);

                        if (count <= 0)
                        {
                                Console.WriteLine("Please enter a positive integer");
                                return;
                        }
                        for (int i = 1; i <= count; i++)
                        {
                            Console.WriteLine($"Print: {i}");
                        }
                }
        }
}
