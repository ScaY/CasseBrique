using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Breakout.Model;

namespace Breakout.Events
{
    public class BrickEvent : Event
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
