// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
        class Program
        {
                static void Main(string[] args)
                {
                        Console.Write("Enter Your Age: ");
                        string? ageInput = Console.ReadLine();

                        int age;
                        bool success = int.TryParse(ageInput, out age);
                        if (success) Console.WriteLine(age);
                        else Console.WriteLine("Invalid: Age can only be a number");
                }
        }
}
