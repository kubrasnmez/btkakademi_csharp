using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.Add();
            customerManager.List();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product1 = new Product(2, "Telefon");

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;
            Utilities.Validate();

            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();

            Console.ReadLine();
        }
        
    }
    class CustomerManager
    {
        //field
        private int _count; 
        public CustomerManager(int count)
        {
            _count = count;
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items",_count);
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
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Log to Database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Log to file");
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
            Console.WriteLine("Added");
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
            Console.WriteLine("{0} message", _entity);
        }
    }
    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }
    //static nesnelerde instance oluşturulmaz.
    //Aynı nesne tüm kullanıcılara iletilir.
    static class Teacher
    {
        //Hepsinin static bildirgesi olmalıdır.
        public static int Number { get; set; }
    }
    static class Utilities
    {
        static Utilities()
        {
            //Mutlaka çalışmasını istediğimiz kod
        }
        public static void Validate() //Doğrulama
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        //içerisinde static veya static olmayan barındırabilir.
        public static void DoSomething() //Doğrulama
        {
            Console.WriteLine("Done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done2");
        }
    }
}
