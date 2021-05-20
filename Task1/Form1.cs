using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Robot robot1 = new Robot();
            robot1.Name = "Walle";
            robot1.Home = "Mars";
            robot1.Occupation = "Mars Minister";
            robot1.Weight = 50;
            label1.Text = robot1.Introduce();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Robot robot2 = new Robot();
            robot2.Name = "Eve";
            robot2.Home = "Earth";
            robot2.Occupation = "Mars Minister";
            robot2.Weight = 50;
            label2.Text = robot2.Introduce();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
