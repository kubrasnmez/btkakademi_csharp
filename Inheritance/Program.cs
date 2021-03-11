using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        //inheritance interfacelerden önce yazılır
        // classların tek başına anlamı vardır interfacelerin yoktur.
        static void Main(string[] args)
        {
            Person[] persons = new Person[2]
            {
                new Customer{FirstName = "Kubra" },
                new Student{FirstName = "Ozge"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }
    
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Depertmant { get; set; }
    }
}
