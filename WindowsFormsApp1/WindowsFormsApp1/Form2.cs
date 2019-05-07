using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int input1, input2, result;
        public Form2()
        {
            InitializeComponent();
        }
        private void get_number()
        {
            input1 = int.Parse(textBox1.Text);
            input2 = int.Parse(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            get_number();
            result = input1 - input2;
            textBox3.Text = result.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            get_number();
            result = input1 * input2;
            textBox3.Text = result.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            get_number();
            result = input1 / input2;
            textBox3.Text = result.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            get_number();
            result = input1 % input2;
            textBox3.Text = result.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            get_number();
            result = input1 + input2;
            textBox3.Text = result.ToString();
        }
       

    }
}
