using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, FİrstName = "Burak", LastName = "Yoksul", Address = "Maraş" });

            Console.ReadLine();

        }
    }
}
