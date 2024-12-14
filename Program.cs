// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3] { 1, 2, 3 };

            List<int> listNumbers = new List<int>() { 1, 2, 3 };
            foreach (var item in listNumbers)
                Console.WriteLine(item);

            List<int> listNumbers2 = new List<int>(numbers);
            foreach (var item in listNumbers2)
                Console.WriteLine(item);

            Console.WriteLine("Using List Count - since Length attr no exista");
            for (int i = 0; i < listNumbers2.Count; i++)
                Console.WriteLine($"Index {i} - {listNumbers2[i]}");
        }
    }
}
