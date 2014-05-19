using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Breakout.Model;

namespace Breakout.Events
{
    public class Event
    {
        private AbstractModel model;
        public AbstractModel Model { get; set; }

        public Event() : this(null)
        {
        }

        public Event(AbstractModel model)
        {
            this.model = model;
        }
    }
}
