using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CasseBrique
{
    public class Ball : Shape
    {
        public Ball()
            : base()
        {

        }

        public Ball(Vector2 position, Vector2 deplacement, float speed)
            : base(position, deplacement, speed)
        {

        }

        public void HandleTrajectoryBall(Bar bar, GameTime gameTime, int heightFrame, int widthFrame, Bricks bricks)
        {
            //balle sort du jeu
            if (Position.Y > heightFrame)
            {
                Console.WriteLine("Perdu !");
            }

            HandleTrajectoryBallReboundBar(bar, gameTime, heightFrame, widthFrame);
            HandleTrajectoryBallReboundFrame(bar, gameTime, heightFrame, widthFrame);
            HandleBallReboundBrick(bricks);

            Position += Deplacement * Speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
        }

        public void HandleTrajectoryBallReboundBar(Bar bar, GameTime gameTime, int heightFrame, int widthFrame)
        {
            if (bar.getRectangle().Contains((int)(Position.X + bar.Views[0].Texture.Width), (int)(Position.Y + bar.Views[0].Texture.Height)))
            {
                RuleBall.BallReboundDown(this);
            }

        }

        public void HandleTrajectoryBallReboundFrame(Bar bar, GameTime gameTime, int heightFrame, int widthFrame)
        {
            //rebond à gaiche ou à droite
            if ((Position.X < 0 || Position.X > widthFrame))
            {
                RuleBall.BallReboundLeftRight(this);
            }
            //rebond en haut
            else if (Position.Y < 0)
            {
                RuleBall.BallReboundTop(this);
            }
        }

        public void HandleBallReboundBrick(Bricks bricks)
        {
            Brick brick = RuleBall.GetBrickHit(this, bricks);
            if(brick != null)
            {
                Console.WriteLine("Brick hit in ball");
                RuleBall.DecreaseLifeBrick(brick);
                RuleBall.HandleDeplacementHitBrick(this, brick);
            }
        }
    }
}
