using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        private int i;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MessageBox.Show("MessageBox", "Title Bar");
        }

        private void Form3_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("MessageBoxButtons", "Title Bar", MessageBoxButtons.OKCancel);
            /* i = i < 64 ? i += 16 : 0;
             this.Text = ((MessageBoxIcon)i).ToString();
             MessageBox.Show("MessageBoxIcon", "Title Bar", MessageBoxButtons.OKCancel, (MessageBoxIcon)i);*/
            MessageBox.Show("MessageBoxDefaultButton", "Title Bar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
    }
}
