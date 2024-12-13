// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
        class Program
        {
                static void Main(string[] args)
                {
                        Console.WriteLine("Hello, Welcome!");
                        Console.WriteLine();

                        Console.Write("Enter day of the week:(1 - 7) ");
                        string? dayInput = Console.ReadLine();
                        int dayNum = Convert.ToInt32(dayInput);
                        string day;

                        switch (dayNum)
                        {
                                case 0:
                                case 1: day = "Monday";
                                        break;
                                case 2: day = "Tuesday";
                                        break;
                                case 3: day = "Wednesday";
                                        break;
                                case 4: day = "Thursday";
                                        break;
                                case 5: day = "Friday";
                                        break;
                                case 6: day = "Saturday";
                                        break;
                                case 7: day = "Sunday";
                                        break;
                                default: day = "Invalid!";
                                         break;
                        }
                        Console.WriteLine($"Day: {day}");
                }
        }
}
