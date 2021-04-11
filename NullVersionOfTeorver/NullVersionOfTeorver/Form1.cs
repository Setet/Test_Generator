﻿using System;
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

            double P = Exc.TestNameExc1(Int32.Parse(TB1.Text), Int32.Parse(TB2.Text), Int32.Parse(TB3.Text), Int32.Parse(TB4.Text));
            TBAnswer.Text = "Answer is " + P;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double P = Exc.TestNameExc1(Int32.Parse(TB1.Text), Int32.Parse(TB2.Text), Int32.Parse(TB3.Text), Int32.Parse(TB4.Text));
            
            P = 1 - P;
            
            TBAnswer.Text = "Answer is " + P;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double P = Exc.TestNameExc2(Int32.Parse(TB1.Text), Int32.Parse(TB2.Text), Int32.Parse(TB3.Text));
            
            P = 1 - P;

            TBAnswer.Text = "Answer is " + P;
        }
    }
}
