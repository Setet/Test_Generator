using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullVersionOfTeorver.Exercises
{
    class Exc
    {
        /// <summary>
        /// Решает задачи 1а), 2, 3, 4
        /// n - общее количество изделий ;
        /// k - количество бракованных изделий ;
        /// m - общее количество взятых наугад изделий ;
        /// l - количество бракованных изделий из взятых наугад ;
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <param name="m"></param>
        /// <param name="l"></param>
        /// <returns></returns>
        public static double TestNameExc1 (int n, int k, int m, int l)
        {
            return (Tools.Sochetanie(k, l) * Tools.Sochetanie(n - k, m - l)) / Tools.Sochetanie(n, m);
        }

        /// <summary>
        /// Задача 5  
        /// n - общее количество изделий;
        /// k - количество не бракованых изделий;
        /// с - количество нужных событий;
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static double TestNameExc2 (int n, int k, int c)
        {
            double x = Convert.ToDouble(k) / Convert.ToDouble(n);
            return (Math.Pow(x, c));
        }
    }
}
