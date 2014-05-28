using Breakout.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Bonus
{
    public class BallSpeedBonus : BallBonus
    {
        public override void ApplyBonus(Model.BreakoutModel model, Player player)
        {
            foreach(Ball ball in model.Balls) {
                ball.Speed += Modifier;
            }
        }

        public override void RemoveBonus(BreakoutModel model, Player player)
        {
            foreach (Ball ball in model.Balls)
            {
                ball.Speed -= Modifier;
            }
        }

        public BallSpeedBonus(float modifier, int duration) : base(modifier, duration)
        {
        }
        public BallSpeedBonus()
        {
        }
    }
}
