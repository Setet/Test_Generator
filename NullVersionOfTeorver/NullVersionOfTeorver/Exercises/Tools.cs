using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullVersionOfTeorver.Exercises
{
    public class Tools
    {
        /// <summary>
        /// Сочетание из n по k
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static double Sochetanie(int n, int k)
        {
            int m = n - k;

            if (m > k)
                return Factorial(m, n) / Factorial(k);
            else
                return Factorial(k, n) / Factorial(m);
        }
        /// <summary>
        /// Факториал числа
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static double Factorial(int number)
        {
            double n = 1;

            for (int i = 1; i <= number; i++)
            {
                n *= i;
            }
            return n;
        }
        /// <summary>
        /// Факториал от from до to
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        private static double Factorial(int from, int to)
        {
            double n = 1;

            for (int i = from+1; i <= to; i++)
            {
                n *= i;
            }
            return n;
        }
    }
}
