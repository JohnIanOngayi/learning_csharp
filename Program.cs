// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
        class Program
        {
                static void Main(string[] args)
                {
                        double value = 1000D / 12.34D;
                        Console.WriteLine($"{value}");     // default
                        Console.WriteLine($"{value:0.0}"); // 1dp
                        Console.WriteLine($"{value:0.#}"); // Remove trailing 0s
                        Console.WriteLine($"{value:0.00}");// 2dp

                        double money = 10D / 3D;
                        double negativeMoney = -10D / 3D;
                        Console.WriteLine(money);

                        // c# can format numeric input to a currency
                        Console.WriteLine($"Currency Money: {money.ToString("C")}");  // Currency default
                        Console.WriteLine($"Currency Money: {money.ToString("C1")}"); // Currency to 1dp
                        Console.WriteLine($"Currency Money: {money.ToString("C2")}"); // Currency to 2dp

                        // c# will even know to put negative sign before symbol
                        Console.WriteLine($"Negative Money: {negativeMoney.ToString("C")}");
                }
        }
}
