using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace AppBalls
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        List<Ball> logicArrayBalls = new List<Ball>();
        RoundPictureBox[] phisicArrayBalls;
        int numbThread = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        public void move (int i)
        {
            if (logicArrayBalls[i].LeftMove) { phisicArrayBalls[i].Left += logicArrayBalls[i].Speed; }
            else { phisicArrayBalls[i].Left -= logicArrayBalls[i].Speed; };

            if (logicArrayBalls[i].UpMove) { phisicArrayBalls[i].Top += logicArrayBalls[i].Speed; }
            else { phisicArrayBalls[i].Top -= logicArrayBalls[i].Speed; };

            if (phisicArrayBalls[i].Left <= square.Left) { logicArrayBalls[i].LeftMove = true; logicArrayBalls[i].randomUpMove(); };

            if (phisicArrayBalls[i].Right >= square.Right) { logicArrayBalls[i].LeftMove = false; logicArrayBalls[i].randomUpMove(); };

            if (phisicArrayBalls[i].Top <= square.Top) { logicArrayBalls[i].UpMove = true; logicArrayBalls[i].randomLeftMove(); };

            if (phisicArrayBalls[i].Bottom >= square.Bottom) { logicArrayBalls[i].UpMove = false; logicArrayBalls[i].randomLeftMove(); };
        }
        public  void moveBall()
        {
            int number = numbThread;
            numbThread++;
            Thread.Sleep(25 * number * 10);
            int counter = 400;
            this.Invoke(new Action(() => { Controls.Add(phisicArrayBalls[number]); square.SendToBack(); }));
            while (counter > 0)
            {
                phisicArrayBalls[number].Invoke(new Action(() => move(number)));
                Thread.Sleep(40);
                counter--;
            }
            phisicArrayBalls[number].Invoke(new Action(() => phisicArrayBalls[number].Hide()));
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxSiseSquare.Text) > 50 && Convert.ToInt32(textBoxSiseSquare.Text) <= 400) {
                square.Size = new System.Drawing.Size(Convert.ToInt32(textBoxSiseSquare.Text), Convert.ToInt32(textBoxSiseSquare.Text));
            }


            phisicArrayBalls = new RoundPictureBox[Convert.ToInt32(textBoxCountBalls.Text)];


            for (int i = 0; i < Convert.ToInt32(textBoxCountBalls.Text); i++)
            {
                logicArrayBalls.Add(new Ball(square.Height));
                Thread.Sleep(20);
            }


            for (int j = 0; j < logicArrayBalls.Count; j++)
            {
                phisicArrayBalls[j] = new RoundPictureBox();
                phisicArrayBalls[j].BackColor = Color.FromArgb(logicArrayBalls[j].Color[0], logicArrayBalls[j].Color[1], logicArrayBalls[j].Color[2]);
                phisicArrayBalls[j].SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                phisicArrayBalls[j].Location = new System.Drawing.Point(logicArrayBalls[j].X, logicArrayBalls[j].Y);
                phisicArrayBalls[j].Size = new System.Drawing.Size(30, 30);
            }
            square.SendToBack();


            Thread[] myThreads = new Thread[Convert.ToInt32(textBoxCountBalls.Text)];
            for (int i = 0; i < Convert.ToInt32(textBoxCountBalls.Text); i++)
            {
                myThreads[i] = new Thread(new ThreadStart(moveBall));
                myThreads[i].Start();
                
            }            
        }
    }
}
