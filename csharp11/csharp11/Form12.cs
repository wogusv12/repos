using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp11
{
    public partial class Form12 : Form
    {
        int level = 0;
        int feed_block = 0;

        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            level = int.Parse(numericUpDown2.Text);
            progressBar1.Maximum = level;
            label2.Select();

        }

        private void label2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {//up = 38 down = 40 left = 37  right = 39
            label2.Text = e.KeyCode + " @ "+ e.KeyValue;

            if(e.KeyValue == 38)
            {
                MessageBox.Show("up입니다.");
                
            }
            label2.Select();
        }

        private void Form12_KeyDown(object sender, KeyEventArgs e)
        {
            label2.Text = e.KeyCode + " @ " + e.KeyValue;
            label2.Focus();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
       
}
