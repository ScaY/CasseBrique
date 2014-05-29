using Breakout.Events;
using Breakout.Model;
using Breakout.Views;
using CasseBrique.Events;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CasseBrique.Views
{
    public class ViewPause : View
    {
        public Texture2D Texture { get; set; }

        public Vector2 Position { get; set; }

        public bool Display { get; set; }
        public ViewPause()
        {
            this.Display = false;
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            if (this.Display)
            {
                spriteBatch.Draw(this.Texture, this.Position, null, Color.White);
            }
        }

        public void LoadContent(Texture2D texture, int widthFrame, int heightFrame)
        {
            this.Texture = texture;
            this.Position = new Vector2(widthFrame/2 - this.Texture.Bounds.Width / 2, heightFrame / 2 - this.Texture.Bounds.Height / 2);
        }

        public void Refresh(Event e)
        {
            if (e is GamePause)
            {
                GamePause srcEvt = (GamePause)e;
                BreakoutModel model = (BreakoutModel)srcEvt.Model;
                this.Display = (model.Pause && !model.IsGameLost() && !model.IsGameWon());
            }
        }
    }
}
