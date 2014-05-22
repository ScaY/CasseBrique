using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Breakout.Views
{
    public class ViewBrick : ShapeView
    {
        public Brick Brick { get; set; }

        public ViewBrick(Brick brick, Texture2D texture) : base(texture)
        {
            this.Brick = brick;
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(this.Texture, this.Brick.Position, Color.White);
        }
    }
}
