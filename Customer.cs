using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankingSystem
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }


    }

    public class BankAccount : Customer
    {
        public int AccountID { get; private set; }
        public decimal CurrentBalance { get; private set; }
        public decimal InitialBalance { get; private set; }
        public decimal FinalBalance { get; private set; }

        public BankAccount(int AccountID, int CurrentBalance, int initialBalance, int finalBalance)
        {
            this.AccountID = AccountID;
            this.CurrentBalance = CurrentBalance;
            this.InitialBalance = initialBalance;
            this.FinalBalance = finalBalance;


        }

      
        public void Deposit()
        {

            Console.WriteLine("Please enter your AccountID");
            string accountID = Console.ReadLine();
            if (int.TryParse(accountID, out int ACCID) && (ACCID == AccountID))
            {
                Console.WriteLine($"The account ID you have entered is {ACCID}");


                Console.WriteLine("Please enter your Deposit amount");
                string Dep = Console.ReadLine();

                if (int.TryParse(Dep, out int Deposit))
                {
                    Console.WriteLine($"Depositing {Deposit}");
                    FinalBalance += Deposit;

                }
                else
                {
                    Console.WriteLine("Invalid amount");
                }
            }
            else
            {
                Console.WriteLine("Invalid accountID");
            }

            Console.WriteLine($"Your final balance being {FinalBalance}");

          
        }






        
    }

}

