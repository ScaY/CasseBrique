using Breakout.Model;

namespace Breakout.Events
{
    /// <summary>
    /// This is a class that represents an event when a ball is removed.
    /// </summary>
    public class RemovedBallEvent : BallEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemovedBallEvent" /> class.
        /// </summary>
        public RemovedBallEvent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemovedBallEvent" /> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="ball">The ball.</param>
        public RemovedBallEvent(AbstractModel model, Ball ball) : base(model, ball)
        {
        }
    }
}
