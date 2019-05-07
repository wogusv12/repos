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
    public partial class Form4 : Form
    {
        String[] btn_cont = { "버튼", "체크 상자", "라디오 버튼" };
        String[] list_cont = { "리스트 상자", "콤보 상자", "체크 리스트 상자" };
        public Form4()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for(int i= 0; i< btn_cont.Length; i++)
            {
                listBox1.Items.Add(btn_cont[i]);
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < list_cont.Length; i++)
            {
                listBox1.Items.Add(list_cont[i]);
            }

        }
    }
}
