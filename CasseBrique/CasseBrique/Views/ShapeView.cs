using Breakout.Model;
using Breakout.Views;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Views
{
    public abstract class ShapeView : View
    {
        public Shape Shape { get; set; }

        private Texture2D texture;

        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        public ShapeView(Shape shape, Texture2D texture)
        {
            this.Shape = shape;
            this.Texture = texture;
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            float scale = (float)Shape.Size.Width / texture.Width;
            spriteBatch.Draw(this.Texture, Shape.Position, null, Color.White, 0, Vector2.Zero, scale, SpriteEffects.None, 1);   
        }
    }
}
