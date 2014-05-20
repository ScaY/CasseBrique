using Breakout.Model;
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
    public class ViewBreakout : View
    {
        public ViewBar ViewBar { get; set; }

        public ViewBall ViewBall { get; set; }

        public ViewBricksZone ViewBricksZone { get; set; }

        public ViewBreakout(BreakoutModel breakout, ContentManager content)
        {
            Texture2D textureBar = content.Load<Texture2D>("barMid");
            Texture2D textureBall = content.Load<Texture2D>("ballSmall");
            Texture2D textureBrick = content.Load<Texture2D>("brick3life");

            this.ViewBricksZone = new ViewBricksZone(breakout.BrickZone, textureBrick);
            breakout.BrickZone.InitializeSizeBrick(new Size(textureBrick.Width, textureBrick.Height));
            breakout.BrickZone.InitializePositionBrick();

            this.ViewBar = new ViewBar(breakout.Bar, textureBar);
            this.ViewBall = new ViewBall(breakout.Ball, textureBall);
            this.ViewBricksZone = new ViewBricksZone(breakout.BrickZone, textureBrick);

        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            ViewBall.Draw(spriteBatch, gameTime);
            ViewBar.Draw(spriteBatch, gameTime);
            ViewBricksZone.Draw(spriteBatch, gameTime);
        }
    }
}
