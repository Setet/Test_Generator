using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace Test
{
    public partial class FormTest : Form
    {
        StreamReader reader1;//прикол для чтения строк файла(понадобится ниже)
        int number_of_questions = 0;

        public FormTest()
        {
            InitializeComponent();
            CenterToScreen();
            AutoSize = true;
            MaximizeBox = false;//нельзя развернуть окно
            FormBorderStyle = FormBorderStyle.Fixed3D;//нельзя изменить размер окна
            button_GenerateTest.AutoSize = true;
        }


        //функция позволяет миксовать вопросы в файле(костыли,но больше я пока не придумал)
        void MixQuestion()
        {
            reader1.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Test.txt";
            var encoding = System.Text.Encoding.UTF8;
            var lines = File.ReadAllLines(dest);

            var rand = new Random();

            for (int i = lines.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i);

                var temp = lines[i - 1];
                lines[i - 1] = lines[j];
                lines[j] = temp;
            }

            File.WriteAllLines(dest, lines, encoding);
        }

        //по факту,просто создание экземляра и вызов функции ниже
        void StartTest()
        {
            var encoding = System.Text.Encoding.GetEncoding(1251);
            try
            {
                // Создание экземпляра StreamReader для чтения из файла
                reader1 = new StreamReader(Directory.GetCurrentDirectory() + @"\Test.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {   // Отчет о всех ошибках:
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            ReadNextQuestion();
        }

        //функция позволяющая выбрать след вопрос
        void ReadNextQuestion()
        {
            string[] tmp1 = reader1.ReadLine().Split('|');//читаем из файла до символа в скобках,и всё что получили представляем ввиде строки
            int index = 0;
            label1.Text = tmp1[index++];//label был выбран как первоночальное решение,потом приведу к красивому виду
        }


        //та самая кнопка в которой происходит кривая костылявая,но магия
        private void button_GenerateTest_Click(object sender, EventArgs e)
        {
            int t = 1;//счётчик для номера варианта
            string Path = WritePath.Text;
            string writePath = @""+Path+".txt";//создание файла по пути написанному пользователем в WritePath

            /*
            Сталкнулся с небольшой проблемой в плане работы с расширением .docx(расширение word-a).Суть проблемы в том
            что прога создаёт пишет(вроде как),но походу как-то криво,ибо открыть файл и проверить
            что он туда записал невозможно(word жалуется).
            */

            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);

            for (int i = 0; i < number_of_questions; i++)//записть нужного кол-ва вопросов в файл(пока txt)
            {
                StartTest();
                sw.Write("Вариант №" + t+"\n");
                MixQuestion();

                sw.Write(label1.Text);
                sw.Write("\n");
                t++;
            }
            sw.Close();
            MessageBox.Show("Тест составлен!!!");
        }

        private void button_ToAccept_Click(object sender, EventArgs e)
        {
            number_of_questions = Convert.ToInt32(NumberOfQuestions.Text);
            MessageBox.Show("Кол-во вопросов принято!!!");
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}