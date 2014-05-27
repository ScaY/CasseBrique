using Breakout.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Controler
{
    public abstract class AbstractControler
    {
        public BreakoutModel Model { get; set; }

        public AbstractControler()
        {
            this.Model = null;
        }

        public AbstractControler(BreakoutModel model)
        {
            this.Model = model;
        }
    }
}
