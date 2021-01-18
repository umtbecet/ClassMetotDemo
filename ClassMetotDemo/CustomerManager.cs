using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("ID : " + customer.Id);
            Console.WriteLine("Name : " + customer.Name);
            Console.WriteLine("Surname : " + customer.Surname);
            Console.WriteLine("Phone Number : " + customer.PhoneNumber);
            
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("ID : " + customer.Id);
            Console.WriteLine("Name : " + customer.Name);
            Console.WriteLine("Surname : " + customer.Surname);
            Console.WriteLine("Phone Number : " + customer.PhoneNumber);
            Console.WriteLine("Deleted Customer");
        }
        public void List(Customer[] customer)
        {
            foreach(var customers in customer)
            {
                Console.WriteLine("ID : " + customers.Id);
                Console.WriteLine("Name : " + customers.Name);
                Console.WriteLine("Surname : " + customers.Surname);
                Console.WriteLine("Phone Number : " + customers.PhoneNumber);

            }
        }
    }
}
