using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Breakout.Events;

namespace Breakout.Views
{
    /// <summary>
    /// This class represents a view, and contains the operations shared by all the views.
    /// </summary>
    public interface View
    {
        /// <summary>
        /// Refreshes the view according to the specified e.
        /// </summary>
        /// <param name="e">The event fired.</param>
        void Refresh(Event e);

        /// <summary>
        /// Draws the texture of the view using the sprite bach.
        /// </summary>
        /// <param name="spriteBatch">The sprite batch.</param>
        /// <param name="gameTime">The game time.</param>
        void Draw(SpriteBatch spriteBatch, GameTime gameTime);
    }
}