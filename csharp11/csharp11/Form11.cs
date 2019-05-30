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
    public partial class Form11 : Form
    {
        int red = 0, green = 0, blue = 0;
        public Form11()
        {
            InitializeComponent();
            label1.BackColor = (Color.FromArgb(0, 0, 0));
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            red = trackBar1.Value;
            label1.BackColor = Color.FromArgb(red,green,blue);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            blue = trackBar2.Value;
            label1.BackColor = Color.FromArgb(red, green, blue);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            green = trackBar3.Value;
            label1.BackColor = Color.FromArgb(red, green, blue);
            
        }

   

     
    }
}
