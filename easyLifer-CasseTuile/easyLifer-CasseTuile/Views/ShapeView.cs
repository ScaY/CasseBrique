using Breakout.Events;
using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Breakout.Views
{
    /// <summary>
    /// This is a class that represents a shape on the view.
    /// </summary>
    public abstract class ShapeView : View
    {
        /// <summary>
        /// Gets or sets the shape.
        /// </summary>
        /// <value>
        /// The shape.
        /// </value>
        public Shape Shape { get; set; }

        /// <summary>
        /// The texture (the image)
        /// </summary>
        private Texture2D texture;

        /// <summary>
        /// Gets or sets the texture.
        /// </summary>
        /// <value>
        /// The texture.
        /// </value>
        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeView"/> class.
        /// </summary>
        /// <param name="shape">The shape.</param>
        public ShapeView(Shape shape)
        {
            this.Shape = shape;
        }

        /// <summary>
        /// Draws the texture of the shape using the sprite bach.
        /// </summary>
        /// <param name="spriteBatch">The sprite batch.</param>
        /// <param name="gameTime">The game time.</param>
        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            float scale = (float)Shape.Size.Width / texture.Width;
            spriteBatch.Draw(this.Texture, Shape.Position, null, Color.White, 0, Vector2.Zero, scale, SpriteEffects.None, 1);   
        }

        /// <summary>
        /// Refreshes the view according to the specified e.
        /// </summary>
        /// <param name="e">The event fired.</param>
        public void Refresh(Event e)
        {

        }
    }
}
