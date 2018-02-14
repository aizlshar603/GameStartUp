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

            //play sound

            SoundPlayer player = new SoundPlayer(Properties.Resources.alert);
            player.Play();






        }
    }
}
