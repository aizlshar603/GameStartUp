using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace GameStartUp
{
    public partial class MyGame : Form
    {
        public MyGame()
        {
            InitializeComponent();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            //make button go away 
            StartGame.Visible = false;

            //Show count down 
            StartTimer.Visible = true;
            Refresh();
            Thread.Sleep(1000);

            //start counting down from 3 then make StartTimer go away
            StartTimer.Text = "Game Will Start In...3";
            Refresh();
            Thread.Sleep(1000);
            StartTimer.Text = "Game Will Start In...2";
            Refresh();
            Thread.Sleep(1000);
            StartTimer.Text = "Game Will Start In...1";
            Refresh();
            Thread.Sleep(1000);
            StartTimer.Visible = false;

            //Display "go" and turn screen green
            this.BackColor = Color.Green;
            PlayGame.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            this.BackColor = Color.Black;
            PlayGame.Visible = false;

            //play sound (couldn't get sound to download)

            //SoundPlayer player = new SoundPlayer(Properties.Resources.alert);
            //player.Play();

            //logo background
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Green);
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            g.DrawEllipse(drawPen, 30, 25, 200, 100);
            g.FillEllipse(drawBrush, 30, 25, 200, 100);

            //C of the logo
            drawPen.Color = Color.White;
            drawBrush.Color = Color.White;
            g.DrawArc(drawPen, 70, 40, 65, 65, 30, 300);

            //Rams writing
            Font drawFont = new Font("Arial", 20, FontStyle.Bold);
            drawBrush.Color = Color.White;
            g.DrawString("Rams", drawFont, drawBrush, 100, 55);

            





        }
    }
}
