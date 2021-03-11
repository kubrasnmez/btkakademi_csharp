using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["table"]);
            //Console.WriteLine(dictionary["glass"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));
            Console.WriteLine(dictionary.ContainsValue("bardak"));
            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            //Console.WriteLine(cities.Contains("Sinop"));
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, Name = "Kübra" });

            var customer1 = new Customer
            {
                Id = 2,
                Name = "Esra"
            };
            customers.Add(customer1);
            customers.AddRange(new Customer[2]{
                new Customer{Id = 3, Name = "Busra"},
                new Customer {Id = 4, Name = "Resiyde" }
            });
            //customers.Clear();

            var index = customers.IndexOf(customer1);
            Console.WriteLine("Index : {0} ", index);

            customers.Insert(0, customer1);

            //Listede birden fazla kes olsa da bulduğu ilk değeri siler.
            customers.Remove(customer1);

            customers.RemoveAll(c => c.Name == "Busra");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + " " + customer.Name);
            }
            var count = customers.Count;
            Console.WriteLine("Count : {0}", count);

            Console.WriteLine(customers.Contains(customer1));
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Sinop");
            cities.Add("İstanbul");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
