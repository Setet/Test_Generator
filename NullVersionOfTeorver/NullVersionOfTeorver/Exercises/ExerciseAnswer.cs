using System;

namespace NullVersionOfTeorver.Exercises
{
    //Дисклеймер

    //Данный класс является набором методов, для решения определенных задач
    //По-идее, у вас не должно быть доступа к этому классу. Т.к. он нужен только для класса генережки, но С# не дает мне его "запротектить"
    //Может в будущем разберусь с этой проблемой. Либо просто перекину его в класс с генережкой, и решу кек с инкапсуляцией
    public class ExerciseAnswer : Tools
    {
        /// <summary>
        /// Решает задачу 1а)
        /// n - общее количество изделий ;
        /// k - количество бракованных изделий ;
        /// m - общее количество взятых наугад изделий ;
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        protected static double AnswerForExc1a (int n, int k, int m)
        {
            return Tools.Sochetanie(n - k, m) / Tools.Sochetanie(n, m);
        }

        /// <summary>
        /// Решает задачу 1b)
        /// n - общее количество изделий ;
        /// k - количество бракованных изделий ;
        /// m - общее количество взятых наугад изделий ;
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        protected static double AnswerForExc1b(int n, int k, int m)
        {
            return Tools.Sochetanie(k, m) / Tools.Sochetanie(n, m);
        }

        /// <summary>
        /// Решает задачу 1c)
        /// n - общее количество изделий ;
        /// k - количество бракованных изделий ;
        /// m - общее количество взятых наугад изделий ;
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        protected static double AnswerForExc1c(int n, int k, int m)
        {
            return (Tools.Sochetanie(k,m)+Tools.Sochetanie(n-k,1)*Tools.Sochetanie(k,1)) 
                               / Tools.Sochetanie(n, m);
        }


        /// <summary>
        /// Решает задачу 2
        /// n - общее количество изделий 
        /// k - количество бракованных изделий
        /// m - общее количество взятых наугад изделий
        /// l - количество бракованных изделий из взятых наугад
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <param name="m"></param>
        /// <param name="l"></param>
        /// <returns></returns>
        protected static double AnswerForExc2(int n, int k, int m, int l)
        {
            return Tools.Sochetanie(k, l)*Tools.Sochetanie(n-k,m-l) / Tools.Sochetanie(n, m);
        }


        /// <summary>
        /// Решает задачу 3
        /// n - общее число карт
        /// k - количество карт, взятых наугад
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        protected static double AnswerForExc3(int n, int k)
        {
            return 1-Tools.Sochetanie(4, 0) * Tools.Sochetanie(n - k, k) / Tools.Sochetanie(n, k);
        }


        /// <summary>
        /// Решает задачу 4
        /// n - общее количество изделий 
        /// k - количество бракованных изделий
        /// m - общее количество взятых наугад изделий
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        protected static double AnswerForExc4(int n, int k, int m)
        {
            return Tools.Sochetanie(k, m/2) * Tools.Sochetanie(n - k, m/2) / Tools.Sochetanie(n, m);
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
        protected static double AnswerForExc5(int n, int k, int m)
        {
            double x = (Convert.ToDouble(n) - Convert.ToDouble(k)) / Convert.ToDouble(n);
            return 1 - (Math.Pow(x, m));
        }


        /// <summary>
        /// Задача 6
        /// x1, x2, x3 - первый, второй и третий параметры
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="x3"></param>
        /// <returns></returns>
        protected static double AnswerForExc6(double x1, double x2, double x3)
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
        protected static double AnswerForExc7(double p1, double p2)
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
        protected static double AnswerForExc8(double h1, double h2)
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
        /// b1 и b2 - вероятность получения "хорошей" детали на каждом из автоматов
        /// </summary>
        /// <param name="h1"></param>
        /// <param name="h2"></param>
        /// <returns></returns>
        protected static double AnswerForExc9(double b1, double b2)
        {
            double Ph1 = 0.33;
            double Ph2 = 0.66;

            return (Ph1 * b1) / (Ph1 * b1 + Ph2 * b2);
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
        protected static double AnswerForExc10(int n, int k, double p)
        {
            double q = 1 - p;
            return Tools.Sochetanie(n, k) * Math.Pow(q, k) * Math.Pow(p, k);
        }

        protected static double FinderM(string[,] Matrix)
        {
            int n = Matrix.Length;

            double Result = 0;

            for (int i = 0; i < n / 2; i++)
                Result += Convert.ToDouble(Matrix[0, i]) * Convert.ToDouble(Matrix[1, i]);

            return Result;
        }
        protected static double FinderD(string[,] Matrix)
        {
            int n = Matrix.Length;

            double Result = 0;

            for (int i = 0; i < n / 2; i++)
                Result += Math.Pow(Convert.ToDouble(Matrix[0, i]), 2) * Convert.ToDouble(Matrix[1, i]);

            Result -= Math.Pow(FinderM(Matrix), 2);

            return Result;
        }
        protected static double FinderS(string[,] Matrix)
        {
            return Math.Sqrt(FinderD(Matrix));
        }

        protected static double AnswerForExc15(int N, int K, double p)
        {
            double n = Convert.ToDouble(N);
            double k = Convert.ToDouble(K);

            double x = (k - n * p) / Math.Sqrt(n * p * (1 - p));

            double F = Math.Exp(-Math.Pow(x, 2) / 2) / Math.Sqrt(2 * Math.PI);

            return F / Math.Sqrt(n * p * (1 - p));
        }

        protected static double AnswerForExc16(double a, double sig, double x1, double x2)
        {
            return Laplase((x2 - a) / Math.Sqrt(sig)) - Laplase((x1 - a) / Math.Sqrt(sig));
        }
        private static double Laplase(double x)
        {
            return (1 / Math.Sqrt(2 * Math.PI)) * Simpson_Parable_Integral(0, x);
        }
        static double funcLaplase(double x)
        {
            return Math.Exp(-Math.Pow(x, 2) / 2);
        }
        private static double Simpson_Parable_Integral(double a, double b)
        {
            double h = (b - a) / 1000; // вычисляем шаг - h
            double sum = 0;     // сумма, результат вычисления интеграла.
            double x0 = a;      // правая граница подотрезка отрезка [a, b]
            double x1 = a + h;  // левая граница подотрезка отрезка [a, b]

            for (int i = 0; i < 1000; i++) // в цикле применяем формулу Симпсона
            {
                sum += funcLaplase(x0) + 4 * funcLaplase(x0 + h / 2) + funcLaplase(x1);   //для каждого подотрезка, и складываем все полученные значения в общую сумму.
                x0 += h;    // сдвигаем левую и
                x1 += h;    // правую границу
            }

            return (h / 6) * sum;   // возвращаем сумму умноженную на (h/6)(по формуле), т.к. (h/6) общий множитель который можно вынести за скобки.
        }
    }
}
