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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.TextAlign = ContentAlignment.MiddleLeft;
    
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.TextAlign = ContentAlignment.MiddleRight;
        }

        private void label_style()
        {
            
            System.Drawing.FontStyle style = System.Drawing.FontStyle.Regular;
            if (checkBox1.Checked) style |= System.Drawing.FontStyle.Bold;
            if (checkBox2.Checked) style |= System.Drawing.FontStyle.Underline;
            if (checkBox3.Checked) style |= System.Drawing.FontStyle.Italic;
            if (checkBox4.Checked) style |= System.Drawing.FontStyle.Strikeout;
            label2.Font = new Font(label2.Font, style);
       
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label_style();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label_style();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label_style();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label_style();
        }
    }

   
}
