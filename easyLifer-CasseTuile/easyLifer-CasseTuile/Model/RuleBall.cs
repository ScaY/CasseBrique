using Microsoft.Xna.Framework;
using System;
using System.Collections;

namespace Breakout.Model
{
    /// <summary>
    /// This a class that contains the rule to move the ball.
    /// </summary>
    public static class RuleBall
    {
        /// <summary>
        /// Gets the bricks hit.
        /// </summary>
        /// <param name="ball">The ball.</param>
        /// <param name="bricks">The bricks.</param>
        /// <returns>the bricks hit</returns>
        public static Hashtable GetBrickHit(Ball ball, BrickZone bricks)
        {
            Hashtable listBrick = new Hashtable();
            Brick brickHit = null;

            Vector2 positionBall = ball.Position;
            //the ball is in the brick zone
            if (CheckBallEnterBlockBrick(ball, bricks))
            {
                int width = ball.Size.Width;
                int height = ball.Size.Height;

                //test the top left corner
                int brickX = (int)((positionBall.X - bricks.StartBlockBrickX) / bricks.WidthBrick);
                int brickY = (int)((positionBall.Y - bricks.StartBlockBrickY) / bricks.HeightBrick);
                brickHit = bricks.GetBrick(brickX, brickY);
                HandleBricksHit(ball, listBrick, brickHit);

                //test the top right corner
                brickX = (int)((positionBall.X + width - bricks.StartBlockBrickX) / bricks.WidthBrick);
                brickY = (int)((positionBall.Y - bricks.StartBlockBrickY) / bricks.HeightBrick);
                brickHit = bricks.GetBrick(brickX, brickY);
                HandleBricksHit(ball, listBrick, brickHit);

                //test the bottom right corner
                brickX = (int)((positionBall.X + width - bricks.StartBlockBrickX) / bricks.WidthBrick);
                brickY = (int)((positionBall.Y + height - bricks.StartBlockBrickY) / bricks.HeightBrick);
                brickHit = bricks.GetBrick(brickX, brickY);
                HandleBricksHit(ball, listBrick, brickHit);

                //test the bottom left corner
                brickX = (int)((positionBall.X - bricks.StartBlockBrickX) / bricks.WidthBrick);
                brickY = (int)((positionBall.Y + height - bricks.StartBlockBrickY) / bricks.HeightBrick);
                brickHit = bricks.GetBrick(brickX, brickY);
                HandleBricksHit(ball, listBrick, brickHit);

            }

            return listBrick;
        }

        /// <summary>
        /// Handles the brick hit.
        /// </summary>
        /// <param name="ball">The ball.</param>
        /// <param name="listBrick">The list of bricks.</param>
        /// <param name="brickHit">The brick hit.</param>
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

        /// <summary>
        /// Checks if the ball enter the block of bricks.
        /// </summary>
        /// <param name="ball">The ball.</param>
        /// <param name="bricks">The bricks.</param>
        /// <returns></returns>
        public static bool CheckBallEnterBlockBrick(Ball ball, BrickZone bricks)
        {
            Rectangle boxBall = ball.GetBox();
            Rectangle boxZone = bricks.GetBox();

            return boxBall.Intersects(boxZone);
        }

        /// <summary>
        /// Handles the deplacement when a brick is hit.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="bricksHit">The bricks hit.</param>
        /// <param name="ball">The ball.</param>
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

            //updating the life of the brick
            foreach (Brick brickHit in bricksHit.Values)
            {
                model.UpdateBrickLife(brickHit, brickHit.Life - 1);
            }

            //when the brick is destroyed and contained a bonus, we add it to the game
            foreach (Brick brickHit in bricksHit.Values)
            {
                if (brickHit.Life < 0 && brickHit.Bonus != null)
                {
                    model.AddBonus(brickHit.Bonus);
                    brickHit.Bonus.Position = brickHit.Position;
                }
            }
        }
        /// <summary>
        /// Handles when the three bricks are hit.
        /// </summary>
        /// <param name="listBrick">The list of bricks.</param>
        /// <param name="ball">The ball.</param>
        public static void HandleHitThreeBrick(Hashtable listBrick, Ball ball)
        {
            ball.Deplacement = new Vector2(-ball.Deplacement.X, -ball.Deplacement.Y);
        }

        /// <summary>
        /// Handles when two bricks are hit.
        /// </summary>
        /// <param name="listBrick">The list of bricks.</param>
        /// <param name="ball">The ball.</param>
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

