using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BulidList<string>("Ankara", "İzmir", "Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> resylt2 = utilities.BulidList<Customer>(new Customer { FirstName = "Engin" }, new Customer { FirstName = "Kübra" });

            foreach (var customer in resylt2)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Utilities
    {
        public List<T> BulidList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
    interface IEntity
    {

    }
    class Product : IEntity
    {

    }
    interface IProductDal:IRepository<Product>
    {
    }
    class Customer : IEntity
    {
        public string FirstName { get; set; }
    }
    interface ICustomerDal:IRepository<Customer>
    {
        void Custom();
    }
    interface IRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
