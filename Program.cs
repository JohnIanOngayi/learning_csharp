// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        /**
         * Fetch two integers from user (num, count)
         * Create int array that contains first <count> multiples of <num>
         * Print the array
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple Generator\n");
            Console.Write("no. to generate multiples for: ");
            string? numInput = Console.ReadLine();
            bool numIsNum = int.TryParse(numInput, out int num);
            if (!numIsNum)
            {
                Console.WriteLine("Please Enter Valid Integer!");
                return;
            }

            Console.Write("count of multiples to generate: ");
            string? countInput = Console.ReadLine();
            bool countIsNum = int.TryParse(countInput, out int count);
            if (!countIsNum)
            {
                Console.WriteLine("Please Enter Valid Integer!");
                return;
            }

            int[] multiples = new int[count];
            for (int i = 0; i < count; i++)
                multiples[i] = num * (i + 1);

            foreach (var item in multiples)
                Console.WriteLine(item);
        }
    }
}
