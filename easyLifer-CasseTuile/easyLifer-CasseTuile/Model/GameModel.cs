using Breakout.Events;
using CasseBrique.Events;
using System.Collections.Generic;

namespace Breakout.Model
{
    /// <summary>
    /// This is a class that represents a game model, containing players and other attributes.
    /// </summary>
    public class GameModel : AbstractModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether the game is paused.
        /// </summary>
        /// <value>
        ///   <c>true</c> if pause; otherwise, <c>false</c>.
        /// </value>
        public bool Pause { get; set; }

        /// <summary>
        /// Gets or sets the players.
        /// </summary>
        /// <value>
        /// The players.
        /// </value>
        public List<Player> Players { get; set; }

        /// <summary>
        /// Adds the player.
        /// </summary>
        /// <param name="player">The player.</param>
        public void AddPlayer(Player player)
        {
            this.Players.Add(player);
            this.RefreshViews(new AddedPlayerEvent(this, player));
        }

        /// <summary>
        /// Removes the player.
        /// </summary>
        /// <param name="player">The player.</param>
        public void RemovePlayer(Player player)
        {
            this.Players.Remove(player);
            this.RefreshViews(new RemovedPlayerEvent(this, player));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameModel"/> class.
        /// </summary>
        public GameModel()
        {
            this.Pause = false;
            this.Players = new List<Player>();
        }

        /// <summary>
        /// Sets the pause.
        /// </summary>
        /// <param name="pause">if set to <c>true</c> the game is paused.</param>
        public void SetPause(bool pause)
        {
            this.Pause = pause;
            this.RefreshViews(new GamePause(this));
        }
    }
}
