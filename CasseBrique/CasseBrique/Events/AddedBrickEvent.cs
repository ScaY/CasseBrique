using Breakout.Model;

namespace Breakout.Events
{
    /// <summary>
    /// This is a class that represents an event when a brick is added.
    /// </summary>
    public class AddedBrickEvent : BrickEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddedBrickEvent"/> class.
        /// </summary>
        public AddedBrickEvent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddedBrickEvent"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="brick">The brick.</param>
        public AddedBrickEvent(AbstractModel model, Brick brick) : base(model, brick)
        {
        }
    }
}
