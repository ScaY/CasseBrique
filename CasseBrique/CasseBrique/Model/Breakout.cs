using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Breakout.Events;

namespace Breakout.Model
{
    public class Breakout : Game
    {
        public List<Brick> Bricks { get; set; }

        public void AddBrick(Brick brick)
        {
            Bricks.Add(brick);
            RefreshViews(new AddedBrickEvent(this, brick));
        }

        public void RemoveBrick(Brick brick)
        {
            Bricks.Remove(brick);
            RefreshViews(new RemovedBrickEvent(this, brick));
        }

        public void UpdateBrickLife(Brick brick, int life)
        {
            brick.Life = life;
            RefreshViews(new BrickLifeUpdatedEvent(this, brick, life));
        }
    }
}
