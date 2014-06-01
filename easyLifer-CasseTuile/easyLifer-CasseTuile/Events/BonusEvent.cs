using Breakout.Bonus;
using Breakout.Model;

namespace Breakout.Events
{
    /// <summary>
    /// This is a class that represents an event of the bonus.
    /// </summary>
    public abstract class BonusEvent : Event
    {
        /// <summary>
        /// Gets or sets the bonus.
        /// </summary>
        /// <value>
        /// The bonus.
        /// </value>
        public AbstractBonus Bonus { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BonusEvent"/> class.
        /// </summary>
        public BonusEvent() : this(null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BonusEvent"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="bonus">The bonus.</param>
        public BonusEvent(AbstractModel model, AbstractBonus bonus) : base(model)
        {
            this.Bonus = bonus;
        }
    }
}
