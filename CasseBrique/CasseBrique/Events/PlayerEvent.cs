using Breakout.Model;

namespace Breakout.Events
{
    public abstract class PlayerEvent : Event
    {
        public Player Player { get; set; }

        public PlayerEvent() : this(null, null)
        {
        }

        public PlayerEvent(AbstractModel model, Player player) : base(model)
        {
            this.Player = player;
        }
    }
}
