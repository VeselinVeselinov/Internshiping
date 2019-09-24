using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class Form1 : Form
    {
        int[] divisor = new int[] {2};
        string[] gesture = new string[] {"fizz","buzz"};


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player player = new Player(divisor, gesture,button1.Text,textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            foreach (Control item in Controls)
            {
                item.Hide();
            }
            button2.Show();
            Computer computer = new Computer();
            textBox1.Text = computer.GenerateNumber().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                item.Show();
            }
            button2.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
