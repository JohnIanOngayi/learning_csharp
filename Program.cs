// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                { 1, "Leonidas" },
                { 2, "Leonidas II" },
                { 3, "Leonidas III" },
            };

            foreach (KeyValuePair<int, string> item in names)
                Console.WriteLine($"{item.Key} - {item.Value}");

            Console.WriteLine("Try and find ID in Dict: ");
            Console.WriteLine("Which ID Do You Want? ");
            string? idInput = Console.ReadLine();

            bool isNum = int.TryParse(idInput, out int id);
            if (!isNum || id < 0)
            {
                Console.WriteLine("Please Enter A Valid ID");
                return;
            }
            else
            {
                if (names.TryGetValue(id, out string? name))
                    Console.WriteLine($"ID {id} - {name}");
                else
                    Console.WriteLine($"ID {id} no exista!");
            }
        }
    }
}
