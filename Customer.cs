using System;
using System.Collections.Generic;
using System.Linq;
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
        public int CurrentBalance { get; private set; }
        public int InitialBalance { get; private set; }
        public int FinalBalance { get; private set; }

        public BankAccount(int AccountID, int CurrentBalance, int initialBalance, int finalBalance)
        {
            this.AccountID = AccountID;
            this.CurrentBalance = CurrentBalance;
            this.InitialBalance = initialBalance;
            this.FinalBalance = finalBalance;


        }
        public void Deposit()
        {
            Console.WriteLine("Please enter your deposit amount");


        }
    }
}
