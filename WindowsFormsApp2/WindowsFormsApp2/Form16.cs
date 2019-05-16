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
    public partial class Form16 : Form
    {
        int first_x = 0, first_y = 0 ;
        int last_x = 0 , last_y = 0;
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(ForeColor);
            if (first_x < last_x) { // 처음 x값이 스크롤후 x값보다 작을경우
                if(first_y <= last_y)
                {
                    g.DrawRectangle(pen, first_x, first_y, (last_x - first_x), (last_y - first_y));
                }else if(first_y > last_y)
                {
                    g.DrawRectangle(pen, first_x, last_y, (last_x - first_x), (first_y - last_y));
                }

            }else if(first_x > first_y) // 처음 x값이 스크롤후 y값보다 클경우
            {
                if (first_y <= last_y)
                {
                    g.DrawRectangle(pen, last_x, first_y, (first_x - last_x), (last_y - first_y));
                }
                else if (first_y > last_y)
                {
                    g.DrawRectangle(pen, last_x, last_y, (first_x - last_x), (first_y - last_y));
                }
            }
            g.DrawRectangle(pen, 30, 50, 20, 20);

        }

        private void Form16_MouseDown(object sender, MouseEventArgs e)
        {
            first_x = e.X;
            first_y = e.Y;
           
        }

        private void Form16_MouseUp(object sender, MouseEventArgs e)
        {
            last_x = e.X;
            last_y = e.Y;
           label1.Text = first_x + ", "+ first_y+" || " +last_x + " , " + last_y;
            Invalidate();
            
        }
    }
}
