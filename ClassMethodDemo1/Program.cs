 using System;
using System.Collections.Generic;

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
            musteriManager.List(customer1);
            musteriManager.List(customer2);
            musteriManager.List(customer3);
            musteriManager.Delete();



            Console.WriteLine("******************");
            Console.WriteLine("******************");
            Console.WriteLine("******************");

            List<string> names = new List<string> {"Taha","Serdar","Çağatay","Ata","Cem" };
            Console.WriteLine(names[1]);
            Console.WriteLine(names[3]);
            Console.WriteLine(names[2]);
            names.Add("Berkay");
            Console.WriteLine(names[5]);

            MyList<int> numbers = new MyList<int>();    //calisacagin tipi belirtmen lazim.
            numbers.Add(17);
            numbers.Add(34);
            numbers.Add(55);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(numbers);
            //}


            Console.WriteLine("******************");
            Console.WriteLine("******************");
            Console.WriteLine("******************");


            MyDictionary<int, string> dictionaryNames = new MyDictionary<int, string>();
            dictionaryNames.Add(1, "Taha");
            dictionaryNames.Add(2, "Taha");
            dictionaryNames.Add(3, "Taha");
            dictionaryNames.Add(3, "Engin");

            dictionaryNames.ShowList();



        }


        
    }
}
