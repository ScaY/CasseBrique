using Breakout.Model;

namespace Breakout.Events
{
    public class BrickLifeUpdatedEvent : BrickEvent
    {
        public int Life { get; set; }

        public BrickLifeUpdatedEvent()
        {
            this.Life = 0;
        }

        public BrickLifeUpdatedEvent(AbstractModel model, Brick brick, int life) : base(model, brick)
        {
            this.Life = life;
        }
    }
}
