using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    /// <summary>
    ///Calculation of mathematical functions
    /// </summary>
    public class Class1
    {
        /// <summary>
        /// Sum
        /// </summary>
        /// <param name="eps">first argument of the Sum</param>
        /// <param name="n">second argument of the Sum</param>
        /// <param name="x">third argument of the Sum</param>
        /// <returns>returns the value of the Sum</returns>

        public static double Sum(double eps, int n, double x)
        {
            double Sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Sum = Sum + n * (n + 2) * Math.Pow(x, n);
                if (Math.Abs(Sum) < eps)
                {
                    break;
                }
            }
            return Sum;
        }

        /// <summary>
        /// F
        /// </summary>
        /// <param name="eps">first argument of the F</param>
        /// <param name="n">second argument of the F</param>
        /// <param name="x">third argument of the F</param>
        /// <returns>returns the value of the  F</returns>
        public static double F(double eps, int n, double x)
        {
            double F = (x * (3 - x)) / Math.Pow((1 - x), 2);
            return F;
        }

        /// <summary>
        /// T
        /// </summary>
        /// <param name="Sum">first argument of the T</param>
        /// <param name="F">second argument of the T</param>
        /// <returns>returns the value of the T</returns>
        public static double T(double Sum, double F)
        {
            double T = Math.Abs(Sum - F) / F * 1;
            return T;
        }
    }
}
