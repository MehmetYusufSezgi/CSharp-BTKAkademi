using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string[] students = { "Ahmet", "Mehmet", "Ali" };

            foreach(string student in students)
            {
                Console.WriteLine(student);
            }*/

            string[,] sehirler = new string[4, 2]
            {
                {"İstanbul", "Balıkesir" },
                {"Ankara", "Konya" },
                {"Antalya", "Adana" },
                {"İzmir", "Muğla" }
            };

            for (int i = 0; i <= sehirler.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= sehirler.GetUpperBound(1); j++)
                {
                    Console.WriteLine(sehirler[i,j]);
                }
                Console.WriteLine("****************");
            }

            Console.ReadLine();
        }
    }
}
