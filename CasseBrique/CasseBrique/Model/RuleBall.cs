using Microsoft.Xna.Framework;
using System;
using System.Collections;

namespace Breakout.Model
{//ceci est un commentaire
    public static class RuleBall
    {
        public static Hashtable GetBrickHit(Ball ball, BrickZone bricks)
        {
            Hashtable listBrick = new Hashtable();
            Brick brickHit = null;

            Vector2 positionBall = ball.Position;
            //la balle et dans la zone de brique
            if (CheckBallEnterBlockBrick(ball, bricks))
            {
                int width = ball.Size.Width;
                int height = ball.Size.Height;

                //teste le coin en haut à gauche
                int brickX = (int)((positionBall.X - bricks.StartBlockBrickX) / bricks.WidthBrick);
                int brickY = (int)((positionBall.Y - bricks.StartBlockBrickY) / bricks.HeightBrick);
                brickHit = bricks.GetBrick(brickX, brickY);
                HandleBricksHit(ball, listBrick, brickHit);

                //teste le coin en haut à droite
                brickX = (int)((positionBall.X + width - bricks.StartBlockBrickX) / bricks.WidthBrick);
                brickY = (int)((positionBall.Y - bricks.StartBlockBrickY) / bricks.HeightBrick);
                brickHit = bricks.GetBrick(brickX, brickY);
                HandleBricksHit(ball, listBrick, brickHit);

                //teste le coin en bas à droite
                brickX = (int)((positionBall.X + width - bricks.StartBlockBrickX) / bricks.WidthBrick);
                brickY = (int)((positionBall.Y + height - bricks.StartBlockBrickY) / bricks.HeightBrick);
                brickHit = bricks.GetBrick(brickX, brickY);
                HandleBricksHit(ball, listBrick, brickHit);

                //teste le coin en bas à gauche
                brickX = (int)((positionBall.X - bricks.StartBlockBrickX) / bricks.WidthBrick);
                brickY = (int)((positionBall.Y + height - bricks.StartBlockBrickY) / bricks.HeightBrick);
                brickHit = bricks.GetBrick(brickX, brickY);
                HandleBricksHit(ball, listBrick, brickHit);

            }

            return listBrick;
        }

        public static void HandleBricksHit(Ball ball, Hashtable listBrick, Brick brickHit)
        {
            if (brickHit != null)
            {
                if (ball.briksHit.Count == 0)
                {
                    if (!listBrick.ContainsKey(brickHit.ToString()))
                    {
                        listBrick.Add(brickHit.ToString(), brickHit);
                    }

                }
                else
                {
                    foreach (Brick brickHited in ball.briksHit.Values)
                    {
                        if (!brickHit.Equals(brickHited))
                        {
                            if (!listBrick.ContainsKey(brickHit.ToString()))
                            {
                                listBrick.Add(brickHit.ToString(), brickHit);
                            }
                        }
                    }
                }

            }
        }

        public static bool CheckBallEnterBlockBrick(Ball ball, BrickZone bricks)
        {
            Rectangle boxBall = ball.GetBox();
            Rectangle boxZone = bricks.GetBox();

            return boxBall.Intersects(boxZone);
        }

        public static void HandleDeplacementHitBrick(BreakoutModel model, Hashtable bricksHit, Ball ball)
        {
            Brick brick = null;
            foreach (Brick b in bricksHit.Values)
            {
                brick = (Brick)b;
            }

            if (bricksHit.Count == 1)
            {
                HandleHitOneBrick(brick, ball);
            }
            else if (bricksHit.Count == 2)
            {
                HandleHitTwoBrick(bricksHit, ball);
            }
            else if (bricksHit.Count == 3)
            {
                HandleHitThreeBrick(bricksHit, ball);
            }

            //maj de la vie des briques
            foreach (Brick brickHit in bricksHit.Values)
            {
                model.UpdateBrickLife(brickHit, brickHit.Life - 1);
            }

            //si la brique est détruite et contient un bonus on ajoute le bonus
            foreach (Brick brickHit in bricksHit.Values)
            {
                if (brickHit.Life < 0 && brickHit.Bonus != null)
                {
                    model.AddBonus(brickHit.Bonus);
                    brickHit.Bonus.Position = brickHit.Position;
                }
            }
        }
        public static void HandleHitThreeBrick(Hashtable listBrick, Ball ball)
        {
            ball.Deplacement = new Vector2(-ball.Deplacement.X, -ball.Deplacement.Y);
        }

