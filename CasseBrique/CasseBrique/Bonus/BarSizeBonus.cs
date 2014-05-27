using Breakout.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Bonus
{
    public class BarSizeBonus : BarBonus
    {
        public override void ApplyBonus(Model.BreakoutModel model, Player player)
        {
            player.Bar.Size.Width += (int)Modifier;
        }

        public override void RemoveBonus(BreakoutModel model, Player player)
        {
            player.Bar.Size.Width -= (int)Modifier;
        }

        public BarSizeBonus(float modifier, int duration) : base(modifier, duration)
        {
        }
    }
}
