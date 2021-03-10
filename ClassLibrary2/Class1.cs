using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    /// <summary>
    /// Calculation of mathematical functions
    /// </summary>
    public class Class1
    {
        /// <summary>
        /// Sum
        /// </summary>
        /// <param name="x">a real number is the first argument</param>
        /// <param name="n">the number of members of the series is the second argument</param>
        /// <returns>returns the value of the Sum function</returns>
        public static double Sum (double x, int n)
        {
            double summa = 0;
            for (int i = 0; i < n; i++)
            {
                summa = summa + (Math.Pow((-1), i) * Math.Pow(x, (2 * i))) / f(2 * i);
            }
            return summa;
        }
        static double f (int n)
        {
            double tmp = 1;
            for (int i = 1; i <= n; i++)
            {
                tmp = tmp * i;
            }
            return tmp;
        }
    }
}
