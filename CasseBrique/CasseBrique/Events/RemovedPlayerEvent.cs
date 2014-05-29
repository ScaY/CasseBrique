using Breakout.Model;

namespace Breakout.Events
{
    public class RemovedPlayerEvent : PlayerEvent
    {
        public RemovedPlayerEvent()
        {
        }

        public RemovedPlayerEvent(AbstractModel model, Player player) : base(model, player)
        {
        }
    }
}
