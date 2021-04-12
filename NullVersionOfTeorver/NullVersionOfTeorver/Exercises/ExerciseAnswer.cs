using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullVersionOfTeorver.Exercises
{
    class ExerciseAnswer
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


        /// <summary>
        /// Задача 6
        /// x1, x2, x3 - первый, второй и третий параметры
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="x3"></param>
        /// <returns></returns>
        public static double TestNameExc3 (double x1, double x2, double x3)
        {
            return (1 - x1) * (1 - x2) * (1 - x3);
        }


        /// <summary>
        /// Задача 7
        /// p1 и p2 - удачные вероятности
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static double TestNameExc4 (double p1, double p2)
        {
            return (1 - p1) * p2 + (1 - p2) * p1;
        }


        /// <summary>
        /// Задача 8
        /// h1 и h2 - вероятности получения брака на каждом из автоматов
        /// </summary>
        /// <param name="h1"></param>
        /// <param name="h2"></param>
        /// <returns></returns>
        public static double TestNameExc5 (double h1, double h2)
        {
            double q1 = 1 - h1;
            double q2 = 1 - h2;
            // Момент с "вдвое больше" требует дополнительных разъяснений
            double Ph1 = 0.33;
            double Ph2 = 0.66;

            return Ph1 * q1 + Ph2 * q2;
        }


        /// <summary>
        /// Задача 9
        /// h1 и h2 - вероятность получения "хорошей" детали на каждом из автоматов
        /// </summary>
        /// <param name="h1"></param>
        /// <param name="h2"></param>
        /// <returns></returns>
        public static double TestNameExc6 (double h1, double h2)
        {
            double Ph1 = 0.33;
            double Ph2 = 0.66;

            return (Ph1 * h1) / (Ph1 * h1 + Ph2 * h2);
        }


        /// <summary>
        /// Задача 10  
        /// n - взято наугад ;
        /// k - неудачных вариантов ;
        /// p - шанс неудачи
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static double TestNameExc7 (int n, int k, double p)
        {
            double q = 1 - p;
            return Tools.Sochetanie(n, k) * Math.Pow(q, k) * Math.Pow(p, k);
        }
    }
}
