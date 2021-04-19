using System;

namespace NullVersionOfTeorver.Exercises
{
    //Дисклеймер

    //Данный класс является набором методов для генережки задач
    //Большинство методов не нуждаются в начальных аргументах, кроме некоторых, где они выступают, как выбор конкретной подзадачи
    //На выход у всех методов подается маленький стринговый массив, каждый элемент которого отвечает за определенную переменную в задаче + ответ
    public class ExerciseGenerator : ExerciseAnswer
    {
        Random rnd = new Random();

        /// <summary>
        /// Генератор задания №1. 
        /// Аргумент 'a' означает, какая задача нам именно нужна: 1 - 1а, 2 - 1b, 3 - 1с. 
        /// На выход поступает стринговый массив из 4 элементов: 1-n, 2-k, 3-m, 4-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric1(int a) 
        {
            int n = rnd.Next(20, 26);
            int k = rnd.Next(3, 8);
            int m = 2;
            double Res = -1;

            switch (a)
            {
                case (1):
                    Res = ExerciseAnswer.AnswerForExc1a(n, k, m);
                    break;
                case (2):
                    Res = ExerciseAnswer.AnswerForExc1b(n, k, m);
                    break;
                case (3):
                    Res = ExerciseAnswer.AnswerForExc1c(n, k, m);
                    break;
                default:
                    break;
            }//Свитч, для выбора альтернатив

            String[] Answer = new string[4] 
            { n.ToString(), k.ToString(), m.ToString(), Res.ToString() };

            return Answer;
        }
        /// <summary>
        /// Генератор задания №2. На выход поступает стринговый массив из 5 элементов: 1-n, 2-k, 3-m, 4-l, 5-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric2()
        {
            int n = rnd.Next(20, 26);
            int k = rnd.Next(5, 8);
            int m = rnd.Next(2, n / 2 - 3);
            int l = rnd.Next(1, m-1);

            if (m - l > n - k)
                TestGeneric2();

            double Res = ExerciseAnswer.AnswerForExc2(n, k, m, l);

            if (Res >= 1)
                TestGeneric2();

            String[] Answer = new string[5]
            { n.ToString(), k.ToString(), m.ToString(), l.ToString(), Res.ToString() };

            return Answer;
        }
        /// <summary>
        /// Генератор задания №3. На выход поступает стринговый массив из 3 элементов: 1-n, 2-k, 3-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric3()
        {
            int c = rnd.Next(1, 4);
            int k = rnd.Next(3, 6);
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

            if (Res >= 1)
                TestGeneric3();

            String[] Answer = new string[3]
            { n.ToString(), k.ToString(), Res.ToString() };

            return Answer;
        }
        /// <summary>
        /// Генератор задания №4. На выход поступает стринговый массив из 4 элементов: 1-n, 2-k, 3-m, 4-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric4()
        {
            int n = rnd.Next(20, 26);
            int k = rnd.Next(8, n / 2);

            int c = rnd.Next(1,3);
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

            if (Res >= 1)
                TestGeneric4();

            String[] Answer = new string[4]
            { n.ToString(), k.ToString(), m.ToString(), Res.ToString() };

            return Answer;
        }
        /// <summary>
        /// Генератор задания №5. На выход поступает стринговый массив из 4 элементов: 1-n, 2-k, 3-m, 4-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric5()
        {
            int n = rnd.Next(7, 10);
            int k = rnd.Next(3,5);
            int m = rnd.Next(3,5);

            double Res = ExerciseAnswer.AnswerForExc5(n, k, m);

            String[] Answer = new string[4]
            { n.ToString(), k.ToString(), m.ToString(), Res.ToString() };

            return Answer;
        }
        /// <summary>
        /// Генератор задания №6. На выход поступает стринговый массив из 4 элементов: 1-p1, 2-p2, 3-p3, 4-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric6()
        {
            double p1 = rnd.Next(3, 12);
            double p2 = rnd.Next(3, 12);
            double p3 = rnd.Next(3, 12);

            while (p1 == p2) p2 = rnd.Next(3, 12);
            while (p1 == p3 || p2 == p3) p3 = rnd.Next(3, 12);

            p1 /= 100;
            p2 /= 100;
            p3 /= 100;

            double Res = ExerciseAnswer.AnswerForExc6(p1, p2, p3);

            String[] Answer = new string[4]
            { p1.ToString(), p2.ToString(), p3.ToString(), Res.ToString() };

            return Answer;
        }
        /// <summary>
        /// Генератор задания №7. На выход поступает стринговый массив из 3 элементов: 1-p1, 2-p2, 3-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric7()
        {
            double p1 = rnd.Next(1, 4);
            double p2 = rnd.Next(1, 4);

            while (p1 == p2) p2 = rnd.Next(1, 4);

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
            { p1.ToString(), p2.ToString(), Res.ToString() };

            return Answer;
        }
        /// <summary>
        /// Генератор задания №8. На выход поступает стринговый массив из 3 элементов: 1-h1, 2-h2, 3-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric8()
        {
            double h1 = rnd.Next(3, 8);
            double h2 = rnd.Next(3, 8);

            while (h1 == h2) h2 = rnd.Next(3, 8);

            h1 /= 100;
            h2 /= 100;

            double Res = ExerciseAnswer.AnswerForExc8(h1, h2);

            String[] Answer = new string[3]
            { h1.ToString(), h2.ToString(), Res.ToString() };

            return Answer;
        }
        /// <summary>
        /// Генератор задания №9. На выход поступает стринговый массив из 3 элементов: 1-b1, 2-b2, 3-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric9()
        {
            double b1 = rnd.Next(60, 90);
            double b2 = rnd.Next(60, 90);

            while (b1 == b2) b2 = rnd.Next(60, 90);

            b1 /= 100;
            b2 /= 100;

            double Res = ExerciseAnswer.AnswerForExc9(b1, b2);

            String[] Answer = new string[3]
            { b1.ToString(), b2.ToString(), Res.ToString() };

            return Answer;
        }
        /// <summary>
        /// Генератор задания №10. На выход поступает стринговый массив из 4 элементов: 1-n, 2-k, 3-p, 4-Результат
        /// </summary>
        /// <returns></returns>
        public string[] TestGeneric10()
        {
            double p = rnd.Next(3, 6);
            p /= 100;

            int n = rnd.Next(3, 6);
            int k = rnd.Next(2, n - 1);

            double Res = ExerciseAnswer.AnswerForExc10(n, k, p);

            String[] Answer = new string[4]
            { n.ToString(), k.ToString(), p.ToString(), Res.ToString() };

            return Answer;
        }


