namespace SimpleBankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer Cs = new Customer();

            BankAccount BA = new BankAccount(12345, 1000, 1000, 1000);
            BA.Deposit();

        }



    }



}

