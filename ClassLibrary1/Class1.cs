using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <summary>
    /// Calculation of mathematical functions
    /// </summary>
    public class Class1
    {
        /// <summary>
        /// Mean (x,y)
        /// </summary>
        /// <param name="x">the first number is the first argument</param>
        /// <param name="y">the second number is the second argument</param>
        /// <returns>returns the value of the Mean function</returns>
        public static double Mean(double x, double y)
        {
            double result;
            result = Math.Sqrt(x * y);
            return result;
        }
    }
}
