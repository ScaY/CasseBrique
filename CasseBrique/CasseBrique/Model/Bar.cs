using Microsoft.Xna.Framework;

namespace Breakout.Model
{
    /// <summary>
    /// This is a class tha represents a bar.
    /// </summary>
    public class Bar : Shape
    {
        /// <summary>
        /// Gets or sets the ball stuck to the bar at the beginning of a game.
        /// </summary>
        /// <value>
        /// The start ball.
        /// </value>
        public Ball StartBall { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bar"/> class.
        /// </summary>
        public Bar() : base()
        {
        }

        /// <summary>
        /// Gets the bounding box of the bar.
        /// </summary>
        /// <returns>a rectangle corresponding to the bounding box of the bar</returns>
        public Rectangle getRectangle()
        {
            return new Rectangle((int)Position.X, (int)Position.Y, Size.Width, Size.Height);

        }

        /// <summary>
        /// Gets the center of the bar.
        /// </summary>
        /// <returns>the center of the bar</returns>
        public Vector2 GetCenter()
        {
            return new Vector2(this.Position.X + this.Size.Width / 2, this.Position.Y + this.Size.Height);
        }

        /// <summary>
        /// Handles the trajectory.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="gameTime">The game time.</param>
        /// <param name="heightFrame">The height frame.</param>
        /// <param name="widthFrame">The width frame.</param>
        public override void HandleTrajectory(BreakoutModel model, GameTime gameTime, int heightFrame, int widthFrame)
        {
        }
    }
}
