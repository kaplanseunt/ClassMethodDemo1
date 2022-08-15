 using System;

namespace ClassMethodDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.Ad = "Messi";
            customer1.Id = 123;

            Customer customer2 = new Customer();
            customer2.Ad = "Ronaldo";
            customer2.Id = 1234;

            Customer customer3 = new Customer();
            customer3.Ad = "De Bruyne";
            customer3.Id = 1235;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (var customer in customers)
            {
                Console.WriteLine("He is: " + customer.Ad);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add();
            musteriManager.Delete();
        }


        
    }
}
