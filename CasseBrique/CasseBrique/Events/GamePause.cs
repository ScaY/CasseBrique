using Breakout.Events;
using Breakout.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CasseBrique.Events
{
    public class GamePause : Event
    {
        public GamePause(AbstractModel model) : base(model)
        {

        }
    }
}
