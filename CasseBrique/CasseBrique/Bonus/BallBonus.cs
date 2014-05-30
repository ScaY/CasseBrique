
namespace Breakout.Bonus
{
    public abstract class BallBonus : AbstractBonus
    {

        public BallBonus():base()
        {

        }
        public BallBonus(float modifier, int duration) : base(modifier, duration)
        {
        }
    }
}
