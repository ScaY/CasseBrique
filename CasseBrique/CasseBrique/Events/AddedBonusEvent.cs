using Breakout.Bonus;
using Breakout.Model;

namespace Breakout.Events
{
    public class AddedBonusEvent : BonusEvent
    {
        public AddedBonusEvent()
        {
        }

        public AddedBonusEvent(AbstractModel model, AbstractBonus bonus) : base(model, bonus)
        {
        }
    }
}
