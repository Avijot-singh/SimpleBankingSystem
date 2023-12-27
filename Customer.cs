using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;   
using MongoDB.Bson;

using MongoDB.Bson.Serialization.Attributes;


namespace SimpleBankingSystem
{
    public class Customer
    {
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
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

        public void InfoMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("------------------------");

            Console.WriteLine("Please select from one of the following options:");
            Console.WriteLine("1.   Check Balance");
            Console.WriteLine("2.   Deposit");
            Console.WriteLine("3.   Withdraw");

            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                

            }
            else if (input == 2)
            {
                Deposit deposit = new Deposit();
                deposit.Depositing();

            }
        }

        

    }



    public class Bank
    {
        private static IMongoCollection<Customer> custm;

        static Bank()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("ATM");
            custm = database.GetCollection<Customer>("Customers");
        }
        

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
                    AddCustomers(NewCustomer);
                    DisplayCustomers();
                }
                else if (WR == 2)
                {
                    ExistingUsers();
                }
            }
            else
            {
                Console.WriteLine("Invalid Input please enter valid input");
            }


        }
        public void AddCustomers(Customer customer)
        {
            custm.InsertOne(customer);

        }


        public void ExistingUsers()
        {


                    Console.WriteLine("You are an existing User");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("--------- Please enter your Access Pin --------");
                    int accessPin = int.Parse(Console.ReadLine());

                    var test = Builders<Customer>.Filter.Eq("Pin", accessPin);

            Customer existingCustomer = custm.Find(test).FirstOrDefault();

            if (existingCustomer != null)
            {
                existingCustomer.InfoMenu();
            }
            else
            {
                Console.WriteLine("invalid Pin");
                        WelcomeMenu();
            }




        }

        public static void DisplayCustomers()
        {
            var customers = custm.Find(c => true).ToList();
            Console.WriteLine("List of Customers:");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Name: {customer.FullName}, City: {customer.City}, Pin: {customer.Pin}");
            }
        }
        


    }

    
}
