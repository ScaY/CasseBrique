using Breakout.Events;
using Breakout.Model;
using CasseBrique.Events;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Breakout.Views
{
    /// <summary>
    /// This class represents the view displayed when the pause is on.
    /// </summary>
    public class ViewPause : View
    {
        /// <summary>
        /// Gets or sets the texture.
        /// </summary>
        /// <value>
        /// The texture.
        /// </value>
        public Texture2D Texture { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public Vector2 Position { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ViewPause"/> is displayed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if displayed; otherwise, <c>false</c>.
        /// </value>
        public bool Display { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewPause"/> class.
        /// </summary>
        public ViewPause()
        {
            this.Display = false;
        }

        /// <summary>
        /// Draws the texture of the pause using the sprite bach.
        /// </summary>
        /// <param name="spriteBatch">The sprite batch.</param>
        /// <param name="gameTime">The game time.</param>
        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            if (this.Display)
            {
                spriteBatch.Draw(this.Texture, this.Position, null, Color.White);
            }
        }

        /// <summary>
        /// Loads the content, here the image and its position.
        /// </summary>
        /// <param name="texture">The texture.</param>
        /// <param name="widthFrame">The width frame.</param>
        /// <param name="heightFrame">The height frame.</param>
        public void LoadContent(Texture2D texture, int widthFrame, int heightFrame)
        {
            this.Texture = texture;
            this.Position = new Vector2(widthFrame/2 - this.Texture.Bounds.Width / 2, heightFrame / 2 - this.Texture.Bounds.Height / 2);
        }

        /// <summary>
        /// Refreshes the view according to the specified e.
        /// </summary>
        /// <param name="e">The event fired.</param>
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
