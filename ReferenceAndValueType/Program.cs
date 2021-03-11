using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            // değer tip
            int number1 = 10;
            int number2 = 20;
            number2 = number1; //10 - değer ataması
            number1 = 30; // atadıktan sonra yapılmasının hiç bir önemi yok 
            Console.WriteLine(number2);

            //referans tip 
            // arrayler referans tiptir

            string[] cities1 = new string[] { "Ankara", "Adana", "Bolu" }; //101
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" }; //102- //101
            cities2 = cities1; // cities 2nin referansı = cities1 referansı
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);

            //referans
            DataTable dataTable = new DataTable(); //DataTable dataTable
            DataTable dataTable1 = new DataTable();
            dataTable = dataTable1;


            Console.ReadLine();
        }
    }
}
