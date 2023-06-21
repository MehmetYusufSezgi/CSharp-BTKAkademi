using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SQLServer sQLServer = new SQLServer();
            sQLServer.Add();
            MySQL mySQL = new MySQL();
            mySQL.Delete();
            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SQLServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by SQL Code");
            //base.Add();
        }

        public override void Delete()
        {
            Console.WriteLine("Deleted by SQL Code");
            //base.Delete();
        }
    }

    class MySQL : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by MySQL Code");
            //base.Add();
        }

        public override void Delete()
        {
            Console.WriteLine("Deleted by MySQL Code");
            //base.Delete();
        }
    }
}
