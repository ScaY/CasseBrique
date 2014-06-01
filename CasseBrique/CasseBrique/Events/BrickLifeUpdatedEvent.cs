using Breakout.Model;

namespace Breakout.Events
{
    /// <summary>
    /// This is a class that represents an event where the life of a brick is modified.
    /// </summary>
    public class BrickLifeUpdatedEvent : BrickEvent
    {
        /// <summary>
        /// Gets or sets the life.
        /// </summary>
        /// <value>
        /// The life.
        /// </value>
        public int Life { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrickLifeUpdatedEvent"/> class.
        /// </summary>
        public BrickLifeUpdatedEvent()
        {
            this.Life = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrickLifeUpdatedEvent"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="brick">The brick.</param>
        /// <param name="life">The life.</param>
        public BrickLifeUpdatedEvent(AbstractModel model, Brick brick, int life) : base(model, brick)
        {
            this.Life = life;
        }
    }
}
