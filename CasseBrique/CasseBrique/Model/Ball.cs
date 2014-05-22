using Breakout.Model;
using Breakout.Views;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Model
{
    public class Ball : Shape
    {
        public Ball()
            : base(Vector2.Zero, Vector2.Normalize(new Vector2(-1)), 0.2f)
        {
        }

        public Ball(Vector2 position, Vector2 deplacement, float speed)
            : base(position, deplacement, speed)
        {

        }

        public void HandleTrajectoryBall(Bar bar, GameTime gameTime, int heightFrame, int widthFrame, BrickZone bricks, ViewBall viewBall)
        {
            //balle sort du jeu
            if (Position.Y > heightFrame)
            {
                //handle when the player loose the game
            }

            HandleTrajectoryBallReboundBar(bar, gameTime, heightFrame, widthFrame, viewBall);
            HandleTrajectoryBallReboundFrame(bar, gameTime, heightFrame, widthFrame);
            HandleBallReboundBrick(bricks);

            Position += Deplacement * Speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
        }

        public void HandleTrajectoryBallReboundBar(Bar bar, GameTime gameTime, int heightFrame, int widthFrame, ViewBall viewBall )
        {
            if (bar.getRectangle().Contains((int)(Position.X), (int)(Position.Y+viewBall.Texture.Height/2)))
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

        public void HandleBallReboundBrick(BrickZone bricks)
        {
            Brick brick = RuleBall.GetBrickHit(this, bricks);
            if(brick != null)
            {
                Console.WriteLine("Brick detected");
                RuleBall.HandleDeplacementHitBrick(this, brick);
            }
        }
    }
}
