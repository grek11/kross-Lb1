using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        /// <summary>
        /// Calling the Mean (x, y) library method from ClassLibrary2.dll
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть перше число: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть друге число: ");
            double y = double.Parse(Console.ReadLine());
            //call the Mean calculation method from the library
            double my_mean = ClassLibrary1.Class1.Mean(x, y);
            Console.WriteLine("Середнє геометриче = {0}", my_mean);
            Console.ReadKey();
        }
    }
}
