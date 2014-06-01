using Breakout.Model;

namespace Breakout.Events
{
    /// <summary>
    /// This is a class that represents an event where a player is added.
    /// </summary>
    public class AddedPlayerEvent : PlayerEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddedPlayerEvent"/> class.
        /// </summary>
        public AddedPlayerEvent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddedPlayerEvent"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="player">The player.</param>
        public AddedPlayerEvent(AbstractModel model, Player player) : base(model, player)
        {
        }
    }
}
