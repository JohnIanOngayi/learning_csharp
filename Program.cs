// See https://aka.ms/new-console-template for more information
using System.Globalization;
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
                        Console.WriteLine(negativeMoney);

                        // Get my currency
                        Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));

                        // Set the currency
                        Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
                        Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                        Console.WriteLine(negativeMoney.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));
                }
        }
}
