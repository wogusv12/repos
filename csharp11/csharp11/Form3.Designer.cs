namespace csharp11
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Console");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("MulticastDelegate");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Delegate", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("ApplicationException");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("SystemException");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Exception", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Math");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("TextReader");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("TextWriter");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Timer");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("TreeNode");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("MashalbyRefObject", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("String");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Object", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3,
            treeNode6,
            treeNode7,
            treeNode12,
            treeNode13});
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "선택한 노드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "부모 노드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "이전 형제 노드";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "부모 형제 노드";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "자식 노드";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 21);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 21);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 247);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 21);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(104, 271);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 21);
            this.textBox4.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(273, 219);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 88);
            this.listBox1.TabIndex = 10;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(15, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "노드1";
            treeNode1.Text = "Console";
            treeNode2.Name = "노드11";
            treeNode2.Text = "MulticastDelegate";
            treeNode3.Name = "노드2";
            treeNode3.Text = "Delegate";
            treeNode4.Name = "노드12";
            treeNode4.Text = "ApplicationException";
            treeNode5.Name = "노드13";
            treeNode5.Text = "SystemException";
            treeNode6.Name = "노드3";
            treeNode6.Text = "Exception";
            treeNode7.Name = "노드4";
            treeNode7.Text = "Math";
            treeNode8.Name = "노드14";
            treeNode8.Text = "TextReader";
            treeNode9.Name = "노드15";
            treeNode9.Text = "TextWriter";
            treeNode10.Name = "노드16";
            treeNode10.Text = "Timer";
            treeNode11.Name = "노드17";
            treeNode11.Text = "TreeNode";
            treeNode12.Name = "노드9";
            treeNode12.Text = "MashalbyRefObject";
            treeNode13.Name = "노드10";
            treeNode13.Text = "String";
            treeNode14.Name = "노드0";
            treeNode14.Text = "Object";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(378, 174);
            this.treeView1.TabIndex = 11;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 356);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView treeView1;
    }
}