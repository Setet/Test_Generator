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
            int n = rnd.Next(20, 24);
            int k = rnd.Next(8, n / 2);
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
            int n = rnd.Next(20, 30);
            int k = rnd.Next(8, n / 2);
            int m = rnd.Next(4, n / 2 - 3);
            int l = rnd.Next(1, m);

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
            int n = rnd.Next(20, 30);
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
                TestGeneric3();

            String[] Answer = new string[4]
            { n.ToString(), k.ToString(), m.ToString(), Res.ToString() };

            return Answer;
        }
    }
}
