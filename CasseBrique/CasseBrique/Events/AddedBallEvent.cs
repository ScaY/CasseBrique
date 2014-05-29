using Breakout.Model;

namespace Breakout.Events
{
    public class AddedBallEvent : BallEvent
    {
        public AddedBallEvent()
        {
        }

        public AddedBallEvent(AbstractModel model, Ball ball) : base(model, ball)
        {
        }
    }
}
