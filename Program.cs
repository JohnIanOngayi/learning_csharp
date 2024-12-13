// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
            static void Main(string[] args)
            {
                    string name = "Aba";
                    Console.WriteLine(name);

                    char letter = 'A';
                    Console.WriteLine(letter);

                    string textAge = "23";
                    int age = Convert.ToInt32(textAge);
                    Console.WriteLine(age);

                    string textBigNumber = "9000000000000000000";
                    long bigNumber = Convert.ToInt64(textBigNumber);
                    Console.WriteLine(bigNumber);

                    string textNegative = "-44.5";
                    double negative = Convert.ToDouble(textNegative);
                    Console.WriteLine(negative);

                    string textPrecision = "5.00001";
                    float precision = Convert.ToSingle(textPrecision);
                    Console.WriteLine(textPrecision);
            }
    }
}
