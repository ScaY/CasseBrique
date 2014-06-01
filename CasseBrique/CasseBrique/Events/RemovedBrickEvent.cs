using Breakout.Model;

namespace Breakout.Events
{
    /// <summary>
    /// This is a class that represents an event when a brick is removed.
    /// </summary>
    public class RemovedBrickEvent : BrickEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemovedBrickEvent"/> class.
        /// </summary>
        public RemovedBrickEvent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemovedBrickEvent"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="brick">The brick.</param>
        public RemovedBrickEvent(AbstractModel model, Brick brick) : base(model, brick)
        {
        }
    }
}
