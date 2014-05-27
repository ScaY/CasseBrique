using Breakout.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
