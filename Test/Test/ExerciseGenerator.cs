using System;

namespace Test
{
    //Дисклеймер

    //Данный класс является набором методов для генережки задач
    //Большинство методов не нуждаются в начальных аргументах, кроме некоторых
    //На выход у всех методов подается маленький стринговый массив, каждый элемент которого отвечает за определенную переменную в задаче + ответ
    public class ExerciseGenerator : ExerciseAnswer
    {
        Random rnd = new Random();

        /// <summary>
        /// Генератор задания №1. 
        /// На выход поступает стринговый массив из 6 элементов: 1-n, 2-k, 3-m, 4-Результат для подзадачи "a", 5 - для "b", 6 - для "c"
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric1()
        {
            int n = rnd.Next(20, 27);
            int k = rnd.Next(3, 9);
            int m = 2;
            double ResA = ExerciseAnswer.AnswerForExc1a(n, k, m);
            double ResB = ExerciseAnswer.AnswerForExc1b(n, k, m);
            double ResC = ExerciseAnswer.AnswerForExc1c(n, k, m);

            String[] Answer = new string[6]
            { n.ToString(), k.ToString(), m.ToString(), Math.Round(ResA, 3).ToString(),Math.Round(ResB, 3).ToString(),Math.Round(ResC, 3).ToString() };

            return Answer;
        }

        /// <summary>
        /// Генератор задания №2. На выход поступает стринговый массив из 5 элементов: 1-n, 2-k, 3-m, 4-l, 5-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric2()
        {
            int n = rnd.Next(20, 27);
            int k = rnd.Next(5, 9);
            int m = rnd.Next(2, n / 2 - 2);
            int l = rnd.Next(1, m);

            while (l >= k)
            {
                n = rnd.Next(20, 27);
                k = rnd.Next(5, 9);
                m = rnd.Next(2, n / 2 - 2);
                l = rnd.Next(1, m);
            }

            double Res = ExerciseAnswer.AnswerForExc2(n, k, m, l);

            String[] Answer = new string[5]
            { n.ToString(), k.ToString(), m.ToString(), l.ToString(), Math.Round(Res, 3).ToString() };

            return Answer;
        }

        /// <summary>
        /// Генератор задания №3. На выход поступает стринговый массив из 3 элементов: 1-n, 2-k, 3-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric3()
        {
            int c = rnd.Next(1, 5);
            int k = rnd.Next(3, 7);
            int n = 36;

            switch (c)
            {
                case (1):
                    n = 36;
                    break;
                case (2):
                    n = 32;
                    break;
                case (3):
                    n = 28;
                    break;
                case (4):
                    n = 52;
                    break;
                default:
                    break;
            }//Свитч, для выбора альтернатив

            double Res = ExerciseAnswer.AnswerForExc3(n, k);

            String[] Answer = new string[3]
            { n.ToString(), k.ToString(), Math.Round(Res, 3).ToString() };

            return Answer;
        }

        /// <summary>
        /// Генератор задания №4. На выход поступает стринговый массив из 4 элементов: 1-n, 2-k, 3-m, 4-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric4()
        {
            int n = rnd.Next(20, 27);
            int k = rnd.Next(8, n / 2 + 1);

            int c = rnd.Next(1,4);
            int m = 4;

            switch (c)
            {
                case (1):
                    m = 4;
                    break;
                case (2):
                    m = 6;
                    break;
                case (3):
                    m = 8;
                    break;
                default:
                    break;
            }//Свитч, для выбора альтернатив
            double Res = ExerciseAnswer.AnswerForExc4(n, k, m);

            String[] Answer = new string[4]
            { n.ToString(), k.ToString(), m.ToString(), Math.Round(Res, 3).ToString() };

            return Answer;
        }

        /// <summary>
        /// Генератор задания №5. На выход поступает стринговый массив из 4 элементов: 1-n, 2-k, 3-m, 4-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric5()
        {
            int n = rnd.Next(7, 11);
            int k = rnd.Next(3,6);
            int m = rnd.Next(3,6);

            double Res = ExerciseAnswer.AnswerForExc5(n, k, m);

            String[] Answer = new string[4]
            { n.ToString(), k.ToString(), m.ToString(), Math.Round(Res, 3).ToString() };

            return Answer;
        }

        /// <summary>
        /// Генератор задания №6. На выход поступает стринговый массив из 4 элементов: 1-p1, 2-p2, 3-p3, 4-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric6()
        {
            double p1 = rnd.Next(3, 13);
            double p2 = rnd.Next(3, 13);
            double p3 = rnd.Next(3, 13);

            while (p1 == p2) p2 = rnd.Next(3, 13);
            while (p1 == p3 || p2 == p3) p3 = rnd.Next(3, 13);

            p1 /= 100;
            p2 /= 100;
            p3 /= 100;

            double Res = ExerciseAnswer.AnswerForExc6(p1, p2, p3);

            String[] Answer = new string[4]
            { p1.ToString(), p2.ToString(), p3.ToString(), Math.Round(Res, 3).ToString() };

            return Answer;
        }

