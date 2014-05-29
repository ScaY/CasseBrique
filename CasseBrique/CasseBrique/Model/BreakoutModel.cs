using System.Collections.Generic;
using Breakout.Bonus;
using Breakout.Events;

namespace Breakout.Model
{
    public class BreakoutModel : GameModel
    {
        public BrickZone BrickZone { get; set; }

        public List<Ball> Balls { get; set; }

        public List<AbstractBonus> Bonuses { get; set; }

        public Level Level { get; set; }

        public bool GameLauch { get; set; }

        public BreakoutModel(Level level)
        {
            this.BrickZone = level.Map;
            this.Balls = new List<Ball>();
            this.Bonuses = new List<AbstractBonus>();
            this.Level = level;
            this.GameLauch = false;
        }

        public BreakoutModel(int nbBrickCol, int nbBrickRow, float startBlockBrickX, float startBlockBrickY)
        {
            this.BrickZone = new BrickZone(nbBrickCol, nbBrickRow, startBlockBrickX, startBlockBrickY);
            this.Balls = new List<Ball>();
            this.Bonuses = new List<AbstractBonus>();
            this.Level = null;
            this.GameLauch = false;
        }

        public void AddBrick(Brick brick, int x, int y)
        {
            BrickZone.AddBrick(brick, x, y);
            this.RefreshViews(new AddedBrickEvent(this, brick));
        }

        public void RemoveBrick(Brick brick)
        {
           BrickZone.RemoveBrick(brick);
           this.RefreshViews(new RemovedBrickEvent(this, brick));
        }

        public void UpdateBrickLife(Brick brick, int life)
        {
            brick.Life = life;
            if (brick.Life < 0)
            {
                RemoveBrick(brick);
            }
            this.RefreshViews(new BrickLifeUpdatedEvent(this, brick, life));
        }

        public void AddBonus(AbstractBonus bonus)
        {
            this.Bonuses.Add(bonus);
            this.RefreshViews(new AddedBonusEvent(this, bonus));
        }

        public void RemoveBonus(AbstractBonus bonus)
        {
            this.Bonuses.Remove(bonus);
            this.RefreshViews(new RemovedBonusEvent(this, bonus));
        }

        public void AddBall(Ball ball)
        {
            this.Balls.Add(ball);
            this.RefreshViews(new AddedBallEvent(this, ball));
        }

        public void RemoveBall(Ball ball)
        {
            this.Balls.Remove(ball);
            this.RefreshViews(new RemovedBallEvent(this, ball));
        }

        public bool IsGameWon()
        {
            return false;
        }

        public bool IsGameLost()
        {
            return this.Balls.Count == 0;
        }
    }
}
