using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Mehmet Yusuf Sezgi";
            var result = sentence.Length;
            string result2 = sentence;
            sentence = "I have changed my name";
            string newResult2 = sentence;
            bool result3 = sentence.EndsWith("i");
            bool result4 = newResult2.EndsWith("i");
            //Index of gives the first instance of "my"
            //LastIndexOf gives the last instance of it
            int result5 = sentence.IndexOf("my");
            int result6 = sentence.LastIndexOf("my");
            //Returns -1 if wrong
            string result7 = sentence.Insert(0, "Hello, ");
            string result8 = sentence.ToLower();
            string result9 = sentence.ToUpper();
            string result10 = sentence.Replace(" ", "  **  ");
            string result11 = sentence.Remove(3,5);
            Console.WriteLine(result11);

            Console.ReadLine();
        }

        private static void Intro()
        {
            string sehir = "Ankara";
            /*Console.WriteLine(sehir[2]);
            Console.ReadLine();*/

            /*foreach(var harf in sehir)
            {
                Console.WriteLine(harf);
            }
            Console.ReadLine();*/

            string sehir2 = "İstanbul";
            Console.WriteLine(sehir + ", " + sehir2);
            Console.ReadLine();
        }
    }
}
