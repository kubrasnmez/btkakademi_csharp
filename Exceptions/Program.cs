using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            //TryCatch();

            Func<int, int, int> add = Topla;

            //Console.WriteLine(Topla(2, 3));
            Console.WriteLine(add(3,5));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2());
            Thread.Sleep(3000); //CPU'dan kaynaklı farklı sayı üretmesi için
            Console.WriteLine(getRandomNumber());
            Console.ReadLine();
        }
        static int Topla(int x, int y)
        {
            return x + y;
        }
        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {

            }
            HandleException(() =>
            {
                Find();
            });
            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Kübra", "Özge", "Ebru" };
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException ("Record not found."); //hata fırlat
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Büşra", "Kübra", "Esra" };
                students[3] = "Ahmet";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                //Genelde kullanıcıya bu şekilde göstermeyiz. Loglama kullanırız.
                //Console.WriteLine(exception.Message);
                Console.WriteLine(exception.InnerException); // daha detaylı hata mesajı

            }
        }
    }
}
