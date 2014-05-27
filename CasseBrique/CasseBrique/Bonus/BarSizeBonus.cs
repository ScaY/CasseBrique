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
            player.Bar.Size.Width += Modifier;
        }

        public override void RemoveBonus(BreakoutModel model, Player player)
        {
            player.Bar.Size.Width -= Modifier;
        }

        public BarSizeBonus(int modifier, int duration) : base(modifier, duration)
        {
        }
    }
}
