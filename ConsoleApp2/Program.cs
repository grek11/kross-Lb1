using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        /// <summary>
        /// Calling the Sum (x, n) library method from ClassLibrary2.dll
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть дiйсне число х");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введiть кiлькiсть членiв ряду n");
            int n = int.Parse(Console.ReadLine());
            //call the Sum calculation method from the library
            double my_summa = ClassLibrary2.Class1.Sum(x, n);
            Console.WriteLine("Сума членiв ряду: {0}", my_summa);
            Console.ReadKey();
        }
    }
}
