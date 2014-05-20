using CasseBrique.Views;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace CasseBrique
{
    public class ViewBar : ShapeView
    {
        public Bar Bar { get; set; }

        public ViewBar(Bar bar,  Texture2D texture) : base(texture)
        {
            this.Bar = bar;
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(this.Texture, Bar.Position, Color.White);
        }
    }
}
