using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Breakout.Controler
{
    /// <summary>
    /// This is a class that represents a controler of the bar, that operates with the keyboard.
    /// </summary>
    public class ControlerBarKeyboard : ControlerBar
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlerBarKeyboard"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        public ControlerBarKeyboard(BreakoutModel model)
            : base(model)
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
        public override void HandleInput(KeyboardState keyBoardState, MouseState mouseSate, GameTime gameTime, int widthFrame, Player player)
        {
            Bar Bar = player.Bar;

            if (keyBoardState.IsKeyDown(player.MoveRightKey) && (Bar.Position.X + Bar.Size.Width < widthFrame))
            {
                Bar.Deplacement = Vector2.Normalize(new Vector2(1, 0));
                Bar.Position += Bar.Deplacement * Bar.Speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }
            else if (keyBoardState.IsKeyDown(player.MoveLeftKey) && Bar.Position.X > 0)
            {
                Bar.Deplacement = Vector2.Normalize(new Vector2(-1, 0));
                Bar.Position += Bar.Deplacement * Bar.Speed * (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }

            if (!Model.GameLauch)
            {
                Bar.StartBall.Position = new Vector2(Bar.Position.X + Bar.Size.Width / 2 - Bar.StartBall.Size.Width/2 , Bar.Position.Y - Bar.StartBall.Size.Height);
            }
        }
    }
}
