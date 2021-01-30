using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();


            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "K.Maraş";
            customer.FirstName = "Burak";
            customer.LastName = "Yoksul";
            customer.Id = 1;

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Mahmut",
                LastName = "Gol"
            };

            Console.WriteLine(customer2.LastName);

            Console.WriteLine(customer.FirstName);


            Console.ReadLine();

        }
    }

    
}
