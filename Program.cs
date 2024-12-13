// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
            static void Main(string[] args)
            {
                    Console.WriteLine("Hello, Welcome!");

                    Console.Write("Enter Your Name: ");
                    string? name = Console.ReadLine();
                    Console.Write("Enter Your Age: ");
                    string? ageInput = Console.ReadLine();
                    int age = Convert.ToInt32(ageInput);
                    Console.Write($"{name} - {age}");

                    if (age >= 18) Console.WriteLine(" - Entry Granted!");
                    else Console.WriteLine(" - Entry Denied!");
            }
    }
}
