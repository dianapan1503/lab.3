using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace завдання1
{
    public partial class Form1 : Form
    {
        public int firstArg;
        public int secondArg;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        int Add() { return firstArg + secondArg;}
       
        int Subtract() { return firstArg - secondArg;}

        int Multiply() { return firstArg * secondArg;}


        private void button1_Click(object sender, EventArgs e)
        {
            firstArg = int.Parse(textBox1.Text);
            secondArg = int.Parse(textBox2.Text);

            if (textBox3.Text == "+") label1.Text += $"{Add()}";
            if (textBox3.Text == "-") label1.Text += $"{Subtract()}";
            if (textBox3.Text == "*") label1.Text += $"{Multiply()}";
            if (textBox3.Text == "/") label1.Text += $"{new DivisionCheck().Method1(firstArg,secondArg)}";

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = new TextBox[]
            {
                textBox1, textBox2, textBox3
            };
            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Enabled = true;
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Text = "";
            }
            label1.Text = "";
        }
    }
    public class DivisionCheck
    {
        public string Method1(int a, int b)
        {
            Form1 form1 = new Form1();
            if (b == 0)
            {
                return "Помилка";
            }
            return Convert.ToString(a / b);
        }
    }
}
