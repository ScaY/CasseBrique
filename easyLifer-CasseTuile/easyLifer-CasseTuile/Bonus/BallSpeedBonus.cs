using Breakout.Model;

namespace Breakout.Bonus
{
    /// <summary>
    /// This class represens a bonus that increases the speed of the balls.
    /// </summary>
    public class BallSpeedBonus : BallBonus
    {
        /// <summary>
        /// Applies the bonus (increases the speed of the balls).
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="player">The player.</param>
        public override void ApplyBonus(Model.BreakoutModel model, Player player)
        {
            foreach(Ball ball in model.Balls) {
                ball.Speed *= Modifier;
            }
        }

        /// <summary>
        /// Removes the bonus (decreases the speed of the balls).
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="player">The player.</param>
        public override void RemoveBonus(BreakoutModel model, Player player)
        {
            foreach (Ball ball in model.Balls)
            {
                 ball.Speed /= Modifier;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BallSpeedBonus" /> class.
        /// </summary>
        /// <param name="modifier">The modifier.</param>
        /// <param name="duration">The duration.</param>
        public BallSpeedBonus(float modifier, int duration) : base(modifier, duration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BallSpeedBonus"/> class.
        /// </summary>
        public BallSpeedBonus() : base()
        {
        }
    }
}
