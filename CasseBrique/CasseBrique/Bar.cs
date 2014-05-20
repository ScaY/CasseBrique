using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace CasseBrique
{
    public class Bar : Shape
    {

        public Bar() : base()
        {

        }

        public Bar(Vector2 position, Vector2 deplacement, float speed) : base(position, deplacement, speed)
        {

        }

        public Rectangle getRectangle()
        {
            if (Views != null && Views[0] != null)
            {
                return new Rectangle((int)Position.X, (int)Position.Y, Views[0].Texture.Width, Views[0].Texture.Height);
            }
            else
            {
                return new Rectangle();
            }
        }

    }
}
