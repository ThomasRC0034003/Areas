using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Areas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double length = double.Parse(textBox1.Text);
            double width = double.Parse(textBox2.Text);
            double area = length * width;
            textBox3.AppendText(area.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
