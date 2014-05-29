using Breakout.Model;

namespace Breakout.Events
{
    public abstract class BallEvent : Event
    {
        public Ball Ball { get; set; }

        public BallEvent() : this(null, null)
        {
        }

        public BallEvent(AbstractModel model, Ball ball) : base(model)
        {
            this.Ball = ball;
        }
    }
}
