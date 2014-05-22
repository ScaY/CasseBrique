using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Breakout.Views
{
    public class ViewBall : ShapeView
    {
        public Ball Ball { get; set; }

        public ViewBall(Ball ball, Texture2D texture) : base(texture)
        {
            this.Ball = ball;    
        }

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(this.Texture, this.Ball.Position, Color.White);
        }
    }

}
