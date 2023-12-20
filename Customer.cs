using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankingSystem
{
    public class Customer
    {
        public string FullName { get; set; }
        public string City { get; set; }
        public int Pin { get; set; }


       
    }



    public class Bank
    {
        public void WelcomeMenu()
        {
            Console.WriteLine("ATM");
            Console.WriteLine("------------------------");

            Console.WriteLine("Please select from one of the following options:");
            Console.WriteLine("1.   New User");
            Console.WriteLine("2.   Existing User");

            string WelcomeResponse = Console.ReadLine();

            if (!int.TryParse(WelcomeResponse, out int WR))
            {
                Console.WriteLine("Invalid Response");
                
            }

        }


    }
}
