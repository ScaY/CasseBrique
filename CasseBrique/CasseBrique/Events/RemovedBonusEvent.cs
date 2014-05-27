using Breakout.Bonus;
using Breakout.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
