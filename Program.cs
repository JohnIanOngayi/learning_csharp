// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
        class Program
        {
                static void Main(string[] args)
                {
                        string message = "C# is awesome!";

                        for (int i = 0; i < message.Length; i++) Console.Write(message[i]);
                        Console.Write('\n');

                       Console.WriteLine(message.Contains('i'));
                }
        }
}
