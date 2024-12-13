// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
        class Program
        {
                /**
                 * Password Checker
                 * Usr enters password twice
                 * Check for empty password inputs
                 * Check if they are same 'Passwords match'
                 *          else 'Passwords do not match'
                 */
                static void Main(string[] args)
                {
                        Console.WriteLine("Password Fetcher");
                        Console.WriteLine("-------------------------");

                        Console.Write("Enter your password: ");
                        string? pass1 = Console.ReadLine();

                        Console.Write("Repeat the password: ");
                        string? pass2 = Console.ReadLine();

                        if (string.IsNullOrEmpty(pass1)
                                        || string.IsNullOrEmpty(pass2))
                        {
                                Console.WriteLine("Please enter a password");
                                return;
                        }
                        if (!pass1.Equals(pass2))
                                Console.WriteLine(@"Passwords don't match");
                        else Console.WriteLine("Success: Password Set!");
                }
        }
}
