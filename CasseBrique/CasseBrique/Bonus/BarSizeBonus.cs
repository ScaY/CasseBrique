using Breakout.Model;

namespace Breakout.Bonus
{
    public class BarSizeBonus : BarBonus
    {
        public override void ApplyBonus(Model.BreakoutModel model, Player player)
        {
            player.Bar.Size.Width *= (int)Modifier;
        }

        public override void RemoveBonus(BreakoutModel model, Player player)
        {
            player.Bar.Size.Width /= (int)Modifier;
        }
        public BarSizeBonus():base()
        {
        }
        public BarSizeBonus(float modifier, int duration) : base(modifier, duration)
        {
        }
    }
}
