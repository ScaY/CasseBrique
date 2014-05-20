﻿using Microsoft.Xna.Framework;
using System;

namespace CasseBrique
{
    public static class RuleBall
    {
        public static Brick GetBrickHit(Ball ball, Bricks bricks)
        {
            Brick result = null;
            Vector2 positionBall = ball.Position;

            //la balle et dans la zone de brique
            if (CheckBallEnterBlockBrick(ball.Position, bricks))
            {
                int brickX = (int)(positionBall.X / bricks.WidthBrick);
                int brickY = (int)(positionBall.Y / bricks.HeightBrick);

                Console.WriteLine("Ball in bloc !"+brickX+"   "+ brickY);
                result = bricks.AllBricks[brickX, brickY];
            }

            return result;
        }

        public static void DecreaseLifeBrick(Brick brick)
        {
            brick.DecreaseLifeBrick();
        }

        public static bool CheckBallEnterBlockBrick(Vector2 positionBall, Bricks bricks)
        {
            Console.WriteLine("CheckBal bloc " + (positionBall.X > bricks.StartBlockBrickX));
            return (positionBall.X > bricks.StartBlockBrickX && positionBall.X < bricks.EndBlockBrickX
                && positionBall.Y > bricks.StartBlockBrickY && positionBall.Y < bricks.EndBlockBrickY);
        }

        public static void HandleDeplacementHitBrick(Ball ball, Brick brick)
        {
            int widthBrick = brick.Views[0].Texture.Width;
            int heightBrick = brick.Views[0].Texture.Height;

            Vector2 positionBall = ball.Position;
            Vector2 centerBrick = new Vector2(brick.Position.X + widthBrick, brick.Position.Y + heightBrick);
            Vector2 newDeplacement = Vector2.Zero;

            //la balle a touché la brique à droite
            if (positionBall.X > centerBrick.X)
            {
                //la balle a touché la brique dans la partie haute
                if (positionBall.Y < centerBrick.Y)
                {
                    float diffX = centerBrick.X + widthBrick - positionBall.X;
                    float diffY = positionBall.Y - centerBrick.Y - heightBrick;

                    HandleVarianceXAndY(ball, diffX, diffY);
                }
                else
                {
                    //la balle a touché la brique dans la partie basse
                    float diffX = centerBrick.X + widthBrick - positionBall.X;
                    float diffY = centerBrick.Y + heightBrick - positionBall.Y;

                    HandleVarianceXAndY(ball, diffX, diffY);
                }

            }
            else
            {
                //la balle a touché la brique à gauche

                if (positionBall.Y < centerBrick.Y)
                {
                    //la balle a touché la brique dans la partie haute
                    float diffX = positionBall.X -centerBrick.X - widthBrick;
                    float diffY = positionBall.Y - centerBrick.Y - heightBrick;

                    HandleVarianceXAndY(ball, diffX, diffY);
                }
                else
                {
                    //la balle a touché la brique dans la partie basse
                    float diffX = positionBall.X - centerBrick.X - widthBrick;
                    float diffY = centerBrick.Y + heightBrick - positionBall.Y;

                    HandleVarianceXAndY(ball, diffX, diffY);
                }
            }
        }

        public static void BallReboundLeftRight(Ball ball)
        {
            if ((ball.Deplacement.X > 0 || ball.Deplacement.X < 0) && (ball.Deplacement.Y < 0 || ball.Deplacement.Y > 0))
            {
                ball.Deplacement = Vector2.Normalize(new Vector2(-ball.Deplacement.X, ball.Deplacement.Y));
            }
        }

        public static void BallReboundDown(Ball ball)
        {
            if ((ball.Deplacement.X > 0 || ball.Deplacement.X < 0) && ball.Deplacement.Y > 0)
            {
                ball.Deplacement = Vector2.Normalize(new Vector2(ball.Deplacement.X, -ball.Deplacement.Y));
            }
        }

        public static void BallReboundTop(Ball ball)
        {
            if ((ball.Deplacement.X > 0 || ball.Deplacement.X < 0) && ball.Deplacement.Y < 0)
            {
                ball.Deplacement = Vector2.Normalize(new Vector2(ball.Deplacement.X, -ball.Deplacement.Y));
            }
        }

        public static void HandleVarianceXAndY(Ball ball, float diffX, float diffY)
        {
            //la balle a touché la brique à droite
            if (diffX < diffY)
            {
                BallReboundLeftRight(ball);
            }
            else
            {
                //la balle a touché la brique en haut
                BallReboundDown(ball);
            }
        }
    }
}
