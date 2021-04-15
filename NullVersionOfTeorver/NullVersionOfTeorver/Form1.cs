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
            string[] Answer = EG.TestGeneric1(1);

            RTBAnswer.Text = "Answer is \n n = " + Answer[0] + "\n k =" + Answer[1] + "\n m = " + Answer[2] + "\n Result = " + Answer[3];
        }

        private void button9_Click(object sender, EventArgs e)//1b
        {
            ExerciseGenerator EG = new ExerciseGenerator();
            string[] Answer = EG.TestGeneric1(2);

            RTBAnswer.Text = "Answer is \n n = " + Answer[0] + "\n k =" + Answer[1] + "\n m = " + Answer[2] + "\n Result = " + Answer[3];
        }

        private void button10_Click(object sender, EventArgs e)//1c
        {
            ExerciseGenerator EG = new ExerciseGenerator();
            string[] Answer = EG.TestGeneric1(3);

            RTBAnswer.Text = "Answer is \n n = " + Answer[0] + "\n k =" + Answer[1] + "\n m = " + Answer[2] + "\n Result = " + Answer[3];
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
        }

        private void button4_Click(object sender, EventArgs e)//6
        {
        }

        private void button5_Click(object sender, EventArgs e)//7
        {
        }

        private void button6_Click(object sender, EventArgs e)//8
        {
        }

        private void button7_Click(object sender, EventArgs e)//9
        {
        }

        private void button8_Click(object sender, EventArgs e)//10
        {
        }
    }
}
