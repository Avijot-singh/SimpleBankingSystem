using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SimpleBankingSystem
{
    public class Menu
    {
        public int DepositedAmount { get; set; }
        public int Balance { get; set; }


        public void Depositing()
        {
            int parsedamount;
;            Console.WriteLine("------DEPOSIT------");
            Console.WriteLine("Please enter the amount you would like to deposit");
            string D = Console.ReadLine();

            if (int.TryParse(D, out parsedamount ))
            {
                DepositedAmount = parsedamount;
                Balance += DepositedAmount;
                Console.WriteLine("Your deposit deposited successfully");
                Console.WriteLine($"Your total balance{Balance}");
            }




        }

        public void ViewBalance()
        {
            Console.WriteLine("---------BALANCE---------");
            Console.WriteLine($"your total balance is {Balance}");
        }

        

    }

   
}
