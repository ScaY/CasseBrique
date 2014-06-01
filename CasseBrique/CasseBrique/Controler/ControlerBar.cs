using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Breakout.Controler
{
    /// <summary>
    /// This is a class that represents an abstract controler of the bar.
    /// </summary>
    public abstract class ControlerBar : AbstractControler
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlerBar"/> class.
        /// </summary>
        public ControlerBar()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlerBar"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        public ControlerBar(BreakoutModel model) : base(model)
        {

        }

        /// <summary>
        /// Handles the different actions of the player, and changes the position of the bar.
        /// </summary>
        /// <param name="keyBoardState">State of the key board.</param>
        /// <param name="mouseSate">The mouse sate.</param>
        /// <param name="gameTime">The game time.</param>
        /// <param name="widthFrame">The width frame.</param>
        /// <param name="player">The player.</param>
        public abstract void HandleInput(KeyboardState keyBoardState, MouseState mouseSate, GameTime gameTime, int widthFrame, Player player);
    }
}
