using Breakout.Bonus;
using Breakout.Model;

namespace Breakout.Events
{
    /// <summary>
    /// This is a class that represents an event when a bonus is removed.
    /// </summary>
    public class RemovedBonusEvent : BonusEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemovedBonusEvent"/> class.
        /// </summary>
        public RemovedBonusEvent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemovedBonusEvent"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="bonus">The bonus.</param>
        public RemovedBonusEvent(AbstractModel model, AbstractBonus bonus) : base(model, bonus)
        {
        }
    }
}
