using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double x;
        double y;

        void Calculation (string a, string b, Func<double, double, double> f)
        {
            if (double.TryParse(a, out x) && double.TryParse(b, out y))
            {
                x = double.Parse(a);
                y = double.Parse(b);
                label1.Text = $"{f(x, y)}";
            }
            else
            {
                label1.Text = "Неккоретный ввод";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculation(textBox1.Text, textBox2.Text, Calc.Plus);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculation(textBox1.Text, textBox2.Text, Calc.Minus);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculation(textBox1.Text, textBox2.Text, Calc.Mult);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculation(textBox1.Text, textBox2.Text, Calc.Div);
        }
    }
}
