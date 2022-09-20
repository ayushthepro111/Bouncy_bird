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
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 7;
         int score = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pipeBottom_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = score.ToString();
            if(pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }

            if (pipeTop.Left > -180)
            {
                pipeTop.Left = -950;
                score++;
            }
            if(flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25
                )
            {
                endGame();
            }
        
        
        
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // if the space key is released then gravity is set back to 15
                gravity = 7;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // if the space key is pressed then the gravity will be set to -15
                gravity = -7;
            }
        }

        private void ground_Click(object sender, EventArgs e)
        {
        
        }
        private void endGame()
        {
            gameTimer.Stop(); // stop the main timer
            scoreText.Text += " Game over!!!";

        }




    }
}
