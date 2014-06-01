using Breakout.Model;

namespace Breakout.Events
{
    /// <summary>
    /// This is a class that represents an event of the brick.
    /// </summary>
    public abstract class BrickEvent : Event
    {
        /// <summary>
        /// Gets or sets the brick.
        /// </summary>
        /// <value>
        /// The brick.
        /// </value>
        public Brick Brick { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrickEvent"/> class.
        /// </summary>
        public BrickEvent() : this(null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrickEvent"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="brick">The brick.</param>
        public BrickEvent(AbstractModel model, Brick brick) : base(model)
        {
            this.Brick = brick;
        }
    }
}
