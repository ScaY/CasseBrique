using Breakout.Model;
using Microsoft.Xna.Framework;
using System.Media;

namespace Breakout.Bonus
{
    /// <summary>
    /// This class represents a bonus that adds a temporary ball to the game.
    /// </summary>
    public class AddBallBonus : BallBonus
    {
        /// <summary>
        /// The ball added by the bonus.
        /// </summary>
        private Ball ball;

        /// <summary>
        /// Applies the bonus (adds the ball).
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="player">The player.</param>
        public override void ApplyBonus(Model.BreakoutModel model, Player player)
        {
            Bar bar = player.Bar;
            this.ball = new Ball();
            ball.Size.Width = 16;
            ball.Size.Height = 16;
            ball.Position = new Vector2(bar.Position.X + (float)(bar.Size.Width / 2) - (float)(ball.Size.Height / 2), bar.Position.Y - ball.Size.Width);
            ball.Speed = 0.3f;
            ball.Deplacement = Vector2.Normalize(new Vector2(-1));
            model.AddBall(ball);
        }

        /// <summary>
        /// Removes the bonus (removes the ball).
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="player">The player.</param>
        public override void RemoveBonus(BreakoutModel model, Player player)
        {
            model.RemoveBall(ball);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddBallBonus"/> class.
        /// </summary>
        public AddBallBonus():base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddBallBonus"/> class.
        /// </summary>
        /// <param name="modifier">The modifier.</param>
        /// <param name="duration">The duration.</param>
        public AddBallBonus(float modifier, int duration) : base(modifier, duration)
        {
        }
    }
}
