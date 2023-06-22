using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayListMethod();
            //Collections();
            //List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Car", "Araba");
            dictionary.Add("Computer","Bilgisayar");
            dictionary.Add("Book", "Kitap");

            foreach (var i in dictionary) 
            { 
                Console.WriteLine(i);
            }
            Console.WriteLine(dictionary.ContainsKey("Car"));
            Console.ReadLine();
        }
        private static void ArrayListMethod()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add("İzmir");
            cities.Add('X');

            foreach (var i in cities)
            {
                Console.WriteLine(i);
            }
        }
        private static void Collections()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            foreach (var i in cities)
            {
                Console.WriteLine(i);
            }
        }
        private static void List()
        {

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { id = 1, FirstName = "Mehmet" });
            customers.Add(new Customer { id = 2, FirstName = "Yusuf" });

            List<Customer> customers1 = new List<Customer>
            {
                new Customer { id = 3, FirstName = "Zeynep"},
                new Customer { id = 4, FirstName = "Saliha"}
            };
            var customerVariable = new Customer
            {
                id = 5,
                FirstName = "Ahmet"
            };

            customers1.Add(customerVariable);
            customers1.AddRange(new Customer[2]
            {
                new Customer{id = 6, FirstName = "Veli"},
                new Customer{id = 7, FirstName = "Deli"}
            });

            customers1.Insert(0, customerVariable);
            customers1.Remove(customerVariable);
            Console.WriteLine(customers1.Contains(customerVariable));

            //customers1.Clear();

            var lastIndex = customers1.LastIndexOf(customerVariable);
            Console.WriteLine("Last Index : {0}", lastIndex);

            var index = customers1.IndexOf(customerVariable);
            Console.WriteLine("Index : {0}", index);

            foreach (var customer in customers1)
            {
                Console.WriteLine(customer.FirstName);
            }

            var customerAmount = customers1.Count();
            Console.WriteLine("Count : {0}", customerAmount);
        }
    }

    class Customer
    {
        public int id { get; set; }
        public string FirstName { get; set; }
    }
}
