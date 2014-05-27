using Breakout.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Controler
{
    public class AbstractControler
    {
        public BreakoutModel Model { get; set; }

        public AbstractControler() : this(null)
        {
        }

        public AbstractControler(BreakoutModel model)
        {
            this.Model = model;
        }
    }
}
