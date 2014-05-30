using Breakout.Model;
using Breakout.Views;
using CasseBrique.Model;
using Microsoft.Xna.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Model
{//ceci est un commentaire
    public class Ball : Shape
    {
        public Hashtable briksHit { get; set; }

        public BorderFrame BorderHit { get; set; }

        public bool BarHit { get; set; }

        public Ball()
            : base(Vector2.Zero, Vector2.Normalize(new Vector2(0, -1)), 0.2f, new Size(0, 0))
        {
            this.BarHit = false;
            this.briksHit = new Hashtable();
            this.BorderHit = BorderFrame.NONE;
        }

        public Ball(Vector2 position, Vector2 deplacement, float speed)
            : base(position, deplacement, speed, new Size(0, 0))
        {
            this.BarHit = false;
            this.briksHit = new Hashtable();
            this.BorderHit = BorderFrame.NONE;
        }

        public override void HandleTrajectory(BreakoutModel model, GameTime gameTime, int heightFrame, int widthFrame)
        {
            BrickZone bricks = model.BrickZone;

            //balle sort du jeu
            if (Position.Y > heightFrame)
            {
                //si la balle n'est pas rattrapée par le joueur on la supprime
                model.RemoveBall(this);
            }

            foreach (Player player in model.Players)
            {
                Bar bar = player.Bar;
                HandleTrajectoryBallReboundBar(bar, gameTime, heightFrame, widthFrame);
            }

            HandleBallReboundBrick(model);
            HandleTrajectoryBallReboundFrame(gameTime, heightFrame, widthFrame);

            Position += Deplacement * Speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
        }

        public void HandleTrajectoryBallReboundBar(Bar bar, GameTime gameTime, int heightFrame, int widthFrame)
        {
            if (bar.getRectangle().Intersects(this.GetBox()))
            {
                if (!this.BarHit)
                {
                    RuleBall.HandleReboundBar(this, bar);
                    this.BarHit = true;
                }

                this.briksHit.Clear();
            }
            else
            {
                this.BarHit = false;
            }

        }

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

        public Rectangle GetBox()
        {
            return new Rectangle((int)Position.X, (int)Position.Y, (int)this.Size.Width, (int)this.Size.Height);
        }

        public Vector2 GetCenterBall()
        {
            return new Vector2(this.Position.X + this.Size.Width / 2, this.Position.Y + this.Size.Height / 2);
        }
    }
}