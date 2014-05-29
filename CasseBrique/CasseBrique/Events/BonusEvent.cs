using Breakout.Bonus;
using Breakout.Model;

namespace Breakout.Events
{
    public abstract class BonusEvent : Event
    {
        public AbstractBonus Bonus { get; set; }

        public BonusEvent() : this(null, null)
        {
        }

        public BonusEvent(AbstractModel model, AbstractBonus bonus) : base(model)
        {
            this.Bonus = bonus;
        }
    }
}
