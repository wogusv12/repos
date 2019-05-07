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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void UpdateEventLabels(String msg, int x, int y, MouseEventArgs e)
        {
            String message = String.Format("{0} X:{1}, Y:{2}", msg, x, y);
            String eventMsg = DateTime.Now.ToShortTimeString();
            eventMsg += "" + message;
            listBox1.Items.Insert(0, eventMsg);
            listBox1.TopIndex = 0;
            String mouseInfo;
            if (e != null)
            {
                mouseInfo = String.Format("Clicks : {0}, Delta : {1}, " + "Buttons: {2}", e.Clicks, e.Delta, e.Button.ToString());

            }
            else
                mouseInfo = String.Format("Click : {0}", msg);

            label1.Text = mouseInfo;
        }

    

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateEventLabels("(ListBox)MouseDown", e.X, e.Y, e);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Point mousePoint = PointToClient(MousePosition);

            UpdateEventLabels("(ListBox)DoubleClick", mousePoint.X, mousePoint.Y, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