        /// <summary>
        /// Генератор задания №7. На выход поступает стринговый массив из 3 элементов: 1-p1, 2-p2, 3-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric7()
        {
            double p1 = rnd.Next(1, 5);
            double p2 = rnd.Next(1, 5);

            while (p1 == p2) p2 = rnd.Next(1, 5);

            switch (p1)
            {
                case (1):
                    {
                        p1 = 0.80;
                        break;
                    }
                case (2):
                    {
                        p1 = 0.85;
                        break;
                    }
                case (3):
                    {
                        p1 = 0.90;
                        break;
                    }
                case (4):
                    {
                        p1 = 0.95;
                        break;
                    }
                default:
                    break;
            }
            switch (p2)
            {
                case (1):
                    {
                        p2 = 0.80;
                        break;
                    }
                case (2):
                    {
                        p2 = 0.85;
                        break;
                    }
                case (3):
                    {
                        p2 = 0.90;
                        break;
                    }
                case (4):
                    {
                        p2 = 0.95;
                        break;
                    }
                default:
                    break;
            }

            double Res = ExerciseAnswer.AnswerForExc7(p1, p2);

            String[] Answer = new string[3]
            { p1.ToString(), p2.ToString(), Math.Round(Res, 3).ToString() };

            return Answer;
        }

        /// <summary>
        /// Генератор задания №8. На выход поступает стринговый массив из 3 элементов: 1-h1, 2-h2, 3-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric8()
        {
            double h1 = rnd.Next(3, 9);
            double h2 = rnd.Next(3, 9);

            while (h1 == h2) h2 = rnd.Next(3, 9);

            h1 /= 100;
            h2 /= 100;

            double Res = ExerciseAnswer.AnswerForExc8(h1, h2);

            String[] Answer = new string[3]
            { h1.ToString(), h2.ToString(), Math.Round(Res, 3).ToString() };

            return Answer;
        }

        /// <summary>
        /// Генератор задания №9. На выход поступает стринговый массив из 3 элементов: 1-b1, 2-b2, 3-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric9()
        {
            double b1 = rnd.Next(60, 91);
            double b2 = rnd.Next(60, 91);

            while (b1 == b2) b2 = rnd.Next(60, 91);

            b1 /= 100;
            b2 /= 100;

            double Res = ExerciseAnswer.AnswerForExc9(b1, b2);

            String[] Answer = new string[3]
            { b1.ToString(), b2.ToString(), Math.Round(Res, 3).ToString() };

            return Answer;
        }

        /// <summary>
        /// Генератор задания №10. На выход поступает стринговый массив из 4 элементов: 1-n, 2-k, 3-p, 4-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric10()
        {
            double p = rnd.Next(3, 7);
            p /= 100;

            int n = rnd.Next(3, 7);
            int k = rnd.Next(2, n);

            double Res = ExerciseAnswer.AnswerForExc10(n, k, p);

            String[] Answer = new string[4]
            { n.ToString(), k.ToString(), p.ToString(), Math.Round(Res, 5).ToString() };

            return Answer;
        }

        /// <summary>
        /// Генератор задания 11. На выход поступает двумерный стринговый массив 2x4, 2x5 или 2x6. Первая строка - E, вторая - P(x)
        /// </summary>
        /// <returns></returns>
        public string[,] TestGeneric11()
        {
            int n = rnd.Next(4, 7);
            double[] P = new double[n];
            int c = 20;
            int y;
            for (int i = 0; i < n - 1; i++)
            {
                y = rnd.Next(1, c / (n - 2) + 1);
                P[i] = y * 0.05;
                c -= y;
            }
            P[n - 1] = c * 0.05;

            string[,] Answer;
            switch (n)
            {
                case (4):
                    {
                        Answer = new string[2, 4] { { "0,1", "0,2", "0,3", "0,4", }, { P[0].ToString(), P[1].ToString(), P[2].ToString(), P[3].ToString() } };
                        return Answer;
                    }
                case (5):
                    {
                        Answer = new string[2, 5] { { "0,1", "0,2", "0,3", "0,4", "0,5" }, { P[0].ToString(), P[1].ToString(), P[2].ToString(), P[3].ToString(), P[4].ToString() } };
                        return Answer;
                    }
                case (6):
                    {
                        Answer = new string[2, 6] { { "0,1", "0,2", "0,3", "0,4", "0,5", "0,6" }, { P[0].ToString(), P[1].ToString(), P[2].ToString(), P[3].ToString(), P[4].ToString(), P[5].ToString() } };
                        return Answer;
                    }
                default:
                    return Answer = new string[,] { };
            }
        }

        /// <summary>
        /// Генератор задания 12. На вход поступает матрица из задания 11. На выход поступает одномерный стринговый массив из 3 элементов: 1 - M(E), 2 - D(E), 3 - Sig(E).
        /// </summary>
        /// <param name="Matrix"></param>
        /// <returns></returns>
        public string[] TestGeneric12(string[,] Matrix)
        {
            string[] Answer = new string[3];

            Answer[0] = ExerciseAnswer.FinderM(Matrix).ToString();

            Answer[1] = ExerciseAnswer.FinderD(Matrix).ToString();

            Answer[2] = ExerciseAnswer.FinderS(Matrix).ToString();

            return Answer;
        }

