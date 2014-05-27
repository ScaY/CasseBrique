using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Bonus
{
    public abstract class BallBonus : AbstractBonus
    {
        public BallBonus(float modifier, int duration) : base(modifier, duration)
        {
        }
    }
}
