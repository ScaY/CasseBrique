using Breakout.Model;
using Microsoft.Xna.Framework;
using System;

namespace Breakout.Bonus
{
    /// <summary>
    /// This class contains properties shared by all the bonus.
    /// </summary>
    public abstract class AbstractBonus : Shape
    {
        /// <summary>
        /// Gets or sets the modifier (used by a bonus to modify a property of the game).
        /// </summary>
        /// <value>
        /// The modifier.
        /// </value>
        public float Modifier { get; set; }

        /// <summary>
        /// Gets or sets the start time (time when the bonus was picked up).
        /// </summary>
        /// <value>
        /// The start time.
        /// </value>
        public TimeSpan StartTime { get; set; }

        /// <summary>
        /// Gets or sets the duration (time in seconds during which the bonus is active).
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        public int Duration { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractBonus"/> class.
        /// </summary>
        public AbstractBonus(): base()
        {

        }


        /// <summary>
        /// Handles the trajectory (moves the bonus to the bottom of the game).
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="gameTime">The game time.</param>
        /// <param name="heightFrame">The height of the frame.</param>
        /// <param name="widthFrame">The width of the frame.</param>
        public override void HandleTrajectory(BreakoutModel model, GameTime gameTime, int heightFrame, int widthFrame)
        {
            float x = this.Position.X + this.Deplacement.X * this.Speed;
            float y = this.Position.Y + this.Deplacement.Y * this.Speed;

            this.Position = new Vector2(x, y);
        }

        /// <summary>
        /// Applies the bonus.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="player">The player.</param>
        public virtual void ApplyBonus(BreakoutModel model, Player player)
        {

        }
        /// <summary>
        /// Removes the bonus.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="player">The player.</param>
        public virtual void RemoveBonus(BreakoutModel model, Player player)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractBonus"/> class.
        /// </summary>
        /// <param name="modifier">The modifier.</param>
        /// <param name="duration">The duration.</param>
        public AbstractBonus(float modifier, int duration)
        {
            this.Modifier = modifier;
            this.Duration = duration;
        }
    }
}
