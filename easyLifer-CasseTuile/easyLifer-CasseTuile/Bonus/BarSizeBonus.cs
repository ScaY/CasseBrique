using Breakout.Model;

namespace Breakout.Bonus
{
    /// <summary>
    /// This class represents a bonus that increases the size of the bar of a player.
    /// </summary>
    public class BarSizeBonus : BarBonus
    {
        /// <summary>
        /// Applies the bonus (increases the size of the bar).
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="player">The player.</param>
        public override void ApplyBonus(Model.BreakoutModel model, Player player)
        {
            player.Bar.Size.Width *= (int)Modifier;
        }

        /// <summary>
        /// Removes the bonus (decreases the size of the bar).
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="player">The player.</param>
        public override void RemoveBonus(BreakoutModel model, Player player)
        {
            player.Bar.Size.Width /= (int)Modifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarSizeBonus"/> class.
        /// </summary>
        public BarSizeBonus():base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarSizeBonus"/> class.
        /// </summary>
        /// <param name="modifier">The modifier.</param>
        /// <param name="duration">The duration.</param>
        public BarSizeBonus(float modifier, int duration) : base(modifier, duration)
        {
        }
    }
}