        /// <summary>
        /// Генератор задания 15. На выход поступает стринговый одномерный массив из 4 элементов: 1 - n, 2 - k, 3 - p, 3 - Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric15()
        {
            int n = rnd.Next(100, 201);
            int k = rnd.Next(n / 5, 4 * n / 5 + 1);

            double p = rnd.Next(8, 19);
            p *= 0.05;

            double Res = ExerciseAnswer.AnswerForExc15(n, k, p);

            String[] Answer = new string[4]
            { n.ToString(), k.ToString(), p.ToString(), Res.ToString() };

            return Answer;
        }

        /// <summary>
        /// Генератор задания 16. На выход поступает стриногвый массив из 5 элементов: 1 - a, 2 - sig, 3 - x1, 4 - x2, 5 - Результат.
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric16()
        {
            double a = rnd.Next(1, 6);
            double sig = rnd.Next(4, 10);
            sig /= 10;
            double x1 = rnd.Next(1, 5);
            double x2 = rnd.Next(Convert.ToInt32(x1) + 2, 10);
            double Res = ExerciseAnswer.AnswerForExc16(a, sig, x1, x2);

            string[] Answer = new string[5] { a.ToString(), sig.ToString(), x1.ToString(), x2.ToString(), Res.ToString() };
            return Answer;
        }
        /// <summary>
        /// Генератор задания 17. На выход поступаетстринговый массив из 5 элементов: 1 - a, 2 - sig, 3 - x1, 4 - x2, 5 - Результат.
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric17()
        {
            double a = rnd.Next(1, 5);
            double sig = rnd.Next(4, 10);
            sig /= 10;
            double x1 = rnd.Next(3, 7);
            x1 *= 0.5;
            double x2 = rnd.Next(1, 4);
            x2 *= 0.1;
            double Res = ExerciseAnswer.AnswerForExc16(a, sig, x1 - x2, x1 + x2);

            string[] Answer = new string[5] { a.ToString(), sig.ToString(), x1.ToString(), x2.ToString(), Res.ToString() };
            return Answer;
        }

        /// <summary>
        /// Обычный свапер
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="line"></param>
        /// <returns></returns>
        private double[] swaper(int x1, int x2, double[] line)
        {
            double t = line[x1];
            line[x1] = line[x2];
            line[x2] = t;
            return line;
        }

        /// <summary>
        /// Генератор таблицы для 18 задания
        /// </summary>
        /// <returns></returns>
        public string[,] TableGeneric18()
        {
            double[] P = new double[6];
            P[0] = rnd.Next(1, 7) * 0.05;
            P[1] = rnd.Next(1, 7) * 0.05;
            P[2] = 0.7 - P[0] - P[1];
            P[3] = rnd.Next(1, 26) * 0.01;
            P[4] = 0.3 - P[3];
            P[5] = 0;

            for (int i = 0; i < 20; i++)
                swaper(rnd.Next(0, 6), rnd.Next(0, 6), P);

            string[,] Matrix = new string[3, 4] { { "  ", "-1", "0", "1" }, 
                { "0", P[0].ToString(), P[1].ToString(), P[2].ToString() }, { "1", P[3].ToString(), P[4].ToString(), P[5].ToString() } };

            return Matrix;
        }

        /// <summary>
        /// Генератор ответа по таблице из 18 задания
        /// </summary>
        /// <param name="Matrix"></param>
        /// <returns></returns>
        public string[] AnswerGeneric18(string[,] Matrix)
        {
            string[,] E = new string[2, 2] { { "0", "1" }, { (Convert.ToDouble(Matrix[1,1])+ Convert.ToDouble(Matrix[1, 2])+ Convert.ToDouble(Matrix[1, 3])).ToString(),
                    (Convert.ToDouble(Matrix[2, 1])+Convert.ToDouble(Matrix[2,2])+Convert.ToDouble(Matrix[2,3])).ToString() } };
            string[,] n = new string[2, 3] {
                { (Convert.ToDouble(Matrix[1, 1]) + Convert.ToDouble(Matrix[2, 1])).ToString(), (Convert.ToDouble(Matrix[1, 2]) + Convert.ToDouble(Matrix[2, 2])).ToString(), 
                    (Convert.ToDouble(Matrix[1, 3]) + Convert.ToDouble(Matrix[2, 3])).ToString()},{ "-1", "0", "1" } };

            double ME = ExerciseAnswer.FinderM(E);
            double Mn = ExerciseAnswer.FinderM(n);
            double DE = ExerciseAnswer.FinderD(E);
            double Dn = ExerciseAnswer.FinderD(n);

            string[,] nE = new string[2, 3] { { "0", "0", "0" }, { "-" + Matrix[2, 1], "0", Matrix[2, 3] } };
            double MnE = ExerciseAnswer.FinderM(nE);
            double DnE = ExerciseAnswer.FinderD(nE);

            string[] Answer = new string[6] { ME.ToString(), Mn.ToString(), MnE.ToString(), DE.ToString(), Dn.ToString(), DnE.ToString() };

            return Answer;
        }
    }
}
