using Breakout.Model;

namespace Breakout.Events
{
    /// <summary>
    /// This is a class that represents an event when a ball is added.
    /// </summary>
    public class AddedBallEvent : BallEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddedBallEvent"/> class.
        /// </summary>
        public AddedBallEvent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddedBallEvent"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="ball">The ball.</param>
        public AddedBallEvent(AbstractModel model, Ball ball) : base(model, ball)
        {
        }
    }
}
