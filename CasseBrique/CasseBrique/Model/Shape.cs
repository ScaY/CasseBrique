using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Breakout.Model
{
    public abstract class Shape
    {
        private Vector2 position;

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        private Vector2 deplacement;

        public Vector2 Deplacement
        {
            get { return deplacement; }
            set { deplacement = value; }
        }

        private float speed;

        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public Size Size { get; set; }

        public Shape(Vector2 position, Vector2 deplacement, float speed, Size size)
        {
            this.Position = position;
            this.Deplacement = deplacement;
            this.Speed = speed;
            this.Size = size;
        }

        public Shape() : this(Vector2.Zero, Vector2.UnitX, 0.5f, new Size(0, 0))
        {
        }

        public abstract void HandleTrajectory(BreakoutModel model, GameTime gameTime, int heightFrame, int widthFrame);
    }
}
