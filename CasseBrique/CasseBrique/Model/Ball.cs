using Microsoft.Xna.Framework;
using System.Collections;

namespace Breakout.Model
{//ceci est un commentaire
    public class Ball : Shape
    {
        public Hashtable briksHit { get; set; }

        public Ball()
            : base(Vector2.Zero, Vector2.Normalize(new Vector2(-1)), 0.2f, new Size(0, 0))
        {
            this.briksHit = new Hashtable();
        }

        public Ball(Vector2 position, Vector2 deplacement, float speed)
            : base(position, deplacement, speed, new Size(0, 0))
        {
            this.briksHit = new Hashtable();
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

            HandleTrajectoryBallReboundFrame(gameTime, heightFrame, widthFrame);

            HandleBallReboundBrick(model);

            Position += Deplacement * Speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
        }

        public void HandleTrajectoryBallReboundBar(Bar bar, GameTime gameTime, int heightFrame, int widthFrame)
        {
            if (bar.getRectangle().Intersects(this.GetBox()))
            {
                RuleBall.HandleReboundUpDown(this);

                this.briksHit.Clear();
            }

        }

        public void HandleTrajectoryBallReboundFrame(GameTime gameTime, int heightFrame, int widthFrame)
        {
            //rebond à gauche ou à droite
            if ((Position.X < 0 || Position.X > widthFrame))
            {
                RuleBall.HandleReboundLeftRight(this);
                this.briksHit.Clear();
            }
            //rebond en haut
            else if (Position.Y < 0)
            {
                RuleBall.HandleReboundUpDown(this);
                this.briksHit.Clear();
            }


        }

        public void HandleBallReboundBrick(BreakoutModel model)
        {
            BrickZone bricks = model.BrickZone;

            Hashtable bricksHit = RuleBall.GetBrickHit(this, bricks);
            if (bricksHit.Count != 0)
            {
                RuleBall.HandleDeplacementHitBrick(model, bricksHit, this);
            }

            this.briksHit = bricksHit;
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