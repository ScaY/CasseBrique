using Breakout.Model;

namespace Breakout.Events
{
    public class RemovedBallEvent : BallEvent
    {
        public RemovedBallEvent()
        {
        }

        public RemovedBallEvent(AbstractModel model, Ball ball) : base(model, ball)
        {
        }
    }
}
