using CasseBrique;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Breakout.Events;

namespace Breakout.Views
{
    public interface View
    {
        void Refresh(Event e);
        void Draw(SpriteBatch spriteBatch, GameTime gameTime);
    }
}