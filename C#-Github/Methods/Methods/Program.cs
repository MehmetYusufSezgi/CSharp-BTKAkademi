using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Added();
            Added();
            Added();
            var result = Add1(20,30);
            var result2 = Add2(20);
            Console.WriteLine(result);
            Console.WriteLine(result2);*/

            /* number1 = 20;
            int number2 = 60;

            var result3 = Add3(ref number1,number2);
            Console.WriteLine(result3);
            Console.WriteLine(number1);*/

            /*Console.WriteLine(multiply(10, 25));
            Console.WriteLine(multiply(10, 25, 2));*/

            Console.WriteLine(Add4(13, 84, 91));
            Console.ReadLine();
        }

        static void Added()
        {
            Console.WriteLine("Added.");
        }

        static int Add1(int num1, int num2)
        {
            var result = num1 + num2;
            return result;
        }

        static int Add2(int num1, int num2 = 20)
        {
            var result = num1 + num2;
            return result;
        }

        static int Add3(ref int num1, int num2 = 20)
        {
            num1 = 35;
            var result = num1 + num2;
            return result;
        }

        static int multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static int multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        static int Add4(params int[] numbers)
        {
            var result = numbers.Sum();
            return result;
        }
    }
}
