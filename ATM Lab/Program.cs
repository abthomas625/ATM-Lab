namespace ATM_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, and welcome to GC Banking! Will you be registering a new account with us or logging into an existing account?");
            string input = Console.ReadLine().ToLower();

            List<Account> accounts = new List<Account>();
            {
                new Account("Abilena Thomas", "1234");
                new Account("David Smith", "5678");
                new Account("Jane Doe", "2468");
            }

            if(input == "register")
            {
                
            }
            else if(input == "login")
            {
                Console.WriteLine("Enter your name.");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your password.");
                string password = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Input invalid. Enter 'register' or 'login.'");
                return;
            }
        }
    }
}