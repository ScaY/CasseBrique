using Breakout.Views;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CasseBrique.Views
{
    public abstract class ShapeView : View
    {
        private Texture2D texture;

        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        public ShapeView(Texture2D texture)
        {
            this.Texture = texture;
        }

        public abstract void Draw(SpriteBatch spriteBatch, GameTime gameTime);
    }
}
