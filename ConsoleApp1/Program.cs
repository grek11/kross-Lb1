using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// Call the library method Sum with Class1
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть значення eps:");
            double eps = double.Parse(Console.ReadLine());

            Console.WriteLine("Введiть значення х:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введiть кiлькiсть членiв ряду:");
            int n = int.Parse(Console.ReadLine());

            double Sum = ClassLibrary3.Class1.Sum(eps, n, x);
            double F = ClassLibrary3.Class1.F(eps, n, x);
            double t = ClassLibrary3.Class1.T(Sum, F);

            Console.WriteLine("Сума ряду = {0}, точне значення функцiї для х = {1}, помилка обчислень = {2}", Sum, F, t);
            Console.ReadKey();
        }
    }
}
