using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
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
        private List<Customer> customers = new List<Customer>();

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

         
        public void AddCustomers(Customer customer)
        {
            customers.Add(customer);

        }
        public void OGMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("------------------------");

            Console.WriteLine("Please select from one of the following options:");
            Console.WriteLine("1.   Check Balance");
            Console.WriteLine("2.   Deposit");
            Console.WriteLine("3.   Withdraw");

            string WelcomeResponse = Console.ReadLine();

            if (int.TryParse(WelcomeResponse, out int WR))
            {



                if (WR == 1)
                {
                    Console.WriteLine("You have selected New User");
                    Customer NewCustomer = new Customer();
                    NewCustomer.Registration();
                    AddCustomers(NewCustomer);
                }
            }



        }


    }
}
