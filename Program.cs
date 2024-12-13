// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
            static void Main(string[] args)
            {
                    int age = 23;
                    Console.WriteLine(age);
                    Console.WriteLine(int.MaxValue);
                    Console.WriteLine(int.MinValue);
                    Console.WriteLine();

                    long bigNumber = 900000000000L;
                    Console.WriteLine(bigNumber);
                    Console.WriteLine(long.MaxValue);
                    Console.WriteLine(long.MinValue);
                    Console.WriteLine();

                    double negative = -44.5D;
                    Console.WriteLine(negative);
                    Console.WriteLine(double.MaxValue);
                    Console.WriteLine(double.MinValue);
                    Console.WriteLine();

                    decimal average = 14.99M;
                    float gpa = 3.5F;
                    Console.WriteLine(average);
                    Console.WriteLine(gpa);
            }
    }
}
