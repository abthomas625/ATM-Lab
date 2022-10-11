using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Lab
{
    public class ATM
    {
        public List<Account> Accounts { get; set; }
        public Account currentAccount { get; set; }

        public ATM(List<Account> accounts)
        {
            this.Accounts = accounts;
        }
        public ATM()
        {
            Accounts = new List<Account>();
        }
        public void Register()/*string name, string password*/
        {
            Console.WriteLine("Enter your name.");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your password.");
            string password = Console.ReadLine();

            Account a = new Account(name, password);
            Accounts.Add(a);
        }
        public void Login()
        {

        }

        public void Deposit(string name)
        {
            Console.WriteLine("How much would you like to withdraw?");
            double deposit = double.Parse(Console.ReadLine());
            if (Accounts.Where(a => a.Username == name).Count() > 0)
            {
                Account accounts = Accounts.Where(a => a.Username == name).First();
                accounts.Balance += deposit;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Account not found");
            }
        }
        public void Withdraw(string name, double balance)
        {            
            Console.WriteLine("How much would you like to withdraw?");
            double withdraw = double.Parse(Console.ReadLine());

            if (Accounts.Where(a => a.Username == name).Count() > 0)
            {
                Account accounts = Accounts.Where(a => a.Username == name).First();
                if (withdraw > balance)
                {
                    Console.WriteLine("Insufficient funds");
                }
                else
                {
                    accounts.Balance -= withdraw;
                }                
            }
            else
            {
                Console.WriteLine("Account not found");
            }
        }
    }
}
