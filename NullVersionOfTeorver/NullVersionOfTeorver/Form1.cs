using System;
using System.Windows.Forms;
using NullVersionOfTeorver.Exercises;

namespace NullVersionOfTeorver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//1a
        {
            ExerciseGenerator EG = new ExerciseGenerator();
            string[] Answer = EG.TestGeneric1();

            RTBAnswer.Text = "Answer is \n n = " + Answer[0] + "\n k =" + Answer[1] + "\n m = " + Answer[2] + "\n ResultA = " + Answer[3] + "\n ResultB = " + Answer[4] + "\n ResultC = " + Answer[5];
        }

        private void button12_Click(object sender, EventArgs e)//2
        {
            ExerciseGenerator EG = new ExerciseGenerator();
            string[] Answer = EG.TestGeneric2();

            RTBAnswer.Text = "Answer is \n n = " + Answer[0] + "\n k =" + Answer[1] + "\n m = " + Answer[2] + "\n l = " + Answer[3] + "\n Result = " + Answer[4];
        }

        private void button11_Click(object sender, EventArgs e)//3
        {
            ExerciseGenerator EG = new ExerciseGenerator();
            string[] Answer = EG.TestGeneric3();

            RTBAnswer.Text = "Answer is \n n = " + Answer[0] + "\n k =" + Answer[1] + "\n Result = " + Answer[2];
        }

        private void button2_Click(object sender, EventArgs e)//4
        {
            ExerciseGenerator EG = new ExerciseGenerator();
            string[] Answer = EG.TestGeneric4();

            RTBAnswer.Text = "Answer is \n n = " + Answer[0] + "\n k =" + Answer[1] + "\n m = " + Answer[2] + "\n Result = " + Answer[3];
        }

        private void button3_Click(object sender, EventArgs e)//5
        {
            ExerciseGenerator EG = new ExerciseGenerator();
            string[] Answer = EG.TestGeneric5();

            RTBAnswer.Text = "Answer is \n n = " + Answer[0] + "\n k =" + Answer[1] + "\n m = " + Answer[2] + "\n Result = " + Answer[3];
        }

        private void button4_Click(object sender, EventArgs e)//6
        {
            ExerciseGenerator EG = new ExerciseGenerator();
            string[] Answer = EG.TestGeneric6();

            RTBAnswer.Text = "Answer is \n p1 = " + Answer[0] + "\n p2 =" + Answer[1] + "\n p3 = " + Answer[2] + "\n Result = " + Answer[3];
        }

        private void button5_Click(object sender, EventArgs e)//7
        {
            ExerciseGenerator EG = new ExerciseGenerator();
            string[] Answer = EG.TestGeneric7();

            RTBAnswer.Text = "Answer is \n p1 = " + Answer[0] + "\n p2 =" + Answer[1] + "\n Result = " + Answer[2];
        }

        private void button6_Click(object sender, EventArgs e)//8
        {
            ExerciseGenerator EG = new ExerciseGenerator();
            string[] Answer = EG.TestGeneric8();

            RTBAnswer.Text = "Answer is \n h1 = " + Answer[0] + "\n h2 =" + Answer[1] + "\n Result = " + Answer[2];
        }

        private void button7_Click(object sender, EventArgs e)//9
        {
            ExerciseGenerator EG = new ExerciseGenerator();
            string[] Answer = EG.TestGeneric9();

            RTBAnswer.Text = "Answer is \n b1 = " + Answer[0] + "\n b2 =" + Answer[1] + "\n Result = " + Answer[2];
        }

        private void button8_Click(object sender, EventArgs e)//10
        {
            ExerciseGenerator EG = new ExerciseGenerator();
            string[] Answer = EG.TestGeneric10();

            RTBAnswer.Text = "Answer is \n n = " + Answer[0] + "\n k =" + Answer[1] + "\n p = " + Answer[2] + "\n Result = " + Answer[3];
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ExerciseGenerator EG = new ExerciseGenerator();
            string[,] Answer = EG.TestGeneric11();
            int n = Answer.Length;

            if (n == 8)
                RTBAnswer.Text = "Answer is \n " + Answer[0, 0] + "  " + Answer[0, 1] + "  " + Answer[0, 2] + "  " + Answer[0, 3] +
                    "\n " + Answer[1, 0] + "  " + Answer[1, 1] + "  " + Answer[1, 2] + "  " + Answer[1, 3];
            if (n == 10)
                RTBAnswer.Text = "Answer is \n " + Answer[0, 0] + "  " + Answer[0, 1] + "  " + Answer[0, 2] + "  " + Answer[0, 3] + "  " + Answer[0, 4] +
                   "\n " + Answer[1, 0] + "  " + Answer[1, 1] + "  " + Answer[1, 2] + "  " + Answer[1, 3] + "  " + Answer[1, 4];
            if (n == 12)
                RTBAnswer.Text = "Answer is \n " + Answer[0, 0] + "  " + Answer[0, 1] + "  " + Answer[0, 2] + "  " + Answer[0, 3] + "  " + Answer[0, 4] + "  " + Answer[0, 5] +
                   "\n " + Answer[1, 0] + "  " + Answer[1, 1] + "  " + Answer[1, 2] + "  " + Answer[1, 3] + "  " + Answer[1, 4] + "  " + Answer[1, 5];

            string[] Result = EG.TestGeneric12(Answer);

            RTBAnswer.Text += "\n\n M(E) = " + Result[0] + "\nD(E) = " + Result[1] + "\nSig(E) = " + Result[2];
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ExerciseGenerator EG = new ExerciseGenerator();
            string[] Answer = EG.TestGeneric13_14();

            RTBAnswer.Text = "Func = " + Answer[0] + "\n (" + Answer[1] + " ; " + Answer[2] + " ]" + "\n При x <= a это " + Answer[3] +
                "\n При a < x <= b это " + Answer[4] + "\n При b < x это " + Answer[5] + "\n P( " + Answer[6] + " < Eps < " + Answer[7] + ") \nP(Eps) = " +
                Answer[8] + "\n\n M(E) = " + Answer[9] + "\nD(E) = " + Answer[10] + "\nSig(E) = " + Answer[11];
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ExerciseGenerator EG = new ExerciseGenerator();
            string[] Answer = EG.TestGeneric15();

            RTBAnswer.Text = "Answer is \n n = " + Answer[0] + "\n k =" + Answer[1] + "\n p = " + Answer[2] + "\n Result = " + Answer[3];
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ExerciseGenerator EG = new ExerciseGenerator();
            string[] Answer = EG.TestGeneric16();

            RTBAnswer.Text = "Answer is \n a = " + Answer[0] + "\n sig =" + Answer[1] + "\n x1 = " + Answer[2] + "\n x2 = " + Answer[3] + "\n Result = " + Answer[4];
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ExerciseGenerator EG = new ExerciseGenerator();
            string[] Answer = EG.TestGeneric17();

            RTBAnswer.Text = "Answer is \n a = " + Answer[0] + "\n sig =" + Answer[1] + "\n x1 = " + Answer[2] + "\n x2 = " + Answer[3] + "\n Result = " + Answer[4];
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ExerciseGenerator EG = new ExerciseGenerator();
            string[,] Answer = EG.TableGeneric18();
            RTBAnswer.Text = Answer[0, 0] + " " + Answer[0, 1] + " " + Answer[0, 2] + " " + Answer[0, 3] +
                "\n" + Answer[1, 0] + " " + Answer[1, 1] + " " + Answer[1, 2] + " " + Answer[1, 3] +
                "\n" + Answer[2, 0] + " " + Answer[2, 1] + " " + Answer[2, 2] + " " + Answer[2, 3];

            string[] Result = EG.AnswerGeneric18(Answer);
            RTBAnswer.Text += "\n M(E) = " + Result[0] + "\n M(n) = " + Result[1] + "\n M(nE) = " + Result[2] + "\n D(E) = " + Result[3] + "\n D(n) = " + Result[4] + "\n D(nE) = " + Result[5];
        }
    }
}
