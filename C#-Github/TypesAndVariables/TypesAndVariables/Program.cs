    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello world");
            Console.ReadLine();*/
            int number1 = 1000000000;
            long number2 = 100000000000000000;
            short number3 = 10000;
            byte number4 = 255;
            bool condition = true;
            char character = 'A';
            double number5 = 10.5;
            decimal number6 = 10;
            var number7 = 100;
            number7 = 'X';

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Character is {0}", (int)character);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine((int)Days.Sunday);


            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
