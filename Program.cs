// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] decimalNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.Write("Enter positive one digit decimal to search: ");
            string? searchInput = Console.ReadLine();
            if (string.IsNullOrEmpty(searchInput))
            {
                Console.WriteLine("Please enter a number");
                return;
            }
            bool isNum = int.TryParse(searchInput, out int num);
            if (!isNum || num < 0)
            {
                Console.WriteLine("Please enter positive one digit decimal");
                return;
            }

            int index = Array.IndexOf(decimalNumbers, num);
            if (index == -1)
                Console.WriteLine("Not Found");
            else
                Console.WriteLine($"Digit {num} - Index: {index}");

            int[] numbers = new int[3] { 1, 2, 3 };
            Console.WriteLine($"Array Sum: {numbers.Sum()}");

            Array.Reverse(numbers);
            Console.Write("Reversed Members:");
            foreach (int mem in numbers)
                Console.Write($" {mem}");
            Console.WriteLine();

            Console.Write("Array Members:");
            foreach (int mem in numbers)
                Console.Write($" {mem}");
            Console.WriteLine();

            int[] randos = new int[] { 3, 4, 5, 9, 4, 2 };
            Console.Write("Random Members:");
            foreach (int mem in randos)
                Console.Write($" {mem}");
            Console.WriteLine();

            Array.Sort(randos);
            Console.Write("Sorted Members:");
            foreach (int mem in randos)
                Console.Write($" {mem}");
        }
    }
}
