using Breakout.Model;

namespace Breakout.Events
{
    /// <summary>
    /// This is a class that represents an event when a player is removed.
    /// </summary>
    public class RemovedPlayerEvent : PlayerEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemovedPlayerEvent"/> class.
        /// </summary>
        public RemovedPlayerEvent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemovedPlayerEvent"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="player">The player.</param>
        public RemovedPlayerEvent(AbstractModel model, Player player) : base(model, player)
        {
        }
    }
}
