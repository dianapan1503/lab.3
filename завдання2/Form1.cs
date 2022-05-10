using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace завдання2
{
    public partial class Form1 : Form
    {
        DateTime date1 = new DateTime(0, 0);
       
        public Form1()
        {
           
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date1 = date1.AddSeconds(1);
            label1.Text = date1.ToString("mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actions1 actions1 = new Actions1();
            actions1.timer = timer1; 
            actions1.button = button1;

            actions1.Click();
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            button1.Text = "Почати";
        }
    }
    public class Actions1
    {
        public Timer timer { get; set; }
        public Button button { get; set; }
        public void Click()
        {
            if (timer.Enabled == true)
            {
                timer.Enabled = false;
                button.Text = "Почати";
            }
            else
            {
                timer.Enabled = true;
                button.Text = "Зупинити";
            }
        }

    }
}
