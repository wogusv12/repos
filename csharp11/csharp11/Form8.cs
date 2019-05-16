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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
              //  MessageBox.Show(item.Text);

                if (item.Text.Equals("메모장"))
                {
                    System.Diagnostics.Process.Start("notepad.exe");
                }else if (item.Text.Equals("계산기"))
                {
                    System.Diagnostics.Process.Start("calc.exe");
                }
                else if (item.Text.Equals("그림판"))
                {
                    System.Diagnostics.Process.Start("mspaint.exe");
                }
            }
            
        }
    }
}
