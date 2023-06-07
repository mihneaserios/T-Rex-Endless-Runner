using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_Rex_Endless_Runner
{
    public partial class TRexMainClass : Form
    {
        bool jumping = false;
        bool isGameOver = false;
        Random random = new Random();
        int jumpSpeed;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        int position = 0;

        public TRexMainClass()
        {
            InitializeComponent();
            GameReset();
        }

        private void GameReset()
        {

            jumping = false;
            force = 12;
            score = 0;
            jumpSpeed = 0;
            obstacleSpeed = 10;
            ScoreLabel.Text = "Score: " + score;
            trexpictureBox.Image = Properties.Resources.running;
            isGameOver = false;


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + random.Next(500, 800) + (x.Width * 10);
                    x.Left = position;
                }
            }

            GameTimer.Start();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            trexpictureBox.Top = trexpictureBox.Top + jumpSpeed;

            ScoreLabel.Text = "Score: " + score + " Jumping speed: " + jumpSpeed + " force: " + force + " Top:" + trexpictureBox.Top + " Bottom:" + trexpictureBox.Bottom;

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force--;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (trexpictureBox.Top > 269 && jumping == false)
            {
                force = 12;
                trexpictureBox.Top = 300;
                jumpSpeed = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + random.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    if (trexpictureBox.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer.Stop();
                        trexpictureBox.Image = Properties.Resources.dead;
                        ScoreLabel.Text += " Press R to restart the game!";
                        isGameOver = true;
                    }
                }
            }

            if (score > 5)
            {
                obstacleSpeed = 15;
            }
        }
        private void KeyisDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void KeyisUpEvent(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isGameOver)
            {
                GameReset();
            }
        }
    }
}
