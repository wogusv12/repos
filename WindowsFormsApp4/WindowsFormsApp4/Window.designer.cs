namespace Snake
{
    partial class Window
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
            this.m_Timer = new System.Windows.Forms.Timer(this.components);
            this.m_RestartBtn = new System.Windows.Forms.Button();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // m_Timer
            // 
            this.m_Timer.Interval = 300;
            this.m_Timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // m_RestartBtn
            // 
            this.m_RestartBtn.Enabled = false;
            this.m_RestartBtn.Location = new System.Drawing.Point(0, 0);
            this.m_RestartBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_RestartBtn.Name = "m_RestartBtn";
            this.m_RestartBtn.Size = new System.Drawing.Size(58, 18);
            this.m_RestartBtn.TabIndex = 0;
            this.m_RestartBtn.Text = "Restart";
            this.m_RestartBtn.UseVisualStyleBackColor = true;
            this.m_RestartBtn.Click += new System.EventHandler(this.OnRestartBtnClick);
            // 
            // scoreLbl
            // 
            this.scoreLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Location = new System.Drawing.Point(154, 3);
            this.scoreLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(56, 12);
            this.scoreLbl.TabIndex = 1;
            this.scoreLbl.Text = "Score : 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Level : 1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(122, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(88, 18);
            this.progressBar1.TabIndex = 3;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 254);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.m_RestartBtn);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Window";
            this.ShowIcon = false;
            this.Text = "Snake";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer m_Timer;
        private System.Windows.Forms.Button m_RestartBtn;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