        public static void HandleHitTwoBrick(Hashtable listBrick, Ball ball)
        {
            bool sameX = false;
            bool sameY = false;
            Brick previousBrick = null;

            foreach (Brick b in listBrick.Values)
            {
                if (previousBrick == null)
                {
                    previousBrick = b;
                }
                else
                {
                    if (previousBrick.XBrick == b.XBrick)
                    {
                        sameX = true;
                    }
                    else if (previousBrick.YBrick == b.YBrick)
                    {
                        sameY = true;
                    }
                }
            }

            if (sameX)
            {
                HandleReboundLeftRight(ball);
            }
            else if (sameY)
            {
                HandleReboundUpDown(ball);
            }
        }

        public static void HandleHitOneBrick(Brick brick, Ball ball)
        {

            Vector2 centerBall = ball.GetCenterBall();

            int widthBrick = brick.Size.Width;
            int heightBrick = brick.Size.Height;
            int heightBall = ball.Size.Height;
            int widthBall = ball.Size.Width;

            Vector2 centerBrick = new Vector2(brick.Position.X + widthBrick / 2, brick.Position.Y + heightBrick / 2);

            //la balle a touché la brique à droite
            if (centerBall.X > centerBrick.X)
            {
                Console.WriteLine("Brique TOUCHE à droite");
                if ((ball.Deplacement.X > 0 && ball.Deplacement.Y > 0) || (ball.Deplacement.X > 0 && ball.Deplacement.Y < 0))
                {
                    Console.WriteLine("     Rebond en bas ou ne haut");
                    HandleReboundUpDown(ball);
                }
                //gestion de coin en bas à droite
                else if (ball.Deplacement.X < 0 && ball.Deplacement.Y < 0)
                {
                    float diffX = centerBall.X - (centerBrick.X + widthBrick / 2);
                    float diffY = centerBall.Y - (centerBrick.Y + heightBrick / 2);
                    HandlediffXDiffY(diffX, diffY, ball);

                }//gestion du coin en haut à droite
                else if (ball.Deplacement.X < 0 && ball.Deplacement.Y > 0)
                {
                    float diffX = centerBall.X - (centerBrick.X + widthBrick / 2);
                    float diffY = (centerBrick.Y - heightBrick / 2) - centerBall.Y;
                    HandlediffXDiffY(diffX, diffY, ball);
                }
            }
            else
            //la balle a touché la brique à gauche
            {
                Console.WriteLine("Brique TOUCHE à gauche");
                if ((ball.Deplacement.X < 0 && ball.Deplacement.Y < 0) || (ball.Deplacement.X < 0 && ball.Deplacement.Y > 0))
                {
                    Console.WriteLine("     Rebond en bas ou ne haut");
                    HandleReboundUpDown(ball);
                }
                //gestion de coin en bas à gauche
                else if (ball.Deplacement.X > 0 && ball.Deplacement.Y < 0)
                {
                    float diffX = centerBall.X - (centerBrick.X - widthBrick / 2);
                    float diffY = centerBall.Y - (centerBrick.Y + heightBrick / 2);
                    HandlediffXDiffY(diffX, diffY, ball);

                }//gestion du coin en haut à gauche
                else if (ball.Deplacement.X > 0 && ball.Deplacement.Y > 0)
                {
                    float diffX = centerBall.X - (centerBrick.X - widthBrick / 2);
                    float diffY = (centerBrick.Y - heightBrick / 2) - centerBall.Y;
                    HandlediffXDiffY(diffX, diffY, ball);
                }
            }
        }

        public static void HandlediffXDiffY(float diffX, float diffY, Ball ball)
        {
            Console.WriteLine("                 diffX: " + diffX + "   " + diffY);
            if (diffX < 0 && diffY > 0)
            {
                //rebond en bas
                Console.WriteLine("     Rebond en bas");
                HandleReboundUpDown(ball);
            }
            else if (diffX > 0 && diffY < 0)
            {
                Console.WriteLine("     Rebond à gauche");
                HandleReboundLeftRight(ball);
            }
            if (diffX < 0 && diffY < 0)
            {
                if (diffX < diffY)
                {
                    Console.WriteLine("     Rebond en haut");
                    HandleReboundUpDown(ball);

                }
                else
                {
                    Console.WriteLine("     Rebond à gauche");
                    HandleReboundLeftRight(ball);
                }
            }
            else if (diffX > 0 && diffY > 0)
            {
                if (diffX > diffY)
                {
                    Console.WriteLine("     Rebond en haut");
                    HandleReboundUpDown(ball);
                }
                else
                {
                    Console.WriteLine("     Rebond à gauche");
                    HandleReboundLeftRight(ball);
                }
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
* double MAX_THETA_REBOUND = Math.PI/2;
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
Console.WriteLine("Raio angle: " + theta+" size: "+hypothenus );
ball.Deplacement = Vector2.Normalize(new Vector2(newX, -newY));
}*/
    }
}