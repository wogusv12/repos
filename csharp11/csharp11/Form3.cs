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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView1.SelectedNode != null)
            {
                textBox1.Text = treeView1.SelectedNode.Text;
                textBox2.Text = (treeView1.SelectedNode.Parent.Text == null) ? "" : treeView1.SelectedNode.Parent.Text;
                textBox3.Text = (treeView1.SelectedNode.PrevNode.Text == null) ? "" : treeView1.SelectedNode.PrevNode.Text;
                textBox4.Text = (treeView1.SelectedNode.NextNode.Text == null) ? "" : treeView1.SelectedNode.NextNode.Text;

                if(treeView1.SelectedNode.Nodes != null)
                {
                    listBox1.Items.Clear();
                    foreach (TreeNode node in treeView1.SelectedNode.Nodes)
                        listBox1.Items.Add(node.Text);
                }
            }
        }
    }
}
