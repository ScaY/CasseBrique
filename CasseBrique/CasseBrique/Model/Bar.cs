using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Breakout.Model
{
    public class Bar : Shape
    {
        public Bar() : base()
        {
        }

        public Bar(Vector2 position, Vector2 deplacement, float speed, int width, int height, Size size) : base(position, deplacement, speed, size)
        {
        }

        public Rectangle getRectangle()
        {
            return new Rectangle((int)Position.X, (int)Position.Y, Size.Width, Size.Height);

        }

        public override void HandleTrajectory(BreakoutModel model, GameTime gameTime, int heightFrame, int widthFrame)
        {
        }
    }
}
