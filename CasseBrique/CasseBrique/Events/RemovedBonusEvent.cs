using Breakout.Bonus;
using Breakout.Model;

namespace Breakout.Events
{
    public class RemovedBonusEvent : BonusEvent
    {
        public RemovedBonusEvent()
        {
        }

        public RemovedBonusEvent(AbstractModel model, AbstractBonus bonus) : base(model, bonus)
        {
        }
    }
}
