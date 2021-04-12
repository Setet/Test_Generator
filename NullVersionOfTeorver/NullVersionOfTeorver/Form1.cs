using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void button1_Click(object sender, EventArgs e)
        {

            double P = ExerciseAnswer.TestNameExc1(Int32.Parse(TB1.Text), Int32.Parse(TB2.Text), Int32.Parse(TB3.Text), Int32.Parse(TB4.Text));
            TBAnswer.Text = "Answer is " + P;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double P = ExerciseAnswer.TestNameExc1(Int32.Parse(TB1.Text), Int32.Parse(TB2.Text), Int32.Parse(TB3.Text), Int32.Parse(TB4.Text));
            
            P = 1 - P;
            
            TBAnswer.Text = "Answer is " + P;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double P = ExerciseAnswer.TestNameExc2(Int32.Parse(TB1.Text), Int32.Parse(TB2.Text), Int32.Parse(TB3.Text));
            
            P = 1 - P;

            TBAnswer.Text = "Answer is " + P;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double P = ExerciseAnswer.TestNameExc3(Double.Parse(TB1.Text), Double.Parse(TB2.Text), Double.Parse(TB3.Text));

            TBAnswer.Text = "Answer is " + P;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double P = ExerciseAnswer.TestNameExc4(Double.Parse(TB1.Text), Double.Parse(TB2.Text));

            TBAnswer.Text = "Answer is " + P;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double P = ExerciseAnswer.TestNameExc5(Double.Parse(TB1.Text), Double.Parse(TB2.Text));

            TBAnswer.Text = "Answer is " + P;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double P = ExerciseAnswer.TestNameExc6(Double.Parse(TB1.Text), Double.Parse(TB2.Text));

            TBAnswer.Text = "Answer is " + P;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double P = ExerciseAnswer.TestNameExc7(Int32.Parse(TB1.Text), Int32.Parse(TB2.Text), Double.Parse(TB3.Text));

            TBAnswer.Text = "Answer is " + P;
        }
    }
}
