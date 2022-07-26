using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        Timer timer2 = new Timer();
        int carspeed = 1;
        int score = 50;
        double distance = 0;
        public Form1()
        {
            InitializeComponent();
            scoreLBL.Text = "SCORE : " + score;
            distanceLBL.Text = "KM : " + distance;
            timer.Interval = 10;
            timer2.Interval = 200;
            timer.Tick += Timer_Tick;
            timer2.Tick += Timer_Tick2;
            timer.Start();
            timer2.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top+=carspeed;
            pictureBox2.Top+=carspeed;
            pictureBox3.Top+=carspeed;
            pictureBox4.Top+=carspeed;
            pictureBox5.Top+=carspeed;
            pictureBox6.Top+=carspeed;
            pictureBox9.Top+=carspeed;
            pictureBox8.Top+=carspeed;
            barrier1.Top += carspeed;
            barrier2.Top += carspeed;
            barrier3.Top += carspeed;
            barrier4.Top += carspeed;
            if(car.Bounds.IntersectsWith(barrier1.Bounds) ||
                car.Bounds.IntersectsWith(barrier2.Bounds) ||
                car.Bounds.IntersectsWith(barrier3.Bounds)||
                car.Bounds.IntersectsWith(barrier4.Bounds) )
            {
                EndGame();
            }
            if (pictureBox9.Top <= this.Height+carspeed && pictureBox9.Top >= this.Height - carspeed)
            {
                pictureBox9.Top = 0;
                pictureBox8.Top = 0;
            }
            if (pictureBox6.Top <= this.Height + carspeed && pictureBox6.Top >= this.Height - carspeed)
            {
                pictureBox5.Top = 0;
                pictureBox6.Top = 0;
            }
            if (pictureBox4.Top <= this.Height + carspeed && pictureBox4.Top >= this.Height - carspeed)
            {
                pictureBox4.Top = 0;
                pictureBox3.Top = 0;
            }
            if (pictureBox2.Top <= this.Height + carspeed && pictureBox2.Top >= this.Height - carspeed)
            {
                pictureBox2.Top = 0;
                pictureBox1.Top = 0;
            }
            Random random = new Random();
            if(barrier1.Top<=this.Height+carspeed && barrier1.Top >= this.Height - carspeed)
            {
                barrier1.Top = 0;
                score += 5;
                int choose = random.Next(1, 3);
                if (choose == 1) barrier1.Left = 37;
                else if (choose == 2) barrier1.Left = 195;
                else if (choose == 3) barrier1.Left = 361;
            }
            if (barrier2.Top <= this.Height + carspeed && barrier2.Top >= this.Height - carspeed)
            {
                barrier2.Top = 0;
                score += 5;
                int choose = random.Next(1, 4);
                if (choose == 1)      barrier2.Left = 37;
                else if (choose == 2) barrier2.Left = 195;
                else if (choose == 3) barrier2.Left = 361;
            }
            if (barrier3.Top <= this.Height + carspeed && barrier3.Top >= this.Height - carspeed)
            {
                barrier3.Top = 0;
                score += 5;
                int choose = random.Next(1, 3);
                if (choose == 1)      barrier3.Left = 37;
                else if (choose == 2) barrier3.Left = 195;
                else if (choose == 3) barrier3.Left = 361;
            }                                
            if (barrier4.Top <= this.Height + carspeed && barrier4.Top >= this.Height - carspeed)
            {
                barrier4.Top = 0;
                score += 5;
                int choose = random.Next(1, 3);
                if (choose == 1)      barrier4.Left = 37;
                else if (choose == 2) barrier4.Left = 195;
                else if (choose == 3) barrier4.Left = 361;
            }
            carspeed = score / 50;
            scoreLBL.Text = "SCORE : " + score;
            distanceLBL.Text = "KM : " + distance;

        }
        private void Timer_Tick2(object sender, EventArgs e)
        {

            distance += 1;
            distanceLBL.Text = "KM : " + distance;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Location.X > 140)
                {
                    car.Left -= 160;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (car.Location.X < 300)
                {
                    car.Left += 160;
                }
            }
        }
        private void EndGame()
        {
            timer.Stop();
            timer2.Stop();
            Label Result = new Label();
            Result.Text = "Game Over!";
            Result.Font = new Font("Comic Sans MS", 16, FontStyle.Bold);
            Result.BringToFront();
            Result.AutoSize = true;
            Result.Left = 165;
            Result.Top = 350;
            this.Controls.Add(Result);

        }
        private void scoreLBL_Click(object sender, EventArgs e)
        {

        }
    }
}
