using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppBalls
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        List<Ball> logicArrayBalls = new List<Ball>();
        RoundPictureBox[] phisicArrayBalls;

        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < phisicArrayBalls.Length; i++)
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
        }

        public async Task calculateBall()
        {
            for (int i = 0; i < Convert.ToInt32(textBoxCountBalls.Text); i++)
            {
                Ball obj = new Ball(square.Height);
                logicArrayBalls.Add(obj);
                await Task.Delay(100);
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxSiseSquare.Text) > 50 && Convert.ToInt32(textBoxSiseSquare.Text) <= 400) {
                square.Size = new System.Drawing.Size(Convert.ToInt32(textBoxSiseSquare.Text), Convert.ToInt32(textBoxSiseSquare.Text));
            }


            phisicArrayBalls = new RoundPictureBox[Convert.ToInt32(textBoxCountBalls.Text)];

            Task task = Task.Run(() => calculateBall());
            task.Wait();


            for (int j = 0; j < logicArrayBalls.Count; j++)
            {
                phisicArrayBalls[j] = new RoundPictureBox();
                phisicArrayBalls[j].BackColor = Color.FromArgb(logicArrayBalls[j].Color[0], logicArrayBalls[j].Color[1], logicArrayBalls[j].Color[2]);
                phisicArrayBalls[j].SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                phisicArrayBalls[j].Location = new System.Drawing.Point(logicArrayBalls[j].X, logicArrayBalls[j].Y);
                phisicArrayBalls[j].Size = new System.Drawing.Size(30, 30);
                Controls.Add(phisicArrayBalls[j]);
            }
            square.SendToBack();
            timer1.Enabled = true;
        }
    }
}