        public string[,] TestGeneric11()
        {
            int n = rnd.Next(4, 6);
            double[] P = new double[n];
            int c = 20;
            int y;
            for (int i = 0; i < n - 1; i++)
            {
                y = rnd.Next(1, c / (n-2));
                P[i] = y * 0.05;
                c -= y;
            }
            P[n - 1] = c * 0.05;

            string[,] Answer;
            switch (n)
            {
                case (4):
                    {
                        Answer = new string[2, 4] { { "0.1", "0.2", "0.3", "0.4", }, { P[0].ToString(), P[1].ToString(), P[2].ToString(), P[3].ToString() } };
                        return Answer;
                    }
                case (5):
                    {
                        Answer = new string[2, 5] { { "0.1", "0.2", "0.3", "0.4", "0.5" }, { P[0].ToString(), P[1].ToString(), P[2].ToString(), P[3].ToString(), P[4].ToString() } };
                        return Answer;
                    }
                case (6):
                    {
                        Answer = new string[2, 6] { { "0.1", "0.2", "0.3", "0.4", "0.5", "0.6" }, { P[0].ToString(), P[1].ToString(), P[2].ToString(), P[3].ToString(), P[4].ToString(), P[5].ToString() } };
                        return Answer;
                    }
                default:
                    return Answer = new string[,] { };
            }
        }
    }
}
