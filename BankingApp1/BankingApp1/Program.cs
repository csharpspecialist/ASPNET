using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp1
{
    class Program
    {
        public enum BankChoices
        {
            deposit = 1,
            withdraw,
            viewBalance


        }


        static void Main(string[] args)
        {
            Program p = new Program();
            int realChoice;

            Console.WriteLine("Welcome to the banking app /n What you like to do \n 1. Make a Deposit \n 2. Make a Withdrawal\n 3. View your balance");

            string choice = Console.ReadLine();
            int.TryParse(choice, out realChoice);


            switch ((BankChoices)realChoice)
            {
                case BankChoices.deposit:
                    break;
                case BankChoices.withdraw:
                    break;
                case BankChoices.viewBalance:
                    break;
                default:
                    break;
            }

        }







    }
}
