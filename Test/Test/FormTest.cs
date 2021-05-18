using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Word = Microsoft.Office.Interop.Word;

namespace Test
{
    public partial class FormTest : Form
    {
        StreamReader number1;//для задания 1-18
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
                number1 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number1.txt", encoding);
            }
            catch (Exception message)
            {   // Отчет о всех ошибках:
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number2 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number2.txt", encoding);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number3 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number3.txt", encoding);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number4 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number4.txt", encoding);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number5 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number5.txt", encoding);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number6 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number6.txt", encoding);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number7 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number7.txt", encoding);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number8 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number8.txt", encoding);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                number9 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number9.txt", encoding);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number10 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number10.txt", encoding);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number11 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number11.txt", encoding);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number12 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number12.txt", encoding);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number13 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number13.txt", encoding);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number14 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number14.txt", encoding);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number15 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number15.txt", encoding);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number16 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number16.txt", encoding);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number17 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number17.txt", encoding);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {

                number18 = new StreamReader(Directory.GetCurrentDirectory() + @"\Tusk\Number18.txt", encoding);
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            ReadNextQuestion();
        }

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

            List<string> allCategories = new List<string>();

            allCategories.Add("1");

            //1
            var application1 = new Word.Application();
            Word.Document document1 = application1.Documents.Add();

            //2
            var application2 = new Word.Application();
            Word.Document document2 = application2.Documents.Add();


            int number_of_options = 1;//счётчик для номера варианта

            string Path1 = WritePath1.Text;
            string Path2 = WritePath2.Text;

            //считает кол-во людей по факту(заполняет var lines строками из Name,а потом считает кол-во строк)
            string dest = Directory.GetCurrentDirectory() + @"\Name.txt";
            var lines = File.ReadAllLines(dest);
            number_of_human = lines.Length;//кол-во человек вычисляется из кол-ва фамилий в списки Name

            //все
            if (checkBox1.Checked == true)
            {
                for (int i = 0; i < number_of_human; i++)//записть нужного кол-ва вопросов в файл
                {
                    ExerciseGenerator EG = new ExerciseGenerator();

                    string[] Answer1 = EG.TestGeneric1();
                    string[] Answer2 = EG.TestGeneric2();
                    string[] Answer3 = EG.TestGeneric3();
                    string[] Answer4 = EG.TestGeneric4();
                    string[] Answer5 = EG.TestGeneric5();
                    string[] Answer6 = EG.TestGeneric6();
                    string[] Answer7 = EG.TestGeneric7();
                    string[] Answer8 = EG.TestGeneric8();
                    string[] Answer9 = EG.TestGeneric9();
                    string[] Answer10 = EG.TestGeneric10();
                    string[,] Answer11 = EG.TestGeneric11();
                    string[] Answer13 = EG.TestGeneric13_14();
                    string[] Answer15 = EG.TestGeneric15();
                    string[] Answer16 = EG.TestGeneric16();
                    string[] Answer17 = EG.TestGeneric17();
                    string[,] Answer18 = EG.TableGeneric18();

                    string result1_1 = Answer1[4];
                    string result1_2 = Answer1[5];
                    string result1_3 = Answer1[6];

                    StartTest();
                    labelV.Text = "Вариант №" + number_of_options + "\n";
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

                    //1
                    string n = Answer1[0];
                    string kek = Answer1[1];
                    string k = Answer1[2];
                    string m = Answer1[3];

                    string text = label1.Text;
                    text = text.Replace("n", n);
                    text = text.Replace("p", kek);
                    text = text.Replace("k", k);
                    text = text.Replace("m", m);
                    label1.Text = text;
                    //2
                    string result2 = Answer2[5];
                    n = Answer2[0];
                    kek = Answer2[1];
                    k = Answer2[2];
                    m = Answer2[3];
                    string l = Answer2[4];

                    text = label2.Text;
                    text = text.Replace("n", n);
                    text = text.Replace("k", k);
                    text = text.Replace("p", kek);
                    text = text.Replace("m", m);
                    text = text.Replace("j", l);
                    label2.Text = text;
                    //3
                    string result3 = Answer3[2];
                    n = Answer3[0];
                    k = Answer3[1];

                    text = label3.Text;
                    text = text.Replace("n", n);
                    text = text.Replace("k", k);
                    label3.Text = text;
                    //4
                    string result4 = Answer4[3];
                    n = Answer4[0];
                    k = Answer4[1];
                    m = Answer4[2];

                    text = label4.Text;
                    text = text.Replace("n", n);
                    text = text.Replace("k", k);
                    text = text.Replace("m", m);
                    label4.Text = text;
                    //5
                    string result5 = Answer5[3];
                    n = Answer5[0];
                    k = Answer5[1];
                    m = Answer5[2];

                    text = label5.Text;
                    text = text.Replace("n", n);
                    text = text.Replace("k", k);
                    text = text.Replace("m", m);
                    label5.Text = text;
                    //6
                    string result6 = Answer6[3];
                    string p1 = Answer6[0];
                    string p2 = Answer6[1];
                    string p3 = Answer6[2];

                    text = label6.Text;
                    text = text.Replace("a", p1);
                    text = text.Replace("b", p2);
                    text = text.Replace("c", p3);
                    label6.Text = text;
                    //7
                    string result7 = Answer7[2];
                    p1 = Answer7[0];
                    p2 = Answer7[1];

                    text = label7.Text;
                    text = text.Replace("a", p1);
                    text = text.Replace("b", p2);
                    label7.Text = text;
                    //8
                    string result8 = Answer8[2];
                    string h1 = Answer8[0];
                    string h2 = Answer8[1];

                    text = label8.Text;
                    text = text.Replace("m", h1);
                    text = text.Replace("n", h2);
                    label8.Text = text;
                    //9
                    string result9 = Answer9[2];
                    string b1 = Answer9[0];
                    string b2 = Answer9[1];

                    text = label9.Text;
                    text = text.Replace("m", b1);
                    text = text.Replace("n", b2);
                    label9.Text = text;
                    //10
                    string result10 = Answer10[3];
                    n = Answer10[0];
                    k = Answer10[1];
                    string p = Answer10[2];

                    text = label10.Text;
                    text = text.Replace("n", n);
                    text = text.Replace("k", k);
                    text = text.Replace("p", p);
                    label10.Text = text;

                    Word.Paragraph obj1 = document1.Paragraphs.Add();
                    Word.Range Test = obj1.Range;

                    Test.Text = labeln.Text + "\n" + labelV.Text +
                        "1)" + label1.Text + "\n" +
                        "2)" + label2.Text + "\n" +
                        "3)" + label3.Text + "\n" +
                        "4)" + label4.Text + "\n" +
                        "5)" + label5.Text + "\n" +
                        "6)" + label6.Text + "\n" +
                        "7)" + label7.Text + "\n" +
                        "8)" + label8.Text + "\n" +
                        "9)" + label9.Text + "\n" +
                        "10)" + label10.Text + "\n";

                    Word.Paragraph obj2 = document2.Paragraphs.Add();
                    Word.Range Answer = obj2.Range;
                    Answer.Text = labelV.Text +
                        "1) a)" + result1_1 + " b)" + result1_2 + " c)" + result1_3 + "\n" +
                        "2)" + result2 + "\n" +
                        "3)" + result3 + "\n" +
                        "4)" + result4 + "\n" +
                        "5)" + result5 + "\n" +
                        "6)" + result6 + "\n" +
                        "7)" + result7 + "\n" +
                        "8)" + result8 + "\n" +
                        "9)" + result9 + "\n" +
                        "10)" + result10 + "\n";

                    int pipu = Answer11.Length;

                    Word.Paragraph obj0 = document1.Paragraphs.Add();
                    Word.Range Test1 = obj0.Range;
                    Test1.Text = "11)" + label11.Text;

                    Word.Paragraph obj9 = document2.Paragraphs.Add();
                    Word.Range Test2 = obj9.Range;
                    Test2.Text = "11)";

                    if (pipu == 8)
                    {
                        Word.Paragraph userParagrapth1 = document1.Paragraphs.Add();
                        Word.Range userRange1 = userParagrapth1.Range;

                        Word.Paragraph tableParagraph1 = document1.Paragraphs.Add();
                        Word.Range tableRange1 = tableParagraph1.Range;

                        Word.Table paymentsTable1 = document1.Tables.Add(tableRange1, allCategories.Count() + 1, 5);
                        paymentsTable1.Borders.InsideLineStyle = paymentsTable1.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                        paymentsTable1.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                        Word.Range cellRange;

                        cellRange = paymentsTable1.Cell(1, 1).Range;
                        cellRange.Text = "X";
                        cellRange = paymentsTable1.Cell(1, 2).Range;
                        cellRange.Text = "0.1";
                        cellRange = paymentsTable1.Cell(1, 3).Range;
                        cellRange.Text = "0.2";
                        cellRange = paymentsTable1.Cell(1, 4).Range;
                        cellRange.Text = "0.3";
                        cellRange = paymentsTable1.Cell(1, 5).Range;
                        cellRange.Text = "0.4";
                        cellRange = paymentsTable1.Cell(2, 1).Range;
                        cellRange.Text = "P(X)";
                        cellRange = paymentsTable1.Cell(2, 2).Range;
                        cellRange.Text = Answer11[1, 0];
                        cellRange = paymentsTable1.Cell(2, 3).Range;
                        cellRange.Text = "";
                        cellRange = paymentsTable1.Cell(2, 4).Range;
                        cellRange.Text = Answer11[1, 2];
                        cellRange = paymentsTable1.Cell(2, 5).Range;
                        cellRange.Text = Answer11[1, 3];

                        Word.Paragraph userParagrapth2 = document2.Paragraphs.Add();
                        Word.Range userRange2 = userParagrapth2.Range;

                        Word.Paragraph tableParagraph2 = document2.Paragraphs.Add();
                        Word.Range tableRange2 = tableParagraph2.Range;

                        Word.Table paymentsTable2 = document2.Tables.Add(tableRange2, allCategories.Count() + 1, 5);
                        paymentsTable2.Borders.InsideLineStyle = paymentsTable2.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                        paymentsTable2.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                        Word.Range cellRange2;

                        cellRange2 = paymentsTable2.Cell(1, 1).Range;
                        cellRange2.Text = "X";
                        cellRange2 = paymentsTable2.Cell(1, 2).Range;
                        cellRange2.Text = "0.1";
                        cellRange2 = paymentsTable2.Cell(1, 3).Range;
                        cellRange2.Text = "0.2";
                        cellRange2 = paymentsTable2.Cell(1, 4).Range;
                        cellRange2.Text = "0.3";
                        cellRange2 = paymentsTable2.Cell(1, 5).Range;
                        cellRange2.Text = "0.4";
                        cellRange2 = paymentsTable2.Cell(2, 1).Range;
                        cellRange2.Text = "P(X)";
                        cellRange2 = paymentsTable2.Cell(2, 2).Range;
                        cellRange2.Text = Answer11[1, 0];
                        cellRange2 = paymentsTable2.Cell(2, 3).Range;
                        cellRange2.Text = Answer11[1, 1];
                        cellRange2 = paymentsTable2.Cell(2, 4).Range;
                        cellRange2.Text = Answer11[1, 2];
                        cellRange2 = paymentsTable2.Cell(2, 5).Range;
                        cellRange2.Text = Answer11[1, 3];
                    }
                    if (pipu == 10)
                    {
                        Word.Paragraph userParagrapth1 = document1.Paragraphs.Add();
                        Word.Range userRange1 = userParagrapth1.Range;

                        Word.Paragraph tableParagraph1 = document1.Paragraphs.Add();
                        Word.Range tableRange1 = tableParagraph1.Range;

                        Word.Table paymentsTable1 = document1.Tables.Add(tableRange1, allCategories.Count() + 1, 6);
                        paymentsTable1.Borders.InsideLineStyle = paymentsTable1.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                        paymentsTable1.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                        Word.Range cellRange;

                        cellRange = paymentsTable1.Cell(1, 1).Range;
                        cellRange.Text = "X";
                        cellRange = paymentsTable1.Cell(1, 2).Range;
                        cellRange.Text = "0.1";
                        cellRange = paymentsTable1.Cell(1, 3).Range;
                        cellRange.Text = "0.2";
                        cellRange = paymentsTable1.Cell(1, 4).Range;
                        cellRange.Text = "0.3";
                        cellRange = paymentsTable1.Cell(1, 5).Range;
                        cellRange.Text = "0.4";
                        cellRange = paymentsTable1.Cell(1, 6).Range;
                        cellRange.Text = "0.5";
                        cellRange = paymentsTable1.Cell(2, 1).Range;
                        cellRange.Text = "P(X)";
                        cellRange = paymentsTable1.Cell(2, 2).Range;
                        cellRange.Text = Answer11[1, 0];
                        cellRange = paymentsTable1.Cell(2, 3).Range;
                        cellRange.Text = "";
                        cellRange = paymentsTable1.Cell(2, 4).Range;
                        cellRange.Text = Answer11[1, 2];
                        cellRange = paymentsTable1.Cell(2, 5).Range;
                        cellRange.Text = Answer11[1, 3];
                        cellRange = paymentsTable1.Cell(2, 6).Range;
                        cellRange.Text = Answer11[1, 4];

                        Word.Paragraph userParagrapth2 = document2.Paragraphs.Add();
                        Word.Range userRange2 = userParagrapth2.Range;

                        Word.Paragraph tableParagraph2 = document2.Paragraphs.Add();
                        Word.Range tableRange2 = tableParagraph2.Range;

                        Word.Table paymentsTable2 = document2.Tables.Add(tableRange2, allCategories.Count() + 1, 6);
                        paymentsTable2.Borders.InsideLineStyle = paymentsTable2.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                        paymentsTable2.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                        Word.Range cellRange2;

                        cellRange2 = paymentsTable2.Cell(1, 1).Range;
                        cellRange2.Text = "X";
                        cellRange2 = paymentsTable2.Cell(1, 2).Range;
                        cellRange2.Text = "0.1";
                        cellRange2 = paymentsTable2.Cell(1, 3).Range;
                        cellRange2.Text = "0.2";
                        cellRange2 = paymentsTable2.Cell(1, 4).Range;
                        cellRange2.Text = "0.3";
                        cellRange2 = paymentsTable2.Cell(1, 5).Range;
                        cellRange2.Text = "0.4";
                        cellRange2 = paymentsTable2.Cell(1, 6).Range;
                        cellRange2.Text = "0.5";
                        cellRange2 = paymentsTable2.Cell(2, 1).Range;
                        cellRange2.Text = "P(X)";
                        cellRange2 = paymentsTable2.Cell(2, 2).Range;
                        cellRange2.Text = Answer11[1, 0];
                        cellRange2 = paymentsTable2.Cell(2, 3).Range;
                        cellRange2.Text = Answer11[1, 1];
                        cellRange2 = paymentsTable2.Cell(2, 4).Range;
                        cellRange2.Text = Answer11[1, 2];
                        cellRange2 = paymentsTable2.Cell(2, 5).Range;
                        cellRange2.Text = Answer11[1, 3];
                        cellRange2 = paymentsTable2.Cell(2, 6).Range;
                        cellRange2.Text = Answer11[1, 4];
                    }
                    if (pipu == 12)
                    {
                        Word.Paragraph userParagrapth1 = document1.Paragraphs.Add();
                        Word.Range userRange1 = userParagrapth1.Range;

                        Word.Paragraph tableParagraph1 = document1.Paragraphs.Add();
                        Word.Range tableRange1 = tableParagraph1.Range;

                        Word.Table paymentsTable1 = document1.Tables.Add(tableRange1, allCategories.Count() + 1, 7);
                        paymentsTable1.Borders.InsideLineStyle = paymentsTable1.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                        paymentsTable1.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                        Word.Range cellRange;

                        cellRange = paymentsTable1.Cell(1, 1).Range;
                        cellRange.Text = "X";
                        cellRange = paymentsTable1.Cell(1, 2).Range;
                        cellRange.Text = "0.1";
                        cellRange = paymentsTable1.Cell(1, 3).Range;
                        cellRange.Text = "0.2";
                        cellRange = paymentsTable1.Cell(1, 4).Range;
                        cellRange.Text = "0.3";
                        cellRange = paymentsTable1.Cell(1, 5).Range;
                        cellRange.Text = "0.4";
                        cellRange = paymentsTable1.Cell(1, 6).Range;
                        cellRange.Text = "0.5";
                        cellRange = paymentsTable1.Cell(1, 7).Range;
                        cellRange.Text = "0.6";
                        cellRange = paymentsTable1.Cell(2, 1).Range;
                        cellRange.Text = "P(X)";
                        cellRange = paymentsTable1.Cell(2, 2).Range;
                        cellRange.Text = Answer11[1, 0];
                        cellRange = paymentsTable1.Cell(2, 3).Range;
                        cellRange.Text = "";
                        cellRange = paymentsTable1.Cell(2, 4).Range;
                        cellRange.Text = Answer11[1, 2];
                        cellRange = paymentsTable1.Cell(2, 5).Range;
                        cellRange.Text = Answer11[1, 3];
                        cellRange = paymentsTable1.Cell(2, 6).Range;
                        cellRange.Text = Answer11[1, 4];
                        cellRange = paymentsTable1.Cell(2, 7).Range;
                        cellRange.Text = Answer11[1, 5];

                        Word.Paragraph userParagrapth2 = document2.Paragraphs.Add();
                        Word.Range userRange2 = userParagrapth2.Range;

                        Word.Paragraph tableParagraph2 = document2.Paragraphs.Add();
                        Word.Range tableRange2 = tableParagraph2.Range;

                        Word.Table paymentsTable2 = document2.Tables.Add(tableRange2, allCategories.Count() + 1, 7);
                        paymentsTable2.Borders.InsideLineStyle = paymentsTable2.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                        paymentsTable2.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                        Word.Range cellRange2;

                        cellRange2 = paymentsTable2.Cell(1, 1).Range;
                        cellRange2.Text = "X";
                        cellRange2 = paymentsTable2.Cell(1, 2).Range;
                        cellRange2.Text = "0.1";
                        cellRange2 = paymentsTable2.Cell(1, 3).Range;
                        cellRange2.Text = "0.2";
                        cellRange2 = paymentsTable2.Cell(1, 4).Range;
                        cellRange2.Text = "0.3";
                        cellRange2 = paymentsTable2.Cell(1, 5).Range;
                        cellRange2.Text = "0.4";
                        cellRange2 = paymentsTable2.Cell(1, 6).Range;
                        cellRange2.Text = "0.5";
                        cellRange2 = paymentsTable2.Cell(1, 7).Range;
                        cellRange2.Text = "0.6";
                        cellRange2 = paymentsTable2.Cell(2, 1).Range;
                        cellRange2.Text = "P(X)";
                        cellRange2 = paymentsTable2.Cell(2, 2).Range;
                        cellRange2.Text = Answer11[1, 0];
                        cellRange2 = paymentsTable2.Cell(2, 3).Range;
                        cellRange2.Text = Answer11[1, 1];
                        cellRange2 = paymentsTable2.Cell(2, 4).Range;
                        cellRange2.Text = Answer11[1, 2];
                        cellRange2 = paymentsTable2.Cell(2, 5).Range;
                        cellRange2.Text = Answer11[1, 3];
                        cellRange2 = paymentsTable2.Cell(2, 6).Range;
                        cellRange2.Text = Answer11[1, 4];
                        cellRange2 = paymentsTable2.Cell(2, 7).Range;
                        cellRange2.Text = Answer11[1, 5];
                    }

                    Test1.Text += "\n" + "Найти P(0.2),функцию распределения F(x).Построить многоугольник распределения.";

                    //12
                    string[] Result = EG.TestGeneric12(Answer11);

                    //13

                    //14

                    //15
                    string result1 = Answer15[3];
                    n = Answer15[0];
                    k = Answer15[1];
                    p = Answer15[2];

                    text = label15.Text;
                    text = text.Replace("n", n);
                    text = text.Replace("k", k);
                    text = text.Replace("p", p);
                    label15.Text = text;

                    //16
                    string a = Answer16[0];
                    string sig = Answer16[1];
                    string x1 = Answer16[2];
                    string x2 = Answer16[3];
                    result2 = Answer16[4];

                    text = label16.Text;
                    text = text.Replace("z", a);
                    text = text.Replace("b", sig);
                    text = text.Replace("x1", x1);
                    text = text.Replace("x2", x2);
                    label16.Text = text;

                    //17
                    a = Answer17[0];
                    sig = Answer17[1];
                    x1 = Answer17[2];
                    x2 = Answer17[3];
                    result3 = Answer17[4];

                    text = label17.Text;
                    text = text.Replace("z", a);
                    text = text.Replace("b", sig);
                    text = text.Replace("x1", x1);
                    text = text.Replace("x2", x2);
                    label17.Text = text;

                    //18

                    Result = EG.AnswerGeneric18(Answer18);

                    Word.Paragraph objN = document1.Paragraphs.Add();
                    Word.Range TestN = objN.Range;
                    TestN.Text = "12)" + label12.Text + "\n" +
                        "13)" + label13.Text + "\n" + "Func = " + Answer13[0] + "\n" + "(" + Answer13[1] + " ; " + Answer13[2] + "]" + "\nP(Eps) = " + Answer13[8] + "\n" +
                        "14)" + label14.Text + "\n" +
                        "15)" + label15.Text + "\n" +
                        "16)" + label16.Text + "\n" +
                        "17)" + label17.Text + "\n" +
                        "18)" + label18.Text + "\n";

                    Word.Paragraph obj3 = document2.Paragraphs.Add();
                    Word.Range Test3 = obj3.Range;
                    Test3.Text = "12)" + "\nM(E) = " + Result[0] + "D(E) = " + Result[1] + "Sig(E) = " + Result[2] + "\n" +
                        "13)" + "При x <= a это " + Answer13[3] + "\nПри a < x <= b это " + Answer13[4] + "\nПри b < x это " + Answer13[5] + "\n" +
                        "14)" + "M(E) = " + Answer13[9] + "\nD(E) = " + Answer13[10] + "\nSig(E) = " + Answer13[11] + "\n" +
                        "15)" + result1 + "\n" +
                        "16)" + result2 + "\n" +
                        "17)" + result3 + "\n" +
                        "18)" + " M(E) = " + Result[0] + "\n M(n) = " + Result[1] + "\n M(E,n) = " + Result[2] + "\n D(E) = " + Result[3] + "\n D(n) = " + Result[4] + "\n D(E,n) = " + Result[5] + "\n"; ;

                    Word.Paragraph tableParagraphN = document1.Paragraphs.Add();
                    Word.Range tableRangeN = tableParagraphN.Range;

                    Word.Table paymentsTableN = document1.Tables.Add(tableRangeN, allCategories.Count() + 2, 4);
                    paymentsTableN.Borders.InsideLineStyle = paymentsTableN.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    paymentsTableN.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                    Word.Range cellRange1;

                    cellRange1 = paymentsTableN.Cell(1, 1).Range;
                    cellRange1.Text = "E/n";
                    cellRange1 = paymentsTableN.Cell(1, 2).Range;
                    cellRange1.Text = "-1";
                    cellRange1 = paymentsTableN.Cell(1, 3).Range;
                    cellRange1.Text = "0";
                    cellRange1 = paymentsTableN.Cell(1, 4).Range;
                    cellRange1.Text = "1";

                    cellRange1 = paymentsTableN.Cell(2, 1).Range;
                    cellRange1.Text = "0";
                    cellRange1 = paymentsTableN.Cell(2, 2).Range;
                    cellRange1.Text = Answer18[1, 1];
                    cellRange1 = paymentsTableN.Cell(2, 3).Range;
                    cellRange1.Text = Answer18[1, 2];
                    cellRange1 = paymentsTableN.Cell(2, 4).Range;
                    cellRange1.Text = Answer18[1, 3];

                    cellRange1 = paymentsTableN.Cell(3, 1).Range;
                    cellRange1.Text = "1";
                    cellRange1 = paymentsTableN.Cell(3, 2).Range;
                    cellRange1.Text = Answer18[2, 1];
                    cellRange1 = paymentsTableN.Cell(3, 3).Range;
                    cellRange1.Text = Answer18[2, 2];
                    cellRange1 = paymentsTableN.Cell(3, 4).Range;
                    cellRange1.Text = Answer18[2, 3];

                    document1.SaveAs2(@"" + Path1);
                    document2.SaveAs2(@"" + Path2);
                    number_of_options++;
                }
            }

            //1-10
            if (checkBox2.Checked == true)
            {
                for (int i = 0; i < number_of_human; i++)//записть нужного кол-ва вопросов в файл
                {
                    ExerciseGenerator EG = new ExerciseGenerator();

                    string[] Answer1 = EG.TestGeneric1();
                    string[] Answer2 = EG.TestGeneric2();
                    string[] Answer3 = EG.TestGeneric3();
                    string[] Answer4 = EG.TestGeneric4();
                    string[] Answer5 = EG.TestGeneric5();
                    string[] Answer6 = EG.TestGeneric6();
                    string[] Answer7 = EG.TestGeneric7();
                    string[] Answer8 = EG.TestGeneric8();
                    string[] Answer9 = EG.TestGeneric9();
                    string[] Answer10 = EG.TestGeneric10();

                    string result1_1 = Answer1[4];
                    string result1_2 = Answer1[5];
                    string result1_3 = Answer1[6];

                    StartTest();
                    labelV.Text = "Вариант №" + number_of_options + "\n";
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

                    //1
                    string n = Answer1[0];
                    string kek = Answer1[1];
                    string k = Answer1[2];
                    string m = Answer1[3];

                    string text = label1.Text;
                    text = text.Replace("n", n);
                    text = text.Replace("p", kek);
                    text = text.Replace("k", k);
                    text = text.Replace("m", m);
                    label1.Text = text;
                    //2
                    string result2 = Answer2[5];
                    n = Answer2[0];
                    kek = Answer2[1];
                    k = Answer2[2];
                    m = Answer2[3];
                    string l = Answer2[4];

                    text = label2.Text;
                    text = text.Replace("n", n);
                    text = text.Replace("k", k);
                    text = text.Replace("p", kek);
                    text = text.Replace("m", m);
                    text = text.Replace("j", l);
                    label2.Text = text;
                    //3
                    string result3 = Answer3[2];
                    n = Answer3[0];
                    k = Answer3[1];

                    text = label3.Text;
                    text = text.Replace("n", n);
                    text = text.Replace("k", k);
                    label3.Text = text;
                    //4
                    string result4 = Answer4[3];
                    n = Answer4[0];
                    k = Answer4[1];
                    m = Answer4[2];

                    text = label4.Text;
                    text = text.Replace("n", n);
                    text = text.Replace("k", k);
                    text = text.Replace("m", m);
                    label4.Text = text;
                    //5
                    string result5 = Answer5[3];
                    n = Answer5[0];
                    k = Answer5[1];
                    m = Answer5[2];

                    text = label5.Text;
                    text = text.Replace("n", n);
                    text = text.Replace("k", k);
                    text = text.Replace("m", m);
                    label5.Text = text;
                    //6
                    string result6 = Answer6[3];
                    string p1 = Answer6[0];
                    string p2 = Answer6[1];
                    string p3 = Answer6[2];

                    text = label6.Text;
                    text = text.Replace("a", p1);
                    text = text.Replace("b", p2);
                    text = text.Replace("c", p3);
                    label6.Text = text;
                    //7
                    string result7 = Answer7[2];
                    p1 = Answer7[0];
                    p2 = Answer7[1];

                    text = label7.Text;
                    text = text.Replace("a", p1);
                    text = text.Replace("b", p2);
                    label7.Text = text;
                    //8
                    string result8 = Answer8[2];
                    string h1 = Answer8[0];
                    string h2 = Answer8[1];

                    text = label8.Text;
                    text = text.Replace("m", h1);
                    text = text.Replace("n", h2);
                    label8.Text = text;
                    //9
                    string result9 = Answer9[2];
                    string b1 = Answer9[0];
                    string b2 = Answer9[1];

                    text = label9.Text;
                    text = text.Replace("m", b1);
                    text = text.Replace("n", b2);
                    label9.Text = text;
                    //10
                    string result10 = Answer10[3];
                    n = Answer10[0];
                    k = Answer10[1];
                    string p = Answer10[2];

                    text = label10.Text;
                    text = text.Replace("n", n);
                    text = text.Replace("k", k);
                    text = text.Replace("p", p);
                    label10.Text = text;

                    Word.Paragraph obj1 = document1.Paragraphs.Add();
                    Word.Range Test = obj1.Range;
                    Test.Text = labeln.Text + "\n" + labelV.Text +
                        "1)" + label1.Text + "\n" +
                        "2)" + label2.Text + "\n" +
                        "3)" + label3.Text + "\n" +
                        "4)" + label4.Text + "\n" +
                        "5)" + label5.Text + "\n" +
                        "6)" + label6.Text + "\n" +
                        "7)" + label7.Text + "\n" +
                        "8)" + label8.Text + "\n" +
                        "9)" + label9.Text + "\n" +
                        "10)" + label10.Text + "\n";

                    Word.Paragraph obj2 = document2.Paragraphs.Add();
                    Word.Range Answer = obj2.Range;
                    Answer.Text = labelV.Text +
                        "1) a)" + result1_1 + " b)" + result1_2 + " c)" + result1_3 + "\n" +
                        "2)" + result2 + "\n" +
                        "3)" + result3 + "\n" +
                        "4)" + result4 + "\n" +
                        "5)" + result5 + "\n" +
                        "6)" + result6 + "\n" +
                        "7)" + result7 + "\n" +
                        "8)" + result8 + "\n" +
                        "9)" + result9 + "\n" +
                        "10)" + result10 + "\n";

                    document1.SaveAs2(@"" + Path1);
                    document2.SaveAs2(@"" + Path2);
                    number_of_options++;
                }
            }

            //11-18
            if (checkBox3.Checked == true)
            {
                for (int i = 0; i < number_of_human; i++)//записть нужного кол-ва вопросов в файл
                {
                    ExerciseGenerator EG = new ExerciseGenerator();

                    string[,] Answer11 = EG.TestGeneric11();
                    string[] Answer13 = EG.TestGeneric13_14();
                    string[] Answer15 = EG.TestGeneric15();
                    string[] Answer16 = EG.TestGeneric16();
                    string[] Answer17 = EG.TestGeneric17();
                    string[,] Answer18 = EG.TableGeneric18();

                    StartTest();
                    labelV.Text = "Вариант №" + number_of_options + "\n";
                    MixQuestion11();
                    MixQuestion12();
                    MixQuestion13();
                    MixQuestion14();
                    MixQuestion15();
                    MixQuestion16();
                    MixQuestion17();
                    MixQuestion18();
                    MixName();

                    //11
                    int pipu = Answer11.Length;

                    Word.Paragraph obj99 = document1.Paragraphs.Add();
                    Word.Range Test99 = obj99.Range;
                    Test99.Text = labeln.Text;

                    Word.Paragraph obj1 = document1.Paragraphs.Add();
                    Word.Range Test1 = obj1.Range;
                    Test1.Text = "\n" + labelV.Text + "11)" + label11.Text;

                    Word.Paragraph obj2 = document2.Paragraphs.Add();
                    Word.Range Test2 = obj2.Range;
                    Test2.Text = labelV.Text + "11)";

                    if (pipu == 8)
                    {
                        Word.Paragraph userParagrapth1 = document1.Paragraphs.Add();
                        Word.Range userRange1 = userParagrapth1.Range;

                        Word.Paragraph tableParagraph1 = document1.Paragraphs.Add();
                        Word.Range tableRange1 = tableParagraph1.Range;

                        Word.Table paymentsTable1 = document1.Tables.Add(tableRange1, allCategories.Count() + 1, 5);
                        paymentsTable1.Borders.InsideLineStyle = paymentsTable1.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                        paymentsTable1.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                        Word.Range cellRange;

                        cellRange = paymentsTable1.Cell(1, 1).Range;
                        cellRange.Text = "X";
                        cellRange = paymentsTable1.Cell(1, 2).Range;
                        cellRange.Text = "0.1";
                        cellRange = paymentsTable1.Cell(1, 3).Range;
                        cellRange.Text = "0.2";
                        cellRange = paymentsTable1.Cell(1, 4).Range;
                        cellRange.Text = "0.3";
                        cellRange = paymentsTable1.Cell(1, 5).Range;
                        cellRange.Text = "0.4";
                        cellRange = paymentsTable1.Cell(2, 1).Range;
                        cellRange.Text = "P(X)";
                        cellRange = paymentsTable1.Cell(2, 2).Range;
                        cellRange.Text = Answer11[1, 0];
                        cellRange = paymentsTable1.Cell(2, 3).Range;
                        cellRange.Text = "";
                        cellRange = paymentsTable1.Cell(2, 4).Range;
                        cellRange.Text = Answer11[1, 2];
                        cellRange = paymentsTable1.Cell(2, 5).Range;
                        cellRange.Text = Answer11[1, 3];

                        Word.Paragraph userParagrapth2 = document2.Paragraphs.Add();
                        Word.Range userRange2 = userParagrapth2.Range;

                        Word.Paragraph tableParagraph2 = document2.Paragraphs.Add();
                        Word.Range tableRange2 = tableParagraph2.Range;

                        Word.Table paymentsTable2 = document2.Tables.Add(tableRange2, allCategories.Count() + 1, 5);
                        paymentsTable2.Borders.InsideLineStyle = paymentsTable2.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                        paymentsTable2.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                        Word.Range cellRange2;

                        cellRange2 = paymentsTable2.Cell(1, 1).Range;
                        cellRange2.Text = "X";
                        cellRange2 = paymentsTable2.Cell(1, 2).Range;
                        cellRange2.Text = "0.1";
                        cellRange2 = paymentsTable2.Cell(1, 3).Range;
                        cellRange2.Text = "0.2";
                        cellRange2 = paymentsTable2.Cell(1, 4).Range;
                        cellRange2.Text = "0.3";
                        cellRange2 = paymentsTable2.Cell(1, 5).Range;
                        cellRange2.Text = "0.4";
                        cellRange2 = paymentsTable2.Cell(2, 1).Range;
                        cellRange2.Text = "P(X)";
                        cellRange2 = paymentsTable2.Cell(2, 2).Range;
                        cellRange2.Text = Answer11[1, 0];
                        cellRange2 = paymentsTable2.Cell(2, 3).Range;
                        cellRange2.Text = Answer11[1, 1];
                        cellRange2 = paymentsTable2.Cell(2, 4).Range;
                        cellRange2.Text = Answer11[1, 2];
                        cellRange2 = paymentsTable2.Cell(2, 5).Range;
                        cellRange2.Text = Answer11[1, 3];
                    }
                    if (pipu == 10)
                    {
                        Word.Paragraph userParagrapth1 = document1.Paragraphs.Add();
                        Word.Range userRange1 = userParagrapth1.Range;

                        Word.Paragraph tableParagraph1 = document1.Paragraphs.Add();
                        Word.Range tableRange1 = tableParagraph1.Range;

                        Word.Table paymentsTable1 = document1.Tables.Add(tableRange1, allCategories.Count() + 1, 6);
                        paymentsTable1.Borders.InsideLineStyle = paymentsTable1.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                        paymentsTable1.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                        Word.Range cellRange;

                        cellRange = paymentsTable1.Cell(1, 1).Range;
                        cellRange.Text = "X";
                        cellRange = paymentsTable1.Cell(1, 2).Range;
                        cellRange.Text = "0.1";
                        cellRange = paymentsTable1.Cell(1, 3).Range;
                        cellRange.Text = "0.2";
                        cellRange = paymentsTable1.Cell(1, 4).Range;
                        cellRange.Text = "0.3";
                        cellRange = paymentsTable1.Cell(1, 5).Range;
                        cellRange.Text = "0.4";
                        cellRange = paymentsTable1.Cell(1, 6).Range;
                        cellRange.Text = "0.5";
                        cellRange = paymentsTable1.Cell(2, 1).Range;
                        cellRange.Text = "P(X)";
                        cellRange = paymentsTable1.Cell(2, 2).Range;
                        cellRange.Text = Answer11[1, 0];
                        cellRange = paymentsTable1.Cell(2, 3).Range;
                        cellRange.Text = "";
                        cellRange = paymentsTable1.Cell(2, 4).Range;
                        cellRange.Text = Answer11[1, 2];
                        cellRange = paymentsTable1.Cell(2, 5).Range;
                        cellRange.Text = Answer11[1, 3];
                        cellRange = paymentsTable1.Cell(2, 6).Range;
                        cellRange.Text = Answer11[1, 4];

                        Word.Paragraph userParagrapth2 = document2.Paragraphs.Add();
                        Word.Range userRange2 = userParagrapth2.Range;

                        Word.Paragraph tableParagraph2 = document2.Paragraphs.Add();
                        Word.Range tableRange2 = tableParagraph2.Range;

                        Word.Table paymentsTable2 = document2.Tables.Add(tableRange2, allCategories.Count() + 1, 6);
                        paymentsTable2.Borders.InsideLineStyle = paymentsTable2.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                        paymentsTable2.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                        Word.Range cellRange2;

                        cellRange2 = paymentsTable2.Cell(1, 1).Range;
                        cellRange2.Text = "X";
                        cellRange2 = paymentsTable2.Cell(1, 2).Range;
                        cellRange2.Text = "0.1";
                        cellRange2 = paymentsTable2.Cell(1, 3).Range;
                        cellRange2.Text = "0.2";
                        cellRange2 = paymentsTable2.Cell(1, 4).Range;
                        cellRange2.Text = "0.3";
                        cellRange2 = paymentsTable2.Cell(1, 5).Range;
                        cellRange2.Text = "0.4";
                        cellRange2 = paymentsTable2.Cell(1, 6).Range;
                        cellRange2.Text = "0.5";
                        cellRange2 = paymentsTable2.Cell(2, 1).Range;
                        cellRange2.Text = "P(X)";
                        cellRange2 = paymentsTable2.Cell(2, 2).Range;
                        cellRange2.Text = Answer11[1, 0];
                        cellRange2 = paymentsTable2.Cell(2, 3).Range;
                        cellRange2.Text = Answer11[1, 1];
                        cellRange2 = paymentsTable2.Cell(2, 4).Range;
                        cellRange2.Text = Answer11[1, 2];
                        cellRange2 = paymentsTable2.Cell(2, 5).Range;
                        cellRange2.Text = Answer11[1, 3];
                        cellRange2 = paymentsTable2.Cell(2, 6).Range;
                        cellRange2.Text = Answer11[1, 4];
                    }
                    if (pipu == 12)
                    {
                        Word.Paragraph userParagrapth1 = document1.Paragraphs.Add();
                        Word.Range userRange1 = userParagrapth1.Range;

                        Word.Paragraph tableParagraph1 = document1.Paragraphs.Add();
                        Word.Range tableRange1 = tableParagraph1.Range;

                        Word.Table paymentsTable1 = document1.Tables.Add(tableRange1, allCategories.Count() + 1, 7);
                        paymentsTable1.Borders.InsideLineStyle = paymentsTable1.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                        paymentsTable1.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                        Word.Range cellRange;

                        cellRange = paymentsTable1.Cell(1, 1).Range;
                        cellRange.Text = "X";
                        cellRange = paymentsTable1.Cell(1, 2).Range;
                        cellRange.Text = "0.1";
                        cellRange = paymentsTable1.Cell(1, 3).Range;
                        cellRange.Text = "0.2";
                        cellRange = paymentsTable1.Cell(1, 4).Range;
                        cellRange.Text = "0.3";
                        cellRange = paymentsTable1.Cell(1, 5).Range;
                        cellRange.Text = "0.4";
                        cellRange = paymentsTable1.Cell(1, 6).Range;
                        cellRange.Text = "0.5";
                        cellRange = paymentsTable1.Cell(1, 7).Range;
                        cellRange.Text = "0.6";
                        cellRange = paymentsTable1.Cell(2, 1).Range;
                        cellRange.Text = "P(X)";
                        cellRange = paymentsTable1.Cell(2, 2).Range;
                        cellRange.Text = Answer11[1, 0];
                        cellRange = paymentsTable1.Cell(2, 3).Range;
                        cellRange.Text = "";
                        cellRange = paymentsTable1.Cell(2, 4).Range;
                        cellRange.Text = Answer11[1, 2];
                        cellRange = paymentsTable1.Cell(2, 5).Range;
                        cellRange.Text = Answer11[1, 3];
                        cellRange = paymentsTable1.Cell(2, 6).Range;
                        cellRange.Text = Answer11[1, 4];
                        cellRange = paymentsTable1.Cell(2, 7).Range;
                        cellRange.Text = Answer11[1, 5];

                        Word.Paragraph userParagrapth2 = document2.Paragraphs.Add();
                        Word.Range userRange2 = userParagrapth2.Range;

                        Word.Paragraph tableParagraph2 = document2.Paragraphs.Add();
                        Word.Range tableRange2 = tableParagraph2.Range;

                        Word.Table paymentsTable2 = document2.Tables.Add(tableRange2, allCategories.Count() + 1, 7);
                        paymentsTable2.Borders.InsideLineStyle = paymentsTable2.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                        paymentsTable2.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                        Word.Range cellRange2;

                        cellRange2 = paymentsTable2.Cell(1, 1).Range;
                        cellRange2.Text = "X";
                        cellRange2 = paymentsTable2.Cell(1, 2).Range;
                        cellRange2.Text = "0.1";
                        cellRange2 = paymentsTable2.Cell(1, 3).Range;
                        cellRange2.Text = "0.2";
                        cellRange2 = paymentsTable2.Cell(1, 4).Range;
                        cellRange2.Text = "0.3";
                        cellRange2 = paymentsTable2.Cell(1, 5).Range;
                        cellRange2.Text = "0.4";
                        cellRange2 = paymentsTable2.Cell(1, 6).Range;
                        cellRange2.Text = "0.5";
                        cellRange2 = paymentsTable2.Cell(1, 7).Range;
                        cellRange2.Text = "0.6";
                        cellRange2 = paymentsTable2.Cell(2, 1).Range;
                        cellRange2.Text = "P(X)";
                        cellRange2 = paymentsTable2.Cell(2, 2).Range;
                        cellRange2.Text = Answer11[1, 0];
                        cellRange2 = paymentsTable2.Cell(2, 3).Range;
                        cellRange2.Text = Answer11[1, 1];
                        cellRange2 = paymentsTable2.Cell(2, 4).Range;
                        cellRange2.Text = Answer11[1, 2];
                        cellRange2 = paymentsTable2.Cell(2, 5).Range;
                        cellRange2.Text = Answer11[1, 3];
                        cellRange2 = paymentsTable2.Cell(2, 6).Range;
                        cellRange2.Text = Answer11[1, 4];
                        cellRange2 = paymentsTable2.Cell(2, 7).Range;
                        cellRange2.Text = Answer11[1, 5];
                    }

                    Test1.Text += "\nНайти P(0.2),функцию распределения F(x).Построить многоугольник распределения.";

                    //12
                    string[] Result = EG.TestGeneric12(Answer11);

                    //13

                    //14

                    //15
                    string result1 = Answer15[3];
                    string n = Answer15[0];
                    string k = Answer15[1];
                    string p = Answer15[2];

                    string text = label15.Text;
                    text = text.Replace("n", n);
                    text = text.Replace("k", k);
                    text = text.Replace("p", p);
                    label15.Text = text;

                    //16
                    string a = Answer16[0];
                    string sig = Answer16[1];
                    string x1 = Answer16[2];
                    string x2 = Answer16[3];
                    string result2 = Answer16[4];

                    text = label16.Text;
                    text = text.Replace("z", a);
                    text = text.Replace("b", sig);
                    text = text.Replace("x1", x1);
                    text = text.Replace("x2", x2);
                    label16.Text = text;

                    //17
                    a = Answer17[0];
                    sig = Answer17[1];
                    x1 = Answer17[2];
                    x2 = Answer17[3];
                    string result3 = Answer17[4];

                    text = label17.Text;
                    text = text.Replace("z", a);
                    text = text.Replace("b", sig);
                    text = text.Replace("x1", x1);
                    text = text.Replace("x2", x2);
                    label17.Text = text;

                    //18
                    Result = EG.AnswerGeneric18(Answer18);

                    Word.Paragraph objN = document1.Paragraphs.Add();
                    Word.Range TestN = objN.Range;
                    TestN.Text = "12)" + label12.Text + "\n" +
                        "13)" + label13.Text + "\n" + "Func = " + Answer13[0] + "\n" + "(" + Answer13[1] + " ; " + Answer13[2] + "]" + "\nP(Eps) = " + Answer13[8] + "\n" +
                        "14)" + label14.Text + "\n" +
                        "15)" + label15.Text + "\n" +
                        "16)" + label16.Text + "\n" +
                        "17)" + label17.Text + "\n" +
                        "18)" + label18.Text + "\n";

                    Word.Paragraph obj3 = document2.Paragraphs.Add();
                    Word.Range Test3 = obj3.Range;
                    Test3.Text = "12)" + "\nM(E) = " + Result[0] + "D(E) = " + Result[1] + "Sig(E) = " + Result[2] + "\n" +
                        "13)" + "При x <= a это " + Answer13[3] + "\nПри a < x <= b это " + Answer13[4] + "\nПри b < x это " + Answer13[5] + "\n" +
                        "14)" + "M(E) = " + Answer13[9] + "\nD(E) = " + Answer13[10] + "\nSig(E) = " + Answer13[11] + "\n" +
                        "15)" + result1 + "\n" +
                        "16)" + result2 + "\n" +
                        "17)" + result3 + "\n" +
                        "18)" + " M(E) = " + Result[0] + "\n M(n) = " + Result[1] + "\n M(E,n) = " + Result[2] + "\n D(E) = " + Result[3] + "\n D(n) = " + Result[4] + "\n D(E,n) = " + Result[5] + "\n"; ;

                    Word.Paragraph tableParagraphN = document1.Paragraphs.Add();
                    Word.Range tableRangeN = tableParagraphN.Range;

                    Word.Table paymentsTableN = document1.Tables.Add(tableRangeN, allCategories.Count() + 2, 4);
                    paymentsTableN.Borders.InsideLineStyle = paymentsTableN.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    paymentsTableN.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                    Word.Range cellRange1;

                    cellRange1 = paymentsTableN.Cell(1, 1).Range;
                    cellRange1.Text = "E/n";
                    cellRange1 = paymentsTableN.Cell(1, 2).Range;
                    cellRange1.Text = "-1";
                    cellRange1 = paymentsTableN.Cell(1, 3).Range;
                    cellRange1.Text = "0";
                    cellRange1 = paymentsTableN.Cell(1, 4).Range;
                    cellRange1.Text = "1";

                    cellRange1 = paymentsTableN.Cell(2, 1).Range;
                    cellRange1.Text = "0";
                    cellRange1 = paymentsTableN.Cell(2, 2).Range;
                    cellRange1.Text = Answer18[1, 1];
                    cellRange1 = paymentsTableN.Cell(2, 3).Range;
                    cellRange1.Text = Answer18[1, 2];
                    cellRange1 = paymentsTableN.Cell(2, 4).Range;
                    cellRange1.Text = Answer18[1, 3];

                    cellRange1 = paymentsTableN.Cell(3, 1).Range;
                    cellRange1.Text = "1";
                    cellRange1 = paymentsTableN.Cell(3, 2).Range;
                    cellRange1.Text = Answer18[2, 1];
                    cellRange1 = paymentsTableN.Cell(3, 3).Range;
                    cellRange1.Text = Answer18[2, 2];
                    cellRange1 = paymentsTableN.Cell(3, 4).Range;
                    cellRange1.Text = Answer18[2, 3];

                    document1.SaveAs2(@"" + Path1);
                    document2.SaveAs2(@"" + Path2);
                    number_of_options++;
                }
            }

            document1.Close();
            document2.Close();
            MessageBox.Show("Тест составлен в файл " + textBox1.Text + "!!!");
            Environment.Exit(0);
        }

        //крысинное скрытие label-ов и не только
        private void FormTest_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

            button_GenerateTest.Visible = false;
            button_SaveFileAnswer.Visible = false;

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
            label20.Visible = false;

            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;

            textBox1.Visible = false;
            textBox2.Visible = false;
            WritePath1.Visible = false;
            WritePath2.Visible = false;
        }

        private void button_SaveFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();//создаём объект класса для работы с открытием файла

            openFileDialog.Filter = "Tests(*.docx)|*.docx|All files(*.*)|*.*";//фильтр,конструкция немного норкоманская,как работает доподлинно не знаю,но если надо сменить формат
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

            label19.Visible = true;
            textBox1.Visible = true;
            button_SaveFileAnswer.Visible = true;
        }

        private void button_SaveFileAnswer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();//создаём объект класса для работы с открытием файла

            openFileDialog.Filter = "Tests(*.docx)|*.docx|All files(*.*)|*.*";//фильтр,конструкция немного наркоманская,как работает доподлинно не знаю,но если надо сменить формат
                                                                              //то просто замени .doc на то что надо

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)//тип если он не открылся по какой-то причине,то у нас проблемы
            {
                return;
            }

            string filename1 = openFileDialog.FileName;//получаем в строку имя файла с расширением(из-за это писать его в WritePath и в коде не нужно(я про расширение)
            string filename2 = openFileDialog.SafeFileName;

            WritePath2.Text = filename1;
            textBox2.Text = filename2;

            MessageBox.Show("Файл для ответов принят!!");
            label20.Visible = true;
            textBox2.Visible = true;
            groupBox1.Visible = true;
            button_GenerateTest.Visible = true;
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