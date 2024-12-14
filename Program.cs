// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        /**
         * Create two lists
         * Loop from o-20
         *  if no is even add to evenList
         *  if no is odd add to oddList
         *  Print both lists
         */
        static void Main(string[] args)
        {
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                int rem = i % 2;
                if (rem == 0)
                    evenList.Add(i);
                else
                    oddList.Add(i);
            }
            Console.Write("Printing evenList:");
            foreach (var item in evenList)
                Console.Write($" {item}");
            Console.Write("\nPrinting oddList: ");
            foreach (var item in oddList)
                Console.Write($" {item}");
        }
    }
}
