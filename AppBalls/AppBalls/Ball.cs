using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppBalls
{
    class Ball
    {
        private int[] color = new int[3];

        private int x;

        private int y;

        private int speed;

        private bool leftMove;

        private bool upMove;
        public int[] Color
        {
            get { return color; }
        }

        public int X { get { return x; } }

        public int Y { get { return y; } }

        public int Speed { get { return speed; } }

        public bool LeftMove { get { return leftMove; } set { leftMove = value; } }

        public bool UpMove { get { return upMove; } set { upMove = value; } }

        Random rnd = new Random();
        public Ball(int heigth)
        {
            x = rnd.Next(30, heigth);
            y = rnd.Next(30, heigth);
            color[0] = rnd.Next(256);
            color[1] = rnd.Next(256);
            color[2] = rnd.Next(256);
            speed = rnd.Next(5, 20);
            leftMove = Convert.ToBoolean(rnd.Next(2));
            upMove = Convert.ToBoolean(rnd.Next(2));
        }

        public void randomLeftMove()
        {
            leftMove = Convert.ToBoolean(rnd.Next(2));
        }

        public void randomUpMove()
        {
            upMove = Convert.ToBoolean(rnd.Next(2));
        }
    }
}
