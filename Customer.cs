using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankingSystem
{
    public class Customer
    {
        public string FullName { get; set; }
        public string City { get; set; }
        public int Pin { get; set; }


        public void Registration()
        {
            Console.WriteLine("Registration Page");
            Console.WriteLine("------------------");
            Console.WriteLine("Please enter your FullName");
            FullName = Console.ReadLine();
            Console.WriteLine("Please enter your city name");
            City = Console.ReadLine();
            Console.WriteLine("Please enter your access pin");
            Pin = int.Parse(Console.ReadLine());
        }
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

            if (int.TryParse(WelcomeResponse, out int WR))
            {
               


                if (WR == 1)
                {
                    Console.WriteLine("You have selected New User");
                    Customer NewCustomer = new Customer();
                    NewCustomer.Registration();
                }
            }

            

        }


    }
}
