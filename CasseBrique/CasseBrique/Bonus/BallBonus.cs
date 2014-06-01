
namespace Breakout.Bonus
{
    /// <summary>
    /// This is class represents a bonus that acts on a ball.
    /// </summary>
    public abstract class BallBonus : AbstractBonus
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BallBonus"/> class.
        /// </summary>
        public BallBonus():base()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BallBonus"/> class.
        /// </summary>
        /// <param name="modifier">The modifier.</param>
        /// <param name="duration">The duration.</param>
        public BallBonus(float modifier, int duration) : base(modifier, duration)
        {
        }
    }
}
