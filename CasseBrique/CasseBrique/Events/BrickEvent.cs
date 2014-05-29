using Breakout.Model;

namespace Breakout.Events
{
    public abstract class BrickEvent : Event
    {
        public Brick Brick { get; set; }

        public BrickEvent() : this(null, null)
        {
        }

        public BrickEvent(AbstractModel model, Brick brick) : base(model)
        {
            this.Brick = brick;
        }
    }
}
