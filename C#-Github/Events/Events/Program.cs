using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(50);
            Product cellphone = new Product(50);

            harddisk.ProductName = "Hard Disk";
            cellphone.ProductName = "Cellphone";
            cellphone.StockControlEvent += Cellphone_StockControlEvent;

            for (int i = 0; i < 100; i++)
            {
                harddisk.Sell(10);
                cellphone.Sell(10);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static void Cellphone_StockControlEvent()
        {
            Console.WriteLine("!!! CELLPHONE STOCKS GETTING LOW !!!");
        }
    }
}
