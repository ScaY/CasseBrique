using Breakout.Model;
using Breakout.Views;
using CasseBrique.Model;
using Microsoft.Xna.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;

namespace Breakout.Model
{
    /// <summary>
    /// This is a class that represens a ball.
    /// </summary>
    public class Ball : Shape
    {
        /// <summary>
        /// Gets or sets the briks hit.
        /// </summary>
        /// <value>
        /// The briks hit.
        /// </value>
        public Hashtable briksHit { get; set; }

        /// <summary>
        /// Gets or sets the border hit.
        /// </summary>
        /// <value>
        /// The border hit.
        /// </value>
        public BorderFrame BorderHit { get; set; }

        /// <summary>
        /// Gets or sets the sound of the ball when she hited the bar.
        /// </summary>
        /// <value>
        /// The sound of the ball when she hited the bar.
        /// </value>
        public SoundPlayer SoundReboundBar { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the bar was hit.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the bar was hit; otherwise, <c>false</c>.
        /// </value>
        public bool BarHit { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ball"/> class.
        /// </summary>
        public Ball()
            : base(Vector2.Zero, Vector2.Normalize(new Vector2((float)(0.1), -1)), 0.2f, new Size(0, 0))
        {
            this.BarHit = false;
            this.briksHit = new Hashtable();
            this.BorderHit = BorderFrame.NONE;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ball"/> class.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="deplacement">The deplacement.</param>
        /// <param name="speed">The speed.</param>
        public Ball(Vector2 position, Vector2 deplacement, float speed)
            : base(position, deplacement, speed, new Size(0, 0))
        {
            this.BarHit = false;
            this.briksHit = new Hashtable();
            this.BorderHit = BorderFrame.NONE;
        }

        /// <summary>
        /// Handles the trajectory.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="gameTime">The game time.</param>
        /// <param name="heightFrame">The height frame.</param>
        /// <param name="widthFrame">The width frame.</param>
        public override void HandleTrajectory(BreakoutModel model, GameTime gameTime, int heightFrame, int widthFrame)
        {
            BrickZone bricks = model.BrickZone;

            //the ball gets out of the game
            if (Position.Y > heightFrame)
            {
                //when the ball is out we remove it of the game
                model.RemoveBall(this);
            }

            //for the bar of each player, we check if the ball hit it, and makes it bounce in that case
            foreach (Player player in model.Players)
            {
                Bar bar = player.Bar;
                HandleTrajectoryBallReboundBar(bar, gameTime, heightFrame, widthFrame);
            }

            //same thing for the bricks and the borders of the frame
            HandleBallReboundBrick(model);
            HandleTrajectoryBallReboundFrame(gameTime, heightFrame, widthFrame);

            Position += Deplacement * Speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
        }

        /// <summary>
        /// Handles the trajectory when the ball bounces on a bar.
        /// </summary>
        /// <param name="bar">The bar.</param>
        /// <param name="gameTime">The game time.</param>
        /// <param name="heightFrame">The height of the frame.</param>
        /// <param name="widthFrame">The width of the frame.</param>
        public void HandleTrajectoryBallReboundBar(Bar bar, GameTime gameTime, int heightFrame, int widthFrame)
        {
            if (bar.getRectangle().Intersects(this.GetBox()))
            {
                if (!this.BarHit)
                {
                    RuleBall.HandleReboundBar(this, bar);
                    this.BarHit = true;

                    if (this.SoundReboundBar != null)
                    {
                        this.SoundReboundBar.Play();
                    }
                }

                this.briksHit.Clear();
            }
            else
            {
                this.BarHit = false;
            }

        }

        /// <summary>
        /// Handles the trajectory when the ball bounces on the frame.
        /// </summary>
        /// <param name="gameTime">The game time.</param>
        /// <param name="heightFrame">The height frame.</param>
        /// <param name="widthFrame">The width frame.</param>
        public void HandleTrajectoryBallReboundFrame(GameTime gameTime, int heightFrame, int widthFrame)
        {
            //rebond à gauche 
            if ((Position.X - this.Size.Width / 2) < 0 && this.BorderHit != BorderFrame.BORDERLEFT)
            {
                RuleBall.HandleReboundLeftRight(this);
                this.BorderHit = BorderFrame.BORDERLEFT;
                this.briksHit.Clear();
            }
            else if (Position.X + this.Size.Width / 2 > widthFrame && this.BorderHit != BorderFrame.BORDERRIGHT)
            {
                RuleBall.HandleReboundLeftRight(this);
                this.BorderHit = BorderFrame.BORDERRIGHT;
                this.briksHit.Clear();
            }
            //rebond en haut
            else if ((Position.Y - this.Size.Height / 2) < 0 && this.BorderHit != BorderFrame.TOP)
            {
                RuleBall.HandleReboundUpDown(this);
                this.BorderHit = BorderFrame.TOP;
                this.briksHit.Clear();
            }
            //la balle est dans la zone
            else if (((Position.Y - this.Size.Height / 2) > 0) && (Position.X - this.Size.Width / 2) > 0 && (Position.X + this.Size.Width / 2 < widthFrame))
            {
                this.BorderHit = BorderFrame.NONE;
            }
        }

        /// <summary>
        /// Handles when the ball bounces on a brick.
        /// </summary>
        /// <param name="model">The model.</param>
        public void HandleBallReboundBrick(BreakoutModel model)
        {
            BrickZone bricks = model.BrickZone;

            Hashtable newBricksHit = RuleBall.GetBrickHit(this, bricks);

            if (newBricksHit.Count != 0)
            {
                RuleBall.HandleDeplacementHitBrick(model, newBricksHit, this);
                this.briksHit = newBricksHit;
                this.BorderHit = BorderFrame.NONE;
            }
        }

        /// <summary>
        /// Gets the bounding box of the ball.
        /// </summary>
        /// <returns>a rectangle corresponding to the bounding box of the ball</returns>
        public Rectangle GetBox()
        {
            return new Rectangle((int)Position.X, (int)Position.Y, (int)this.Size.Width, (int)this.Size.Height);
        }

        /// <summary>
        /// Gets the center ball.
        /// </summary>
        /// <returns>the center of the ball</returns>
        public Vector2 GetCenterBall()
        {
            return new Vector2(this.Position.X + this.Size.Width / 2, this.Position.Y + this.Size.Height / 2);
        }
    }
}