using Breakout.Model;

namespace Breakout.Events
{
    public abstract class Event
    {
        public AbstractModel Model { get; set; }

        public Event() : this(null)
        {
        }

        public Event(AbstractModel model)
        {
            this.Model = model;
        }
    }
}
