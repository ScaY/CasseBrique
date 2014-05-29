using Breakout.Model;

namespace Breakout.Events
{
    public class RemovedBrickEvent : BrickEvent
    {
        public RemovedBrickEvent()
        {
        }

        public RemovedBrickEvent(AbstractModel model, Brick brick) : base(model, brick)
        {
        }
    }
}
