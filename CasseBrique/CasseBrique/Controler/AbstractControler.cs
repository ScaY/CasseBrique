using Breakout.Model;

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
