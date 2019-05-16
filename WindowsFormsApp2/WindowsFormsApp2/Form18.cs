using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        String s = null;
        private void Form18_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(e.KeyChar.ToString().Equals("0") || e.KeyChar.ToString().Equals("1") || e.KeyChar.ToString().Equals("2") || e.KeyChar.ToString().Equals("3") ||
                e.KeyChar.ToString().Equals("4") || e.KeyChar.ToString().Equals("5") || e.KeyChar.ToString().Equals("6") || e.KeyChar.ToString().Equals("7") ||
                e.KeyChar.ToString().Equals("8") || e.KeyChar.ToString().Equals("9") || e.KeyChar.ToString().Equals("-"))
            {
                s += e.KeyChar.ToString();
                label1.Text = s;
            }
        }
    }
}
