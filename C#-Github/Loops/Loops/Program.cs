using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            Console.ReadLine();
        }

        private static void DoWhileLoop()
        {
            int number = 0;
            do
            {
                Console.WriteLine(number++);
            } while (number < 100);
            Console.WriteLine("Number is now {0}, in the DoWhileLoop", number);
            Console.ReadLine();
        }

        private static void WhileLoop()
        {
            int number = 0;
            while (number < 100)
            {
                number++;
                Console.WriteLine(number);
            }
            Console.WriteLine("Number is {0}", number);
            Console.ReadLine();
        }
        private static void ForLoop()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("i");
            }
            Console.WriteLine("Finished");
            Console.ReadLine();
        }

        private static void Foreach()
        {
            string[] names = { "Ahmet", "Mehmet", "Yusuf" };
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("These are the names");
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for(int i = 2; i<number; i++)
            {
                if(number%i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
    }
}
