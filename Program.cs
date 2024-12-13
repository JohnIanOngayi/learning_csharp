// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
        class Program
        {
                static void Main(string[] args)
                {
                        /**
                         * Print user input
                         * Then repeat in rev
                         */
                        Console.WriteLine("Input Your Text: ");
                        string? userInput = Console.ReadLine();

                        if (string.IsNullOrEmpty(userInput)) return;

                        for (int i = userInput.Length - 1; i >= 0; i--)
                                Console.Write(userInput[i]);
                        Console.Write('\n');
                }
        }
}
