using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TryCatch();
            //NewTryCatch();
            //ActionDemo();

            Func<int, int, int> add = Topla;
            Console.WriteLine(add(5,9));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber());
            Thread.Sleep(1000);
            Func<int> getRandomNumberShorter = ()=>new Random().Next(1, 100);
            Console.WriteLine(getRandomNumberShorter());

            Console.WriteLine(Topla(2,6));
            Console.ReadLine();
        }
        static int Topla(int x, int y)
        {
            return x + y;
        }
        private static void NewTryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        private static void ActionDemo()
        {
            HandleException(() =>
            {
                Find();
            });
        }
        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch(RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }
        private static void Find()
        {
            List<string> students = new List<string> { "Mehmet", "Yusuf", "Zeynep" };
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException ("Record not found");
            }
            else
            {
                Console.WriteLine("It works.");
            }
        }

        private static void TryCatch()
        {
            try
            {
                string[] students = new string[3] { "Ahmet", "Mehmet", "Yusuf" };
                students[3] = "Zeynep";
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of bounds");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Yanlış girim");
            }
        }
    }
}
