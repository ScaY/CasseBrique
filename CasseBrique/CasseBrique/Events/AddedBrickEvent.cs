using Breakout.Model;

namespace Breakout.Events
{
    public class AddedBrickEvent : BrickEvent
    {
        public AddedBrickEvent()
        {
        }

        public AddedBrickEvent(AbstractModel model, Brick brick) : base(model, brick)
        {
        }
    }
}
