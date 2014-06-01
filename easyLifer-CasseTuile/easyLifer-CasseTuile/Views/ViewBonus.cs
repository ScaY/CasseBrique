using Breakout.Bonus;

namespace Breakout.Views
{
    /// <summary>
    /// This class represents the view of a bonus.
    /// </summary>
    public class ViewBonus : ShapeView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewBonus"/> class.
        /// </summary>
        /// <param name="bonus">The bonus.</param>
        public ViewBonus(AbstractBonus bonus) : base(bonus)
        {
        }
    }
}
