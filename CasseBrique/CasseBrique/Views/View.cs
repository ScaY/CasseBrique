using CasseBrique;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Breakout.Views
{
    public interface View
    {
        void Draw(SpriteBatch spriteBatch, GameTime gameTime);
    }
}