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
            if (CheckBallEnterBlockBrick(ball, bricks))
            {
                // Vector2 centerBall = ball.GetCenterBall();
                int width = ball.Size.Width;
                int height = ball.Size.Height;

                //teste le coin en haut à gauche
                int brickX = (int)((positionBall.X - bricks.StartBlockBrickX) / bricks.WidthBrick);
                int brickY = (int)((positionBall.Y - bricks.StartBlockBrickY) / bricks.HeightBrick);
                result = bricks.GetBrick(brickX, brickY);
                if (result != null && result != ball.brikHit)
                {
                    return result;
                }

                //teste le coin en haut à droite
                brickX = (int)((positionBall.X + width - bricks.StartBlockBrickX) / bricks.WidthBrick);
                brickY = (int)((positionBall.Y - bricks.StartBlockBrickY) / bricks.HeightBrick);
                result = bricks.GetBrick(brickX, brickY);
                if (result != null && result != ball.brikHit)
                {
                    return result;
                }


                //teste le coin en bas à droite
                brickX = (int)((positionBall.X + width - bricks.StartBlockBrickX) / bricks.WidthBrick);
                brickY = (int)((positionBall.Y + height - bricks.StartBlockBrickY) / bricks.HeightBrick);
                result = bricks.GetBrick(brickX, brickY);
                if (result != null && result != ball.brikHit)
                {
                    return result;
                }


                //teste le coin en bas à gauche
                brickX = (int)((positionBall.X - bricks.StartBlockBrickX) / bricks.WidthBrick);
                brickY = (int)((positionBall.Y + height + bricks.StartBlockBrickY) / bricks.HeightBrick);
                result = bricks.GetBrick(brickX, brickY);
                if (result != null && result != ball.brikHit)
                {
                    return result;
                }
            }

            return result;
        }


        public static bool CheckBallEnterBlockBrick(Ball ball, BrickZone bricks)
        {
            Rectangle boxBall = ball.GetBox();
            Rectangle boxZone = bricks.GetBox();

            return boxBall.Intersects(boxZone);
        }

        public static void HandleDeplacementHitBrick(BreakoutModel model, Brick brick, Ball ball)
        {
            Vector2 centerBall = ball.GetCenterBall();

            int widthBrick = brick.Size.Width;
            int heightBrick = brick.Size.Height;
            int heightBall = ball.Size.Height;
            int widthBall = ball.Size.Width;

            Vector2 centerBrick = new Vector2(brick.Position.X + widthBrick / 2, brick.Position.Y + heightBrick / 2);

            Vector2 newDeplacement = Vector2.Zero;

            //la balle se situe à la partie droite de la brique
            if (centerBall.X > centerBrick.X)
            {
                if (centerBall.X < (centerBrick.X + widthBrick / 2))
                {
                    Console.WriteLine("Rebond à droite en bas ou en haut        " + brick.XBrick +"    "+brick.YBrick);
                    HandleReboundUpDown(ball);
                }
                else
                {
                    if ((centerBall.Y + heightBall / 2) < (centerBrick.Y - heightBrick / 2) || (centerBall.Y - heightBall / 2) > (centerBrick.Y + heightBrick / 2))
                    {
                        Console.WriteLine("Rebond à droite en bas ou en haut        " + brick.XBrick + "    " + brick.YBrick);
                        HandleReboundUpDown(ball);
                    }
                    else
                    {
                        Console.WriteLine("Rebond à droite      " + brick.XBrick + "    " + brick.YBrick);
                        HandleReboundLeftRight(ball);
                    }
                }

            }
            else
            //la balle a touché la brique à gauche
            {
                if (centerBall.X > (centerBrick.X - widthBrick / 2))
                {
                    Console.WriteLine("Rebond à gauche en bas ou en haut     " + brick.XBrick + "    " + brick.YBrick);
                    HandleReboundUpDown(ball);
                }
                else
                {
                    if ((centerBall.Y + heightBall / 2) < (centerBrick.Y - heightBrick / 2) || (centerBall.Y - heightBall / 2) > (centerBrick.Y + heightBrick / 2))
                    {
                        Console.WriteLine("Rebond à gauche en bas ou en haut        " + brick.XBrick + "    " + brick.YBrick);
                        HandleReboundUpDown(ball);
                    }
                    else
                    {
                        Console.WriteLine("Rebond à gauche      " + brick.XBrick + "    " + brick.YBrick);
                        HandleReboundLeftRight(ball);
                    }
                }

            }

            model.UpdateBrickLife(brick, brick.Life - 1);

            //si la brique est détruite et contient un bonus on ajoute le bonus
            if (brick.Life == -1 && brick.Bonus != null)
            {
                model.AddBonus(brick.Bonus);
                brick.Bonus.Position = brick.Position;
            }

        }

        public static void HandleReboundLeftRight(Ball ball)
        {
            if ((ball.Deplacement.X > 0 || ball.Deplacement.X < 0) && (ball.Deplacement.Y < 0 || ball.Deplacement.Y > 0))
            {
                ball.Deplacement = Vector2.Normalize(new Vector2(-ball.Deplacement.X, ball.Deplacement.Y));
            }
        }

        public static void HandleReboundUpDown(Ball ball)
        {
            if ((ball.Deplacement.X > 0 || ball.Deplacement.X < 0) && (ball.Deplacement.Y > 0 || ball.Deplacement.Y < 0))
            {
                ball.Deplacement = Vector2.Normalize(new Vector2(ball.Deplacement.X, -ball.Deplacement.Y));
            }
        }

        /*public static void HandleReboundBar(Ball ball, Bar bar)
        {
         *  double MAX_THETA_REBOUND = Math.PI/2;
         *  
            //calcul du theta de la rotation
            Vector2 centerbar = bar.GetCenter();
            float ratioRotation = Math.Abs(centerbar.X - ball.Position.X) / bar.Size.Width;
            double theta = ratioRotation * MAX_THETA_REBOUND;

            //calcul du nouveau vecteur de déplacement
            Vector2 deplacement = ball.Deplacement;
            double hypothenus = deplacement.Length();
            float newX = (float)(Math.Cos(theta) * hypothenus);
            float newY = (float)(Math.Sin(theta) * hypothenus);
            Console.WriteLine("Raio angle: " + theta+"    size: "+hypothenus );
            ball.Deplacement = Vector2.Normalize(new Vector2(newX, -newY));
        }*/
    }
}
