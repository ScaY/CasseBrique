using Breakout.Model;
using Microsoft.Xna.Framework;
using System;

namespace Breakout.Model
{
    public static class RuleBall
    {
        public static Brick GetBrickHit(Ball ball, BrickZone bricks)
        {
            Brick result = null;
            Vector2 positionBall = ball.Position;

            //la balle et dans la zone de brique
            if (CheckBallEnterBlockBrick(ball.Position, bricks))
            {
                int brickX = (int)((positionBall.X - bricks.StartBlockBrickX) / bricks.WidthBrick);
                int brickY = (int)((positionBall.Y - bricks.StartBlockBrickY) / bricks.HeightBrick);

                result = bricks.AllBricks[brickX, brickY];
            }

            return result;
        }

        public static bool CheckBallEnterBlockBrick(Vector2 positionBall, BrickZone bricks)
        {
            return (positionBall.X > bricks.StartBlockBrickX && positionBall.X < bricks.EndBlockBrickX
                && positionBall.Y > bricks.StartBlockBrickY && positionBall.Y < bricks.EndBlockBrickY);
        }

        public static void HandleDeplacementHitBrick(BreakoutModel model, Brick brick)
        {
            Ball ball = model.Ball;
            BrickZone bricks = model.BrickZone;
            int widthBrick = brick.Size.Width;
            int heightBrick = brick.Size.Height;

            Vector2 positionBall = ball.Position;
            Vector2 centerBrick = new Vector2(brick.Position.X + widthBrick / 2, brick.Position.Y + heightBrick / 2);
            Vector2 newDeplacement = Vector2.Zero;
            float diffX = 0;
            float diffY = 0;

            //la balle a touché la brique à droite
            if (positionBall.X > centerBrick.X)
            {
                //la balle a touché la brique dans la partie haute
                if (positionBall.Y < centerBrick.Y)
                {
                    diffX = (brick.Position.X + brick.Size.Width) - positionBall.X;
                    diffY = positionBall.Y - brick.Position.Y;
                }
                else
                {
                    //la balle a touché la brique dans la partie basse
                    diffX = (brick.Position.X + brick.Size.Width) - positionBall.X;
                    diffY = (brick.Position.Y + brick.Size.Height) - positionBall.Y;
                }

            }
            else
            {
                //la balle a touché la brique à gauche
                if (positionBall.Y < centerBrick.Y)
                {
                    //la balle a touché la brique dans la partie haute
                    diffX = positionBall.X - brick.Position.X;
                    diffY = positionBall.Y - brick.Position.Y;
                }
                else
                {
                    //la balle a touché la brique dans la partie basse
                    diffX = positionBall.X - brick.Position.X;
                    diffY = positionBall.Y - (brick.Position.Y + brick.Size.Height);
                }
            }

            HandleVarianceXAndY(ball, diffX, diffY);
            bricks.RemoveBrick(brick);

            if (brick.Bonus != null)
            {
                model.AddBonus(brick.Bonus);
            }
        }

        public static void BallReboundLeftRight(Ball ball)
        {
            if ((ball.Deplacement.X > 0 || ball.Deplacement.X < 0) && (ball.Deplacement.Y < 0 || ball.Deplacement.Y > 0))
            {
                ball.Deplacement = Vector2.Normalize(new Vector2(-ball.Deplacement.X, ball.Deplacement.Y));
            }
        }

        public static void HandleReboundUpDown(Ball ball)
        {
            if ((ball.Deplacement.X > 0 || ball.Deplacement.X < 0) && ball.Deplacement.Y > 0)
            {
                ball.Deplacement = Vector2.Normalize(new Vector2(ball.Deplacement.X, -ball.Deplacement.Y));
            }
            else if ((ball.Deplacement.X > 0 || ball.Deplacement.X < 0) && ball.Deplacement.Y < 0)
            {
                ball.Deplacement = Vector2.Normalize(new Vector2(ball.Deplacement.X, -ball.Deplacement.Y));
            }
        }

        public static void HandleVarianceXAndY(Ball ball, float diffX, float diffY)
        {
            Console.WriteLine("diffX: " + diffX + "     diffY: " + diffY);
            if (diffX < diffY)
            {
                //la balle a touché la brique à droite
                BallReboundLeftRight(ball);
            }
            else
            {
                //la balle a touché la brique en haut
                HandleReboundUpDown(ball);
            }
        }
    }
}
