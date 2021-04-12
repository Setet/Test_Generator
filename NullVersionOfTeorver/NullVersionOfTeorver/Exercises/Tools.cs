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
            if (number != 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    n *= i;
                }
                return n;
            }
            else return 1;
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

            for (int i = from + 1; i <= to; i++)
            {
                n *= i;
            }
            return n;
        }

        //Я пока думаю, стоит ли так запариваться
        /*
        double Simpson_Parable_Integral(double a, double b, double n)
        {
            double h = (b - a) / n; // вычисляем шаг - h
            double sum = 0;     // сумма, результат вычисления интеграла.
            double x0 = a;      // правая граница подотрезка отрезка [a, b]
            double x1 = a + h;  // левая граница подотрезка отрезка [a, b]

            for (int i = 0; i < n; i++) // в цикле применяем формулу Симпсона
            {
                sum += func(x0) + 4 * func(x0 + h / 2) + func(x1);   //для каждого подотрезка, и складываем все полученные значения в общую сумму.
                x0 += h;    // сдвигаем левую и
                x1 += h;    // правую границу
            }

            return (h / 6) * sum;   // возвращаем сумму умноженную на (h/6)(по формуле), т.к. (h/6) общий множитель который можно вынести за скобки.
        }
        */
    }
}