        /// <summary>
        /// Handles when only one brick is hit.
        /// </summary>
        /// <param name="brick">The brick.</param>
        /// <param name="ball">The ball.</param>
        public static void HandleHitOneBrick(Brick brick, Ball ball)
        {

            Vector2 centerBall = ball.GetCenterBall();

            int widthBrick = brick.Size.Width;
            int heightBrick = brick.Size.Height;
            int heightBall = ball.Size.Height;
            int widthBall = ball.Size.Width;

            Vector2 centerBrick = new Vector2(brick.Position.X + widthBrick / 2, brick.Position.Y + heightBrick / 2);

            //the ball hit the brick on the right side
            if (centerBall.X > centerBrick.X)
            {
                if ((ball.Deplacement.X >= 0 && ball.Deplacement.Y >= 0) || (ball.Deplacement.X >= 0 && ball.Deplacement.Y <= 0))
                {
                    HandleReboundUpDown(ball);
                }
                
                //handle the bottom right corner 
               else if (ball.Deplacement.X <= 0 && ball.Deplacement.Y <= 0)
                {
                    float diffX = centerBall.X - (centerBrick.X + widthBrick / 2);
                    float diffY = centerBall.Y - (centerBrick.Y + heightBrick / 2);
                    HandlediffXDiffY(diffX, diffY, ball);

                }//handle the top right corner
                else if (ball.Deplacement.X <= 0 && ball.Deplacement.Y >= 0)
                {
                    float diffX = centerBall.X - (centerBrick.X + widthBrick / 2);
                    float diffY = (centerBrick.Y - heightBrick / 2) - centerBall.Y;
                    HandlediffXDiffY(diffX, diffY, ball);
                }
            }
            else
            //the ball hit the brick on the left side
            {
                if ((ball.Deplacement.X <= 0 && ball.Deplacement.Y <= 0) || (ball.Deplacement.X <= 0 && ball.Deplacement.Y >= 0))
                {
                    HandleReboundUpDown(ball);
                }
                //handle the botoom left corner
                else if (ball.Deplacement.X >= 0 && ball.Deplacement.Y <= 0)
                {
                    float diffX = centerBall.X - (centerBrick.X - widthBrick / 2);
                    float diffY = centerBall.Y - (centerBrick.Y + heightBrick / 2);
                    HandlediffXDiffY(diffX, diffY, ball);

                }//handle the top left corner
                else if (ball.Deplacement.X >= 0 && ball.Deplacement.Y >= 0)
                {
                    float diffX = centerBall.X - (centerBrick.X - widthBrick / 2);
                    float diffY = (centerBrick.Y - heightBrick / 2) - centerBall.Y;
                    HandlediffXDiffY(diffX, diffY, ball);
                }
            }
        }

        /// <summary>
        /// Handlediffs the x difference y.
        /// </summary>
        /// <param name="diffX">The difference x.</param>
        /// <param name="diffY">The difference y.</param>
        /// <param name="ball">The ball.</param>
        public static void HandlediffXDiffY(float diffX, float diffY, Ball ball)
        {
            if (diffX <= 0 && diffY >= 0)
            {
                //bounce in the bottom
                HandleReboundUpDown(ball);
            }
            else if (diffX >= 0 && diffY <= 0)
            {
                HandleReboundLeftRight(ball);
            }
            if (diffX <= 0 && diffY <= 0)
            {
                if (diffX < diffY)
                {
                    HandleReboundUpDown(ball);

                }
                else
                {
                    HandleReboundLeftRight(ball);
                }
            }
            else if (diffX >= 0 && diffY >= 0)
            {
                if (diffX > diffY)
                {
                    HandleReboundUpDown(ball);
                }
                else
                {
                    HandleReboundLeftRight(ball);
                }
            }

        }
        /// <summary>
        /// Handles the bounce on the left and right side.
        /// </summary>
        /// <param name="ball">The ball.</param>
        public static void HandleReboundLeftRight(Ball ball)
        {
            if ((ball.Deplacement.X >= 0 || ball.Deplacement.X <= 0) && (ball.Deplacement.Y <= 0 || ball.Deplacement.Y >= 0))
            {
                ball.Deplacement = Vector2.Normalize(new Vector2(-ball.Deplacement.X, ball.Deplacement.Y));
            }
        }


        /// <summary>
        /// Handles the bounce on the up and bottom side.
        /// </summary>
        /// <param name="ball">The ball.</param>
        public static void HandleReboundUpDown(Ball ball)
        {
            if ((ball.Deplacement.X >= 0 || ball.Deplacement.X <= 0) && (ball.Deplacement.Y >= 0 || ball.Deplacement.Y <= 0))
            {
                ball.Deplacement = Vector2.Normalize(new Vector2(ball.Deplacement.X, -ball.Deplacement.Y));
            }
        }

        /// <summary>
        /// Handles the bounce on the bar.
        /// </summary>
        /// <param name="ball">The ball.</param>
        /// <param name="bar">The bar.</param>
        public static void HandleReboundBar(Ball ball, Bar bar)
        {
            
            double MAX_THETA_REBOUND = 60;

            //compute the angle theta for the rotation
            Vector2 centerbar = bar.GetCenter();
            float ratioRotation = Math.Abs(centerbar.X - ball.GetCenterBall().X) / (bar.Size.Width / 2);

            if (ball.GetCenterBall().X < bar.GetCenter().X)
            {
                if (ball.Deplacement.X > 0 && ball.Deplacement.Y > 0)
                {
                    ratioRotation = 1 - ratioRotation;
                }
            }
            else
            {
                if (ball.Deplacement.X < 0 && ball.Deplacement.Y > 0)
                {
                    ratioRotation = 1 - ratioRotation;
                }
            }
            

            double theta = ratioRotation * MAX_THETA_REBOUND;

            //compute the new vector for the deplacement
            Vector2 deplacement = ball.Deplacement;
            double hypothenus = deplacement.Length();
            float newX = (float)Math.Abs((Math.Sin((theta*Math.PI)/180) * hypothenus));
            float newY = (float)Math.Abs((Math.Cos((theta*Math.PI)/180) * hypothenus));
            if (ball.Deplacement.X < 0)
            {
                newX = -newX;
            }

            if (ball.Deplacement.Y > 0)
            {
                newY = -newY;
            }
            ball.Deplacement = Vector2.Normalize(new Vector2(newX, newY));

        }
    }
}