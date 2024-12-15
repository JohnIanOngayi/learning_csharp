// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNum = customIntTryParse("25", out int num);
            Console.WriteLine($"Integer 25: {isNum} - Output {num}");

            bool isChar = customIntTryParse("tre", out num);
            Console.WriteLine($"String tre: {isChar} - Output {num}");

            bool isZero = customIntTryParse("0", out num);
            Console.WriteLine($"Integer 0: {isZero} - Output {num}");
        }

        static bool customIntTryParse(string input, out int output)
        {
            try
            {
                int number = Convert.ToInt32(input);
                output = number;
                return true;
            }
            catch (Exception)
            {
                output = 0;
                return false;
            }
        }
    }
}
