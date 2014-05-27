using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Breakout.Model;

namespace Breakout.Events
{
    public class AddedPlayerEvent : PlayerEvent
    {
        public AddedPlayerEvent()
        {
        }

        public AddedPlayerEvent(AbstractModel model, Player player) : base(model, player)
        {
        }
    }
}
