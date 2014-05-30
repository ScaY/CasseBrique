using Microsoft.Xna.Framework;

namespace Breakout.Model
{
    /// <summary>
    /// This class represents a shape.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// The position
        /// </summary>
        private Vector2 position;

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        /// <summary>
        /// The deplacement
        /// </summary>
        private Vector2 deplacement;

        /// <summary>
        /// Gets or sets the deplacement.
        /// </summary>
        /// <value>
        /// The deplacement.
        /// </value>
        public Vector2 Deplacement
        {
            get { return deplacement; }
            set { deplacement = value; }
        }

        /// <summary>
        /// The speed
        /// </summary>
        private float speed;

        /// <summary>
        /// Gets or sets the speed.
        /// </summary>
        /// <value>
        /// The speed.
        /// </value>
        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public Size Size { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="deplacement">The deplacement.</param>
        /// <param name="speed">The speed.</param>
        /// <param name="size">The size.</param>
        public Shape(Vector2 position, Vector2 deplacement, float speed, Size size)
        {
            this.Position = position;
            this.Deplacement = deplacement;
            this.Speed = speed;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class.
        /// </summary>
        public Shape() : this(Vector2.Zero, Vector2.UnitX, 0.5f, new Size(0, 0))
        {
        }

        /// <summary>
        /// Handles the trajectory.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="gameTime">The game time.</param>
        /// <param name="heightFrame">The height of the frame.</param>
        /// <param name="widthFrame">The width of the frame.</param>
        public abstract void HandleTrajectory(BreakoutModel model, GameTime gameTime, int heightFrame, int widthFrame);
    }
}
