using System;
using System.IO;
using System.Windows.Forms;

namespace Test
{
    public partial class FormTest : Form
    {
        StreamReader number1;//для задания 1
        StreamReader number2;//для задания 2

        StreamReader surname;//для ФИО

        int number_of_questions = 0;//переменная кол-ва человеков


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
            string dest = Directory.GetCurrentDirectory() + @"\Number1.txt";
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
            string dest = Directory.GetCurrentDirectory() + @"\Number2.txt";
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
                // Создание экземпляра StreamReader для чтения из файла
                number1 = new StreamReader(Directory.GetCurrentDirectory() + @"\Number1.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {   // Отчет о всех ошибках:
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                // Создание экземпляра StreamReader для чтения из файла
                surname = new StreamReader(Directory.GetCurrentDirectory() + @"\Name.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {   // Отчет о всех ошибках:
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                // Создание экземпляра StreamReader для чтения из файла
                number2 = new StreamReader(Directory.GetCurrentDirectory() + @"\Number2.txt", encoding);//место где лежит список заданий
            }
            catch (Exception message)
            {   // Отчет о всех ошибках:
                MessageBox.Show(message.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            ReadNextQuestion();
        }


        /*
         Микро фикс который можно сделать-чтобы к конце каждого вопроса в каждом задании не ставить
         ограничительный знак как этого требует 104 строка
         */

        //функция позволяющая выбрать след вопрос
        void ReadNextQuestion()
        {
            string[] name = surname.ReadLine().Split(',');

            string[] tmp1 = number1.ReadLine().Split('|');//читаем из файла до символа в скобках,и всё что получили представляем ввиде строки(надо подумать как это ограничение обойти)
            string[] tmp2 = number2.ReadLine().Split('|');

            int indexn = 0;
            int index1 = 0;
            int index2 = 0;

            labeln.Text = name[indexn++];
            label1.Text = tmp1[index1++];//label был выбран как первоночальное решение,потом приведу к красивому виду(или нет)
            label2.Text = tmp2[index2++];
        }


        //та самая кнопка в которой происходит кривая костылявая,но магия
        private void button_GenerateTest_Click(object sender, EventArgs e)
        {
            int number_of_options = 1;//счётчик для номера варианта
            string Path = WritePath.Text;
            string writePath = @"" + Path;//создание файла по пути написанному пользователем в WritePath

            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);

            //считает кол-во людей по факту(заполняет var lines строками из Name,а потом считает кол-во строк)
            string dest = Directory.GetCurrentDirectory() + @"\Name.txt";
            var lines = File.ReadAllLines(dest);
            number_of_questions = lines.Length;//кол-во человек вычисляется из кол-ва фамилий в списки Name

            for (int i = 0; i < number_of_questions; i++)//записть нужного кол-ва вопросов в файл(пока txt)
            {
                StartTest();
                sw.Write(labeln.Text + "\n");
                sw.Write("Вариант №" + number_of_options + "\n");
                MixQuestion1();
                MixQuestion2();
                MixName();

                sw.Write(label1.Text + "\n");
                sw.Write(label2.Text + "\n" + "\n");
                number_of_options++;
            }

            sw.Close();
            MessageBox.Show("Тест составлен!!!");
            button_SaveFile.Enabled = true;
        }

        //крысинное скрытие label-ов
        private void FormTest_Load(object sender, EventArgs e)
        {
            labeln.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            WritePath.Visible = false;
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

            string filename = openFileDialog.FileName;//получаем в строку имя файла с расширением(из-за это писать его в WritePath и в коде не нужно(я про расширение)

            WritePath.Text = filename;
            MessageBox.Show("Файл для теста принят!!!");
        }

        /*короче,про создание файла из того же окна что и выбор инфы крайне мало,поэтому пришлось идти костылями
        (или я просто дэбил и не могу вспомнить как создать файл,и закрыть его для чтения через File,если тот кто это читает смогёт это сделать
        будет нереально круто,а пока вот так)

        сами костыли в том что создавая файл,он автоматически выбирается главным(из-за косяка описанного выше),если пользователь создать один файл
        а записать тест захочет в другой,он этого не сможет(на кнопку выбора данный косяк зеркально не работает)
        */

        private void button_FileCreate_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "All Files (.doc)|*.doc|All Files (*.*)|*.*";
            dialog.FileName = "";

            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                File.OpenWrite(dialog.FileName);//голова не красивого костыля(см.выше)

                string filename = dialog.FileName;//получаем в строку имя файла с расширением(из-за это писать его в WritePath и в коде не нужно(я про расширение)
                WritePath.Text = filename;

                button_SaveFile.Enabled = false;//тушка не красивого костыля

                MessageBox.Show("Файл создан и принят!!!");
            }
        }
    }
}