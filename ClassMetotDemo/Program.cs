using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "Umut",
                Surname = "Yıldız",
                PhoneNumber = "1112223344"

            };
            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Hasan",
                Surname = "Dal",
                PhoneNumber = "1112223344"

            };
            Customer customer3 = new Customer()
            {
                Id = 3,
                Name = "Ahmet",
                Surname = "Yaşar",
                PhoneNumber = "1112223344"

            };

            Customer[] customers = new Customer[] {customer1,customer2 };
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Delete(customer3);
        }
    }
}
