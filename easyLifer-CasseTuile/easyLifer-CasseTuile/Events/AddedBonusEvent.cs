using Breakout.Bonus;
using Breakout.Model;

namespace Breakout.Events
{
    /// <summary>
    /// This is a class that represents an event when a bonus is added.
    /// </summary>
    public class AddedBonusEvent : BonusEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddedBonusEvent"/> class.
        /// </summary>
        public AddedBonusEvent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddedBonusEvent"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="bonus">The bonus.</param>
        public AddedBonusEvent(AbstractModel model, AbstractBonus bonus) : base(model, bonus)
        {
        }
    }
}
