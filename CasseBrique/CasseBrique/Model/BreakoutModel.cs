using System.Collections.Generic;
using Breakout.Bonus;
using Breakout.Events;

namespace Breakout.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BreakoutModel : GameModel
    {
        /// <summary>
        /// Gets or sets the brick zone.
        /// </summary>
        /// <value>
        /// The brick zone.
        /// </value>
        public BrickZone BrickZone { get; set; }

        /// <summary>
        /// Gets or sets the balls.
        /// </summary>
        /// <value>
        /// The balls.
        /// </value>
        public List<Ball> Balls { get; set; }

        /// <summary>
        /// Gets or sets the bonuses.
        /// </summary>
        /// <value>
        /// The bonuses.
        /// </value>
        public List<AbstractBonus> Bonuses { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        public Level Level { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the game is launched.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the game is launched; otherwise, <c>false</c>.
        /// </value>
        public bool GameLauch { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BreakoutModel"/> class.
        /// </summary>
        /// <param name="level">The level.</param>
        public BreakoutModel(Level level)
        {
            this.BrickZone = level.Map;
            this.Balls = new List<Ball>();
            this.Bonuses = new List<AbstractBonus>();
            this.Level = level;
            this.GameLauch = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BreakoutModel"/> class.
        /// </summary>
        /// <param name="nbBrickCol">The numberb of bricks per columns.</param>
        /// <param name="nbBrickRow">The number of bricks per rows.</param>
        /// <param name="startBlockBrickX">The start block brick x coordinate.</param>
        /// <param name="startBlockBrickY">The start block brick y coordinate.</param>
        public BreakoutModel(int nbBrickCol, int nbBrickRow, float startBlockBrickX, float startBlockBrickY)
        {
            this.BrickZone = new BrickZone(nbBrickCol, nbBrickRow, startBlockBrickX, startBlockBrickY);
            this.Balls = new List<Ball>();
            this.Bonuses = new List<AbstractBonus>();
            this.Level = null;
            this.GameLauch = false;
        }

        /// <summary>
        /// Adds the brick.
        /// </summary>
        /// <param name="brick">The brick.</param>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        public void AddBrick(Brick brick, int x, int y)
        {
            BrickZone.AddBrick(brick, x, y);
            this.RefreshViews(new AddedBrickEvent(this, brick));
        }

        /// <summary>
        /// Removes the brick.
        /// </summary>
        /// <param name="brick">The brick.</param>
        public void RemoveBrick(Brick brick)
        {
           BrickZone.RemoveBrick(brick);
           this.RefreshViews(new RemovedBrickEvent(this, brick));
        }

        /// <summary>
        /// Updates the brick life.
        /// </summary>
        /// <param name="brick">The brick.</param>
        /// <param name="life">The life.</param>
        public void UpdateBrickLife(Brick brick, int life)
        {
            brick.Life = life;
            if (brick.Life < 0)
            {
                RemoveBrick(brick);
            }
            this.RefreshViews(new BrickLifeUpdatedEvent(this, brick, life));
        }

        /// <summary>
        /// Adds the bonus.
        /// </summary>
        /// <param name="bonus">The bonus.</param>
        public void AddBonus(AbstractBonus bonus)
        {
            this.Bonuses.Add(bonus);
            this.RefreshViews(new AddedBonusEvent(this, bonus));
        }

        /// <summary>
        /// Removes the bonus.
        /// </summary>
        /// <param name="bonus">The bonus.</param>
        public void RemoveBonus(AbstractBonus bonus)
        {
            this.Bonuses.Remove(bonus);
            this.RefreshViews(new RemovedBonusEvent(this, bonus));
        }

        /// <summary>
        /// Adds the ball.
        /// </summary>
        /// <param name="ball">The ball.</param>
        public void AddBall(Ball ball)
        {
            this.Balls.Add(ball);
            this.RefreshViews(new AddedBallEvent(this, ball));
        }

        /// <summary>
        /// Removes the ball.
        /// </summary>
        /// <param name="ball">The ball.</param>
        public void RemoveBall(Ball ball)
        {
            this.Balls.Remove(ball);
            this.RefreshViews(new RemovedBallEvent(this, ball));
        }

        /// <summary>
        /// Determines whether the game is won.
        /// </summary>
        /// <returns><c>true</c> if the game is won; otherwise, <c>false</c>.</returns>
        public bool IsGameWon()
        {
            return this.BrickZone.GetNbBricks() == 0;
        }

        /// <summary>
        /// Determines whether the game is lost.
        /// </summary>
        /// <returns><c>true</c> if the game is lost; otherwise, <c>false</c>.</returns>
        public bool IsGameLost()
        {
            return this.Balls.Count == 0;
        }
    }
}
