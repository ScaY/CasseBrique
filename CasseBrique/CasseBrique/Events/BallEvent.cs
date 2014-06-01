using Breakout.Model;

namespace Breakout.Events
{
    /// <summary>
    /// This is a class that represents an abstract event of the ball.
    /// </summary>
    public abstract class BallEvent : Event
    {
        /// <summary>
        /// Gets or sets the ball.
        /// </summary>
        /// <value>
        /// The ball.
        /// </value>
        public Ball Ball { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BallEvent"/> class.
        /// </summary>
        public BallEvent() : this(null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BallEvent"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="ball">The ball.</param>
        public BallEvent(AbstractModel model, Ball ball) : base(model)
        {
            this.Ball = ball;
        }
    }
}
