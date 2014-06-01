using Breakout.Model;

namespace Breakout.Events
{
    /// <summary>
    /// This is a class that represents an abstract event.
    /// </summary>
    public abstract class Event
    {
        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public AbstractModel Model { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        public Event() : this(null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        public Event(AbstractModel model)
        {
            this.Model = model;
        }
    }
}
