using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBalls
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        int numbThread = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxSiseSquare.Text) > 50 && Convert.ToInt32(textBoxSiseSquare.Text) <= 400) {
                square.Size = new System.Drawing.Size(Convert.ToInt32(textBoxSiseSquare.Text), Convert.ToInt32(textBoxSiseSquare.Text));
            }

            Thread[] myThreads = new Thread[Convert.ToInt32(textBoxCountBalls.Text)];
            for (int i = 0; i < Convert.ToInt32(textBoxCountBalls.Text); i++)
            {
                myThreads[i] = new Thread(new ThreadStart(moveBall));
                myThreads[i].Start();
                Thread.Sleep(20);
            }
        }

        public void moveBall()
        {
            int number = numbThread;
            numbThread++;

            Ball logicBall = new Ball(square.Height);

            RoundPictureBox physicBall = new RoundPictureBox();
            physicBall.BackColor = Color.FromArgb(logicBall.Color[0],
                logicBall.Color[1], logicBall.Color[2]);
            physicBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            physicBall.Location = new System.Drawing.Point(logicBall.X, logicBall.Y);
            physicBall.Size = new System.Drawing.Size(30, 30);
            Thread.Sleep(25 * number * 10);
            int counter = 400;
            this.Invoke(new Action(() => { Controls.Add(physicBall); square.SendToBack(); }));

            while (counter > 0)
            {
                this.Invoke(new Action(() =>
                {
                    if (logicBall.LeftMove) { physicBall.Left += logicBall.Speed; }
                    else { physicBall.Left -= logicBall.Speed; };

                    if (logicBall.UpMove) { physicBall.Top += logicBall.Speed; }
                    else { physicBall.Top -= logicBall.Speed; };

                    if (physicBall.Left <= square.Left) { logicBall.LeftMove = true; logicBall.randomUpMove(); };

                    if (physicBall.Right >= square.Right) { logicBall.LeftMove = false; logicBall.randomUpMove(); };

                    if (physicBall.Top <= square.Top) { logicBall.UpMove = true; logicBall.randomLeftMove(); };

                    if (physicBall.Bottom >= square.Bottom) { logicBall.UpMove = false; logicBall.randomLeftMove(); };
                }));

                Thread.Sleep(40);
                counter--;
            }
            physicBall.Invoke(new Action(() => physicBall.Hide()));
        }
    }
}
