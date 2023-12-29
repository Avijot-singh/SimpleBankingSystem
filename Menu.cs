using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SimpleBankingSystem
{
    public class Menu
    {
        public int DepositedAmount { get; set; }
        public  int Balance { get; set; }


        public void Depositing()
        {
            int DepositAmount;
;            Console.WriteLine("------DEPOSIT------");
             Console.WriteLine("Please enter the amount you would like to deposit");

            if (int.TryParse(Console.ReadLine(), out DepositAmount))
            {
                if (DepositAmount < 0)
                {
                    Console.WriteLine("Insufficient funds");
                }
                else
                {
                Balance += DepositAmount;
                Console.WriteLine("Withdrawal successfully");
                Console.WriteLine($"Your total balance is {Balance}");

                }
            }
            else
            {
                Console.WriteLine("invalid input");
            }



        }

        public void ViewBalance()
        {
            Console.WriteLine("---------BALANCE---------");
            Console.WriteLine($"your total balance is {Balance}");
        }

        public void withdraw()
        {
            int Withdraw_amount;
            Console.WriteLine("-------WITHDRAW----------");
            Console.WriteLine("Please enter the amount you would like to Withdraw");
            

            if (int.TryParse(Console.ReadLine(), out Withdraw_amount))
            {
                if (Withdraw_amount > Balance)
                {
                    Console.WriteLine("Not enough funds!");
                }
                else
                {
                Balance -= Withdraw_amount;
                Console.WriteLine("You have withdraw your amount successfully");
                Console.WriteLine($"Your total balance {Balance}");
                    
                }
                
            }
        }

    }

   
   
}
