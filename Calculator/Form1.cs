using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            ///ADUNARE
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = a + b;
            label1.Text = c.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            ///SCADERE
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = a - b;
            label1.Text = c.ToString();

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            ///INMULTIRE
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = a * b;
            label1.Text = c.ToString();

        }
    }
}
