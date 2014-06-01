using Breakout.Model;

namespace Breakout.Events
{
    /// <summary>
    /// This is a class that represents an event of the player.
    /// </summary>
    public abstract class PlayerEvent : Event
    {
        /// <summary>
        /// Gets or sets the player.
        /// </summary>
        /// <value>
        /// The player.
        /// </value>
        public Player Player { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerEvent"/> class.
        /// </summary>
        public PlayerEvent() : this(null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerEvent"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="player">The player.</param>
        public PlayerEvent(AbstractModel model, Player player) : base(model)
        {
            this.Player = player;
        }
    }
}
