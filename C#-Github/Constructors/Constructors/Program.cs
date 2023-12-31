﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager(40);
            manager.List();

            Product product = new Product(1, "Mehmet");
            Product product1 = new Product(2, "Yusuf");

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 25;
            Utilities.Validation();

            StaticTester.StaticMethod();
            StaticTester staticTester = new StaticTester();
            staticTester.NormalMethod();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count = 15;

        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {
            
        }

        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }

    class Product
    {
        public Product()
        {
            
        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;

            _name = name;

        }
        public int id { get; set; }
        public string name { get; set;}
    }

    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {

            _logger = logger;

        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added new employee");
        }
    }
    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message sent!", _entity);
        }
    }
    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {
            
        }
        public void Add()
        {
            Console.WriteLine("Added with PersonManager");
            Message();
        }
    }
    static class Teacher
    {
        public static int Number { get; set; }
    }
    static class Utilities
    {
        public static void Validation()
        {
            Console.WriteLine("Validation has been completed.");
        }
    }
    class StaticTester
    {
        public static void StaticMethod()
        {
            Console.WriteLine("StaticMethod works without a class object");
        }
        public void NormalMethod()
        {
            Console.WriteLine("NormalMethod requires a class object");
        }
    }
}
