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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_KeyDown(object sender, KeyEventArgs e)
        {
            /*  if(e.KeyCode == Keys.F1) {

                  if(e.Shift == true)
                  {
                      MessageBox.Show("F1+Shift");
                  }else if(e.Alt == true)
                  {
                      MessageBox.Show("F1+Alt");
                  }else if(e.Control == true)
                  {
                      MessageBox.Show("F1 + Control");
                  }
                  else
                  {
                      MessageBox.Show(e.KeyCode.ToString());
                  }
              }*/

            if (e.Shift == true && e.KeyCode != Keys.ShiftKey)
            {
                MessageBox.Show("Shift+" + e.KeyCode.ToString());
            }
            else if (e.Alt == true && e.KeyCode != Keys.Menu)
            {
                MessageBox.Show("Alt+" + e.KeyCode.ToString());
            }
            else if (e.Control == true && e.KeyCode != Keys.ControlKey) 
            {
                MessageBox.Show("Control+" + e.KeyCode.ToString());
            }
            else if (e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.Menu || e.KeyCode == Keys.ControlKey) { }
            else
            {
                MessageBox.Show(e.KeyCode.ToString());
            }

        }
    }
}
