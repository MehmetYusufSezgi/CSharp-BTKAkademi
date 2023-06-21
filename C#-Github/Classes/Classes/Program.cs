using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            ProductManager productManager = new ProductManager();
            customerManager.Add();
            productManager.Remove(); 
            Console.ReadLine();

            Customer customer = new Customer();
            customer.FirstName = "Mehmet";
            customer.ID = 1;
            customer.LastName = "SEZGİ";
            customer.City = "Ankara";

            Customer customer2 = new Customer()
            {
                ID = 2, FirstName = "Yusuf", LastName = "AYGAR", City = "İstanbul"
            };
            Console.WriteLine(customer2.LastName);
            Console.ReadLine();
        }
    }
    
}
