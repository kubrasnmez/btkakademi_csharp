using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            DataBase dataBase = new DataBase();
            dataBase.Add();

            Console.ReadLine();
        }
       
    }
    class DataBase
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
    class SqlServer : DataBase
    {
        public override void Add()
        {
            Console.WriteLine("Added Sql");
            //base.Add();
        }
    }
    class Oracle : DataBase
    {

    }
}
