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
            if (pictureBox9.Top <= this.Height+carspeed && pictureBox9.Top >= this.Height - carspeed)
            {
                pictureBox9.Top = 0;
                pictureBox8.Top = 0;
                score += 20;
            }
            if (pictureBox6.Top <= this.Height + carspeed && pictureBox6.Top >= this.Height - carspeed)
            {
                pictureBox5.Top = 0;
                pictureBox6.Top = 0;
                score += 20;

            }
            if (pictureBox4.Top <= this.Height + carspeed && pictureBox4.Top >= this.Height - carspeed)
            {
                pictureBox4.Top = 0;
                pictureBox3.Top = 0;
                score += 20;

            }
            if (pictureBox2.Top <= this.Height + carspeed && pictureBox2.Top >= this.Height - carspeed)
            {
                pictureBox2.Top = 0;
                pictureBox1.Top = 0;
                score += 20;
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

        private void scoreLBL_Click(object sender, EventArgs e)
        {

        }
    }
}
