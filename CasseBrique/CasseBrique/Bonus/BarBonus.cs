
namespace Breakout.Bonus
{
    /// <summary>
    /// This class represents a bonus that acts on the bars.
    /// </summary>
    public abstract class BarBonus : AbstractBonus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarBonus"/> class.
        /// </summary>
        public BarBonus() : base()
            
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BarBonus"/> class.
        /// </summary>
        /// <param name="modifier">The modifier.</param>
        /// <param name="duration">The duration.</param>
        public BarBonus(float modifier, int duration) : base(modifier, duration)
        {
        }
    }
}
