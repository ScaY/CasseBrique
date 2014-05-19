using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Breakout.Events;

namespace Breakout.Views
{
    public interface View
    {
        public abstract void Refresh(Event);
    }
}
