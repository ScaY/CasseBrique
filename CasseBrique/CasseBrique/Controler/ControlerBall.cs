using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CasseBrique
{
    public class ControlerBall
    {
        private Ball ball;

        public Ball Ball
        {
            get { return ball; }
            set { ball = value; }
        }

        public ControlerBall(Ball ball)
        {
            this.Ball = ball;
        }

        public void HandleTrajectoryBall(Bar bar, GameTime gameTime, int heightFrame, int widthFrame, BrickZone bricks)
        {
            ball.HandleTrajectoryBall(bar, gameTime, heightFrame, widthFrame, bricks);
        }

    }
}
