using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo1
{
    class MusteriManager
    {

        public void Add()
        {
            Console.WriteLine("Added...");
        }

        public void Delete()
        {

            Console.WriteLine("Deleted...");
        }
        public void List(Customer customer)
        {
            Console.WriteLine(customer.Ad+" eklendi");
            Console.WriteLine("Listed...");

        }


    }
}
