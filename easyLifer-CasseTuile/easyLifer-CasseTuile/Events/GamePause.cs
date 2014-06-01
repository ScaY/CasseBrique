using Breakout.Events;
using Breakout.Model;

namespace CasseBrique.Events
{
    /// <summary>
    /// This is a class that represents an event of the game.
    /// </summary>
    public class GamePause : Event
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GamePause"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        public GamePause(AbstractModel model) : base(model)
        {

        }
    }
}
