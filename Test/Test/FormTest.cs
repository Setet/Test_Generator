﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Test
{
    public partial class FormTest : Form
    {
        StreamReader number1;//для задания 1 и т.д
        StreamReader number2;
        StreamReader number3;
        StreamReader number4;
        StreamReader number5;
        StreamReader number6;
        StreamReader number7;
        StreamReader number8;
        StreamReader number9;
        StreamReader number10;
        StreamReader number11;
        StreamReader number12;
        StreamReader number13;
        StreamReader number14;
        StreamReader number15;
        StreamReader number16;
        StreamReader number17;
        StreamReader number18;

        StreamReader surname;//для ФИО

        int number_of_human = 0;//переменная кол-ва человеков


        public FormTest()
        {
            InitializeComponent();
            CenterToScreen();
            AutoSize = true;//хз что это
            MaximizeBox = false;//нельзя развернуть окно
            FormBorderStyle = FormBorderStyle.Fixed3D;//нельзя изменить размер окна
            button_GenerateTest.AutoSize = true;//хз что это 2
        }


        //функция позволяет миксовать вопросы в файле(костыли,но больше я пока не придумал)
        void MixQuestion1()
        {
            number1.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Tusk\Number1.txt";
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

        void MixQuestion2()
        {
            number2.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Tusk\Number2.txt";
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

        void MixQuestion3()
        {
            number3.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Tusk\Number3.txt";
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

        void MixQuestion4()
        {
            number4.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Tusk\Number4.txt";
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

        void MixQuestion5()
        {
            number5.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Tusk\Number5.txt";
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

        void MixQuestion6()
        {
            number6.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Tusk\Number6.txt";
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

        void MixQuestion7()
        {
            number7.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Tusk\Number7.txt";
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

        void MixQuestion8()
        {
            number8.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Tusk\Number8.txt";
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

        void MixQuestion9()
        {
            number9.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Tusk\Number9.txt";
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

        void MixQuestion10()
        {
            number10.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Tusk\Number10.txt";
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

        void MixQuestion11()
        {
            number11.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Tusk\Number11.txt";
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

        void MixQuestion12()
        {
            number12.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Tusk\Number12.txt";
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

        void MixQuestion13()
        {
            number13.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Tusk\Number13.txt";
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

        void MixQuestion14()
        {
            number14.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Tusk\Number14.txt";
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

        void MixQuestion15()
        {
            number15.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Tusk\Number15.txt";
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

        void MixQuestion16()
        {
            number16.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Tusk\Number16.txt";
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

        void MixQuestion17()
        {
            number17.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Tusk\Number17.txt";
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

        void MixQuestion18()
        {
            number18.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Tusk\Number18.txt";
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

        //функция позволяет ПОСЛЕДОВАТЕЛЬНО брать фамилии в файле(костыли,но больше я пока не придумал)
        /*
        Я,толи от тупости,толи чётр пойми от чего сломал эту штуку,и как бы тоно обрабатывает все фамилии
        но в каком-то конченном порядке(на самом деле я уже нашёл причино-следственную связь)
        в идеале надо сделать так чтобы фамилии шли по тому же порядку,по которому они записанны
         */
        void MixName()
        {
            surname.Close();
            string dest = Directory.GetCurrentDirectory() + @"\Name.txt";
            var encoding = System.Text.Encoding.UTF8;
            var lines = File.ReadAllLines(dest);
            int y = 1;

            for (int i = lines.Length - 1; i > 0; i--)
            {
                var temp = lines[0];
                lines[0] = lines[y];
                lines[y] = temp;
                y++;
            }

            File.WriteAllLines(dest, lines, encoding);
        }

        //по факту,просто создание экземляра и вызов функции ниже
        void StartTest()
        {
            var encoding = System.Text.Encoding.GetEncoding(1251);

            try
            {

                surname = new StreamReader(Directory.GetCurrentDirectory() + @"\Name.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                // Создание экземпляра StreamReader для чтения из файла
                number1 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number1.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {   // Отчет о всех ошибках:
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number2 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number2.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number3 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number3.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number4 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number4.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number5 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number5.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number6 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number6.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number7 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number7.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number8 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number8.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                number9 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number9.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number10 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number10.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number11 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number11.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number12 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number12.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number13 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number13.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number14 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number14.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number15 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number15.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number16 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number16.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number17 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number17.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number18 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number18.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            ReadNextQuestion();
        }


        /*
         Микро фикс который можно сделать-чтобы к конце каждого вопроса в каждом задании не ставить
         ограничительный знак как этого требуют строки ниже
         */

        //функция позволяющая выбрать след вопрос
        void ReadNextQuestion()
        {
            string[] name = surname.ReadLine().Split('\n');

            string[] tmp1 = number1.ReadLine().Split('\n');
            string[] tmp2 = number2.ReadLine().Split('\n');
            string[] tmp3 = number3.ReadLine().Split('\n');
            string[] tmp4 = number4.ReadLine().Split('\n');
            string[] tmp5 = number5.ReadLine().Split('\n');
            string[] tmp6 = number6.ReadLine().Split('\n');
            string[] tmp7 = number7.ReadLine().Split('\n');
            string[] tmp8 = number8.ReadLine().Split('\n');
            string[] tmp9 = number9.ReadLine().Split('\n');
            string[] tmp10 = number10.ReadLine().Split('\n');
            string[] tmp11 = number11.ReadLine().Split('\n');
            string[] tmp12 = number12.ReadLine().Split('\n');
            string[] tmp13 = number13.ReadLine().Split('\n');
            string[] tmp14 = number14.ReadLine().Split('\n');
            string[] tmp15 = number15.ReadLine().Split('\n');
            string[] tmp16 = number16.ReadLine().Split('\n');
            string[] tmp17 = number17.ReadLine().Split('\n');
            string[] tmp18 = number18.ReadLine().Split('\n');

            int indexn = 0;
            int index1 = 0;
            int index2 = 0;
            int index3 = 0;
            int index4 = 0;
            int index5 = 0;
            int index6 = 0;
            int index7 = 0;
            int index8 = 0;
            int index9 = 0;
            int index10 = 0;
            int index11 = 0;
            int index12 = 0;
            int index13 = 0;
            int index14 = 0;
            int index15 = 0;
            int index16 = 0;
            int index17 = 0;
            int index18 = 0;

            labeln.Text = name[indexn++];

            //label был выбран как первоночальное решение,потом приведу к красивому виду(или нет)
            label1.Text = tmp1[index1++];
            label2.Text = tmp2[index2++];
            label3.Text = tmp3[index3++];
            label4.Text = tmp4[index4++];
            label5.Text = tmp5[index5++];
            label6.Text = tmp6[index6++];
            label7.Text = tmp7[index7++];
            label8.Text = tmp8[index8++];
            label9.Text = tmp9[index9++];
            label10.Text = tmp10[index10++];
            label11.Text = tmp11[index11++];
            label12.Text = tmp12[index12++];
            label13.Text = tmp13[index13++];
            label14.Text = tmp14[index14++];
            label15.Text = tmp15[index15++];
            label16.Text = tmp16[index16++];
            label17.Text = tmp17[index17++];
            label18.Text = tmp18[index18++];
        }


        //та самая кнопка в которой происходит кривая костылявая,но магия
        private void button_GenerateTest_Click(object sender, EventArgs e)
        {
            int Answer = 0;

            int number_of_options = 1;//счётчик для номера варианта

            string Path1 = WritePath1.Text;

            string writePath1 = @"" + Path1;//создание файла по пути написанному пользователем в WritePath
            string writePath2 = @"C:\Users\user\Desktop\Test\Test\bin\Debug\Answer.doc";

            StreamWriter sw = new StreamWriter(writePath1, false, System.Text.Encoding.Default);

            StreamWriter ws = new StreamWriter(writePath2, false, System.Text.Encoding.Default);

            //считает кол-во людей по факту(заполняет var lines строками из Name,а потом считает кол-во строк)
            string dest = Directory.GetCurrentDirectory() + @"\Name.txt";
            var lines = File.ReadAllLines(dest);
            number_of_human = lines.Length;//кол-во человек вычисляется из кол-ва фамилий в списки Name

            //все
            if (checkBox1.Checked == true)
            {
                for (int i = 0; i < number_of_human; i++)//записть нужного кол-ва вопросов в файл
                {
                    StartTest();
                    sw.Write(labeln.Text + "\n");
                    sw.Write("Вариант №" + number_of_options + "\n");
                    ws.Write("Вариант №" + number_of_options + "\n");
                    MixQuestion1();
                    MixQuestion2();
                    MixQuestion3();
                    MixQuestion4();
                    MixQuestion5();
                    MixQuestion6();
                    MixQuestion7();
                    MixQuestion8();
                    MixQuestion9();
                    MixQuestion10();
                    MixQuestion11();
                    MixQuestion12();
                    MixQuestion13();
                    MixQuestion14();
                    MixQuestion15();
                    MixQuestion16();
                    MixQuestion17();
                    MixQuestion18();
                    MixName();

                    /*
                    здесь я ХОЧУ изъябнуться и сделать так чтобы у каждого задания писалось
                    номер+) , но я пока не придумал как это грамотно сделать,поэтому пока ручками
                    */

                    sw.Write("1) " + label1.Text + "\n" + "\n");

                    ws.Write("1) " + label1.Text + "\n" + "Ответ :" + "a)" + Answer + " ," + "b)" + Answer + " ," + "c)" + Answer + "\n");

                    sw.Write("2) " + label2.Text + "\n" + "\n");

                    ws.Write("2) " + label2.Text + "\n" + "Ответ :" + Answer + "\n");

                    sw.Write("3) " + label3.Text + "\n" + "\n");

                    ws.Write("3) " + label4.Text + "\n" + "Ответ :" + Answer + "\n");

                    sw.Write("4) " + label4.Text + "\n" + "\n");

                    ws.Write("4) " + label4.Text + "\n" + "Ответ :" + Answer + "\n");

                    sw.Write("5) " + label5.Text + "\n" + "\n");

                    ws.Write("5) " + label5.Text + "\n" + "Ответ :" + Answer + "\n");

                    sw.Write("6) " + label6.Text + "\n" + "\n");

                    ws.Write("6) " + label6.Text + "\n" + "Ответ :" + Answer + "\n");

                    sw.Write("7) " + label7.Text + "\n" + "\n");

                    ws.Write("7) " + label7.Text + "\n" + "Ответ :" + Answer + "\n");

                    sw.Write("8) " + label8.Text + "\n" + "\n");

                    ws.Write("8) " + label8.Text + "\n" + "Ответ :" + Answer + "\n");

                    sw.Write("9) " + label9.Text + "\n" + "\n");

                    ws.Write("9) " + label9.Text + "\n" + "Ответ :" + Answer + "\n");

                    sw.Write("10) " + label10.Text + "\n" + "\n");

                    ws.Write("10) " + label10.Text + "\n" + "Ответ :" + Answer + "\n");
                    //---------------------------------------------------------------------------//
                    sw.Write("11) " + label11.Text + "\n" + "\n");
                    sw.Write("12) " + label12.Text + "\n" + "\n");
                    sw.Write("13) " + label13.Text + "\n" + "\n");
                    sw.Write("14) " + label14.Text + "\n" + "\n");
                    sw.Write("16) " + label16.Text + "\n" + "\n");
                    sw.Write("17) " + label17.Text + "\n" + "\n");
                    sw.Write("18) " + label18.Text + "\n" + "\n");
                    number_of_options++;
                }
            }

            /*
            знаю,реализовать RadioBox через CheckBox чистый мазахизм
            но в таком случае-я мазахист
            */

            //1-10
            if (checkBox2.Checked == true)
            {
                for (int i = 0; i < number_of_human; i++)//записть нужного кол-ва вопросов в файл
                {
                    StartTest();
                    sw.Write(labeln.Text + "\n");
                    sw.Write("Вариант №" + number_of_options + "\n");
                    ws.Write("Вариант №" + number_of_options + "\n");
                    MixQuestion1();
                    MixQuestion2();
                    MixQuestion3();
                    MixQuestion4();
                    MixQuestion5();
                    MixQuestion6();
                    MixQuestion7();
                    MixQuestion8();
                    MixQuestion9();
                    MixQuestion10();
                    MixName();

                    //здесь я ХОЧУ изъябнуться и сделать так чтобы у каждого задания писалось
                    // номер+) , но я пока не придумал как это грамотно сделать,поэтому пока ручками

                    sw.Write("1) " + label1.Text + "\n" + "\n");

                    ws.Write("1) " + label1.Text + "\n" + "Ответ :" + "a)" + Answer + " ," + "b)" + Answer + " ," + "c)" + Answer + "\n");

                    sw.Write("2) " + label2.Text + "\n" + "\n");

                    ws.Write("2) " + label2.Text + "\n" + "Ответ :" + Answer + "\n");

                    sw.Write("3) " + label3.Text + "\n" + "\n");

                    ws.Write("3) " + label4.Text + "\n" + "Ответ :" + Answer + "\n");

                    sw.Write("4) " + label4.Text + "\n" + "\n");

                    ws.Write("4) " + label4.Text + "\n" + "Ответ :" + Answer + "\n");

                    sw.Write("5) " + label5.Text + "\n" + "\n");

                    ws.Write("5) " + label5.Text + "\n" + "Ответ :" + Answer + "\n");

                    sw.Write("6) " + label6.Text + "\n" + "\n");

                    ws.Write("6) " + label6.Text + "\n" + "Ответ :" + Answer + "\n");

                    sw.Write("7) " + label7.Text + "\n" + "\n");

                    ws.Write("7) " + label7.Text + "\n" + "Ответ :" + Answer + "\n");

                    sw.Write("8) " + label8.Text + "\n" + "\n");

                    ws.Write("8) " + label8.Text + "\n" + "Ответ :" + Answer + "\n");

                    sw.Write("9) " + label9.Text + "\n" + "\n");

                    ws.Write("9) " + label9.Text + "\n" + "Ответ :" + Answer + "\n");

                    sw.Write("10) " + label10.Text + "\n" + "\n");

                    ws.Write("10) " + label10.Text + "\n" + "Ответ :" + Answer + "\n");
                    number_of_options++;
                }
            }
            //11-18
            if (checkBox3.Checked == true)
            {
                for (int i = 0; i < number_of_human; i++)//записть нужного кол-ва вопросов в файл
                {
                    StartTest();
                    sw.Write(labeln.Text + "\n");
                    sw.Write("Вариант №" + number_of_options + "\n");
                    MixQuestion11();
                    MixQuestion12();
                    MixQuestion13();
                    MixQuestion14();
                    MixQuestion15();
                    MixQuestion16();
                    MixQuestion17();
                    MixQuestion18();
                    MixName();

                    //здесь я ХОЧУ изъябнуться и сделать так чтобы у каждого задания писалось
                    // номер+) , но я пока не придумал как это грамотно сделать,поэтому пока ручками

                    sw.Write("11) " + label11.Text + "\n" + "\n");
                    sw.Write("12) " + label12.Text + "\n" + "\n");
                    sw.Write("13) " + label13.Text + "\n" + "\n");
                    sw.Write("14) " + label14.Text + "\n" + "\n");
                    sw.Write("15) " + label15.Text + "\n" + "\n");
                    sw.Write("16) " + label16.Text + "\n" + "\n");
                    sw.Write("17) " + label17.Text + "\n" + "\n");
                    sw.Write("18) " + label18.Text + "\n" + "\n");
                    number_of_options++;
                }
            }


            sw.Close();
            MessageBox.Show("Тест составлен в файл " + textBox1.Text + "!!!");
            button_FileCreate.Visible = true;

            //зануляет значения всех полей
            textBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        //крысинное скрытие label-ов
        private void FormTest_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

            button_GenerateTest.Visible = false;

            labeln.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;

            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;

            textBox1.Visible = false;
            WritePath1.Visible = false;
        }

        //вроде как решил проблему с работой в вордовском формате

        /*
         Поправка,формат одновременно вордовский и нет.Тип я юзнул страый вордовский формат(.doc)
         ибо с новым форматом ворда(.docx) VS-ка работать автоматически не хочет,
         а мне лень пока этим себе голову забивать
         */

        //если есть время-довести до идеала
        private void button_SaveFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();//создаём объект класса для работы с открытием файла

            openFileDialog.Filter = "Tests(*.doc)|*.doc|All files(*.*)|*.*";//фильтр,конструкция немного норкоманская,как работает доподлинно не знаю,но если надо сменить формат
                                                                            //то просто замени .doc на то что надо

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)//тип если он не открылся по какой-то причине,то у нас проблемы
            {
                return;
            }

            string filename1 = openFileDialog.FileName;//получаем в строку имя файла с расширением(из-за это писать его в WritePath и в коде не нужно(я про расширение)
            string filename2 = openFileDialog.SafeFileName;

            WritePath1.Text = filename1;
            textBox1.Text = filename2;

            MessageBox.Show("Файл для теста принят!!!");
            groupBox1.Visible = true;
            button_GenerateTest.Visible = true;

            label19.Visible = true;
            textBox1.Visible = true;

        }

        /*короче,про создание файла из того же окна что и выбор инфы крайне мало,поэтому пришлось идти костылями
        (или я просто дэбил и не могу вспомнить как создать файл,и закрыть его для чтения через File,если тот кто это читает смогёт это сделать
        будет нереально круто,а пока вот так)

        сами костыли в том что создавая файл,он автоматически выбирается главным(из-за косяка описанного выше),если пользователь создать один файл
        а записать тест захочет в другой,он этого не сможет(на кнопку выбора данный косяк зеркально не работает)
        */

        private void button_FileCreate_Click(object sender, EventArgs e)
        {
            string res = "Варианты тестов пофамильно";//Ъръютр тх№юџђэюёђќ, їђю C №ѓїхъ юърцѓђёџ

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Tests(*.doc)|*.doc|All files(*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                File.WriteAllText(saveFileDialog.FileName, res);//микро фикс пробелемы с левой кнопкой которые родились недавно,вроде работает,надеюсь
                                                                //надеюсь обойдёмся без приколов

                MessageBox.Show("Файл создан!!!");
                button_FileCreate.Visible = false;
            }
        }

        private void radioButton_All_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                checkBox2.Checked = true;
            }
            else
            {
                checkBox2.Checked = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                checkBox3.Checked = true;
            }
            else
            {
                checkBox3.Checked = false;
            }
        }
    }
}