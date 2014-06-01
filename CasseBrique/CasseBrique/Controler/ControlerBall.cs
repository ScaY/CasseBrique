using Breakout.Model;
using Microsoft.Xna.Framework;


namespace Breakout.Controler
{
    /// <summary>
    /// This is a class that represents a controler of the ball.
    /// </summary>
    public class ControlerBall : AbstractControler
    {
        /// <summary>
        /// Gets or sets the bool that indicates if the game is launched
        /// </summary>
        /// <value>
        ///   <c>true</c> if the game is launched; otherwise, <c>false</c>.
        /// </value>
        public bool gameLaunch { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlerBall"/> class.
        /// </summary>
        public ControlerBall()
        {
            gameLaunch = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlerBall"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        public ControlerBall(BreakoutModel model)
            : base(model)
        {
        }

        /// <summary>
        /// Handles the trajectory of the ball.
        /// </summary>
        /// <param name="ball">The ball.</param>
        /// <param name="gameTime">The game time.</param>
        /// <param name="heightFrame">The height frame.</param>
        /// <param name="widthFrame">The width frame.</param>
        public void HandleBall(Ball ball, GameTime gameTime, int heightFrame, int widthFrame)
        {
            if (Model.GameLauch)
            {
                ball.HandleTrajectory(Model, gameTime, heightFrame, widthFrame);
            }
        }
    }
}
