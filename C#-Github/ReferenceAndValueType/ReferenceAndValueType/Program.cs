using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };
            string[] cities2 = new string[] { "Bolu", "Balıkesir", "Bursa" };
            cities2 = cities1;
            cities1[0] = "İstanbul";
            foreach(string city in cities2)
            {
                Console.WriteLine(city);
            }
            Console.ReadLine();
        }
    }
}
