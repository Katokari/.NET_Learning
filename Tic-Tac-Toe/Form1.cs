using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        enum enWinner { eNone, ePlayer1, ePlayer2 };

        struct stGameStatus
        {
            public enWinner Winner;
            public bool IsX;
            public bool GameOver;
            public int GameCount;
        }

        stGameStatus GameStatus = new stGameStatus();

        public Form1()
        {
            InitializeComponent();
        }

        private void Grid(object sender, PaintEventArgs e)
        {
            Color white = Color.White;
            Pen pen = new Pen(white);
            pen.Width = 15;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen, 350, 200, 690, 200);
            e.Graphics.DrawLine(pen, 350, 315, 690, 315);
            e.Graphics.DrawLine(pen, 463, 90, 463, 425);
            e.Graphics.DrawLine(pen, 579, 90, 579, 425);
        }

        void EndGame()
        {
            foreach(PictureBox pb in this.Controls.OfType<PictureBox>())
            {
                pb.Enabled = false;
                
            }
            MessageBox.Show("Game Over", "Game Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
            switch(GameStatus.Winner)
            {
                case enWinner.ePlayer1:
                    labWinner.Text = "Player1";
                    break;
                case enWinner.ePlayer2:
                    labWinner.Text = "Player2";
                    break;
                case enWinner.eNone:
                    labWinner.Text = "Stale";
                    break;
            }
            labTurn.Text = "None";
        }

        void CheckValues(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            if (pb1.Tag == "0")
                return;
            
            if (pb1.Tag == pb2.Tag && pb2.Tag == pb3.Tag)
            {
                pb1.BackColor = Color.LimeGreen;
                pb2.BackColor = Color.LimeGreen;
                pb3.BackColor = Color.LimeGreen;
                if (pb1.Tag == "1")
                {
                    GameStatus.Winner = enWinner.ePlayer1;
                    EndGame();
                    return;
                }

                GameStatus.Winner = enWinner.ePlayer2;
                EndGame();
            }

            return;
        }

        void CheckWinner()
        {
            GameStatus.GameCount++;
            if (GameStatus.GameCount == 9)
            {
                GameStatus.Winner = enWinner.eNone;
                EndGame();
            }
            if (!GameStatus.GameOver)
            {
                CheckValues(pictureBox1, pictureBox2, pictureBox3);
                CheckValues(pictureBox4, pictureBox5, pictureBox6);
                CheckValues(pictureBox7, pictureBox8, pictureBox9);

                CheckValues(pictureBox1, pictureBox4, pictureBox7);
                CheckValues(pictureBox2, pictureBox5, pictureBox8);
                CheckValues(pictureBox3, pictureBox6, pictureBox9);

                CheckValues(pictureBox1, pictureBox5, pictureBox9);
                CheckValues(pictureBox3, pictureBox5, pictureBox7);
            }
        }

        void UpdateImage(object sender)
        {
            if (((PictureBox)sender).Tag == "0")
            {
                if (GameStatus.IsX)
                {
                    ((PictureBox)sender).Image = Resources.X;
                    ((PictureBox)sender).Tag = "1";
                    GameStatus.IsX = false;
                    labTurn.Text = "Player2";
                    return;
                }
                ((PictureBox)sender).Image = Resources.O;
                ((PictureBox)sender).Tag = "2";
                labTurn.Text = "Player1";
                GameStatus.IsX = true;
            } else
            {
                MessageBox.Show("Invalid Move", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            UpdateImage((PictureBox)sender);
            CheckWinner();
        }

        void Reset()
        {
            foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
            {
                pb.Enabled = true;
                pb.Tag = "0";
                pb.Image = null;
                pb.BackColor = Color.Black;
            }
            GameStatus.IsX = true;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.eNone;
            GameStatus.GameCount = 0;
            labTurn.Text = "Player1";
            labWinner.Text = "In Progress";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }


}
