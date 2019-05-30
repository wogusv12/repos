using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class Window : Form
    {
        int level = 1;
        private const int WIDTH = 12;
        private const int HEIGHT = 16;
        private const string SCORE_STRING = "Score: {0}";
        private readonly Color m_BackgroundColor = Color.CornflowerBlue;
        private readonly Game m_Game;
        private readonly Bitmap m_GameField;
        private readonly Graphics m_GameGraphics;

        public Window()
        {
            InitializeComponent();
            m_GameField = new Bitmap(WIDTH * Piece.SIDE, (HEIGHT * Piece.SIDE));
            m_GameGraphics = Graphics.FromImage(m_GameField); m_GameGraphics.PageUnit = GraphicsUnit.Pixel;
            ClientSize = new Size(m_GameField.Width, m_GameField.Height + m_RestartBtn.Height);
            m_Game = new Game(WIDTH, HEIGHT);
            m_Timer.Start();
            progressBar1.Maximum = 1;
           
        }

        private void UpdateScore()
        {
            scoreLbl.Text = string.Format(SCORE_STRING, m_Game.GetScore());
            progressBar1.Value += 1;
            if(progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 0;
                level++;
                progressBar1.Maximum = progressBar1.Maximum + 1;
                label1.Text = "Level : " + level;
                m_Timer.Interval = m_Timer.Interval - 100;
            }
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (m_Game.SnakeHasGrown())
            {
                UpdateScore();
            }
            if (m_Game.Lost())
            {
                
                m_Timer.Stop();
                MessageBox.Show("죽었습니다.");
                m_RestartBtn.Enabled = true;
            }
            Invalidate();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    m_Game.ChangeSnakeDIrection(Direction.Left);
                    break;
                case Keys.Right:
                    m_Game.ChangeSnakeDIrection(Direction.Right);
                    break;
                case Keys.Up:
                    m_Game.ChangeSnakeDIrection(Direction.Up);
                    break;
                case Keys.Down:
                    m_Game.ChangeSnakeDIrection(Direction.Down);
                    break;
                case Keys.F5:
                    if (m_RestartBtn.Enabled == true)
                    {
                        m_RestartBtn.Enabled = false;
                        m_Game.Restart();
                        UpdateScore();
                        progressBar1.Value = 0;
                        label1.Text = "Level : 1";
                        m_Timer.Interval = 300;
                        progressBar1.Maximum =1;
                        m_Timer.Start();
                    }
                    break;
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            m_GameGraphics.Clear(m_BackgroundColor);
            m_Game.Draw(m_GameGraphics);
            e.Graphics.DrawImage(m_GameField, 0, m_RestartBtn.Height);
        }

        private void OnRestartBtnClick(object sender, EventArgs e)
        {
            m_RestartBtn.Enabled = false;
            m_Game.Restart();
            UpdateScore();
            progressBar1.Value = 0;
            label1.Text = "Level : 1";
            m_Timer.Interval = 300;
            progressBar1.Maximum = 5;
            m_Timer.Start();
        }
    }
}

