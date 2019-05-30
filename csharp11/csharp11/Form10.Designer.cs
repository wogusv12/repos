namespace csharp11
{
    partial class Form10
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("워드", 3, 3);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("파워포인트", 4, 4);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("엑셀", 5, 5);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("비지오", 6, 6);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("아웃룩", 7, 7);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("오피스", 9, 9, new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("메모장", 0, 0);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("그림판", 1, 1);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("계산기", 2, 2);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("보조프로그램", 10, 10, new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("내 컴퓨터", 8, 8, new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode21});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode12.ImageIndex = 3;
            treeNode12.Name = "Node1_word";
            treeNode12.SelectedImageIndex = 3;
            treeNode12.Text = "워드";
            treeNode13.ImageIndex = 4;
            treeNode13.Name = "Node1_ppt";
            treeNode13.SelectedImageIndex = 4;
            treeNode13.Text = "파워포인트";
            treeNode14.ImageIndex = 5;
            treeNode14.Name = "Node1_Excel";
            treeNode14.SelectedImageIndex = 5;
            treeNode14.Text = "엑셀";
            treeNode15.ImageIndex = 6;
            treeNode15.Name = "Node1_visio";
            treeNode15.SelectedImageIndex = 6;
            treeNode15.Text = "비지오";
            treeNode16.ImageIndex = 7;
            treeNode16.Name = "Node1_outlook";
            treeNode16.SelectedImageIndex = 7;
            treeNode16.Text = "아웃룩";
            treeNode17.ImageIndex = 9;
            treeNode17.Name = "Node1";
            treeNode17.SelectedImageIndex = 9;
            treeNode17.Text = "오피스";
            treeNode18.ImageIndex = 0;
            treeNode18.Name = "Node2_note";
            treeNode18.SelectedImageIndex = 0;
            treeNode18.Text = "메모장";
            treeNode19.ImageIndex = 1;
            treeNode19.Name = "Node2_paint";
            treeNode19.SelectedImageIndex = 1;
            treeNode19.Text = "그림판";
            treeNode20.ImageIndex = 2;
            treeNode20.Name = "Node2_calc";
            treeNode20.SelectedImageIndex = 2;
            treeNode20.Text = "계산기";
            treeNode21.ImageIndex = 10;
            treeNode21.Name = "Node2";
            treeNode21.SelectedImageIndex = 10;
            treeNode21.Text = "보조프로그램";
            treeNode22.ImageIndex = 8;
            treeNode22.Name = "my_com";
            treeNode22.SelectedImageIndex = 8;
            treeNode22.Text = "내 컴퓨터";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(165, 232);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(193, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(228, 232);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "notepad.png");
            this.imageList1.Images.SetKeyName(1, "paint.png");
            this.imageList1.Images.SetKeyName(2, "calc.png");
            this.imageList1.Images.SetKeyName(3, "word.png");
            this.imageList1.Images.SetKeyName(4, "powerpoint.png");
            this.imageList1.Images.SetKeyName(5, "excel.png");
            this.imageList1.Images.SetKeyName(6, "visio.png");
            this.imageList1.Images.SetKeyName(7, "outlook.png");
            this.imageList1.Images.SetKeyName(8, "computer.png");
            this.imageList1.Images.SetKeyName(9, "office.png");
            this.imageList1.Images.SetKeyName(10, "program.png");
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 275);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}