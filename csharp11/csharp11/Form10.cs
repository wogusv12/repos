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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView1.SelectedNode != null)
            {
                if(treeView1.SelectedNode.Nodes != null)
                {
                    listView1.Items.Clear();
                    foreach(TreeNode node in treeView1.SelectedNode.Nodes)
                    {
                        listView1.Items.Add(node.Text, node.SelectedImageIndex);

                    }
                }
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }
    }
}
