using Breakout.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
