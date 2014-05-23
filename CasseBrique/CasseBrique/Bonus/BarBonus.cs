using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Bonus
{
    public abstract class BarBonus : AbstractBonus
    {
        public BarBonus(int modifier, int duration) : base(modifier, duration)
        {
        }
    }
}
