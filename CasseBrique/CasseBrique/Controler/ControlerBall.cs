using Breakout.Model;
using Microsoft.Xna.Framework;

namespace Breakout.Controler
{
    public class ControlerBall : AbstractControler
    {
        public bool gameLaunch { get; set; }

        public ControlerBall()
        {
            gameLaunch = false;
        }

        public ControlerBall(BreakoutModel model)
            : base(model)
        {
        }

        public void HandleBall()
        {

        }

        public void HandleBall(Ball ball, GameTime gameTime, int heightFrame, int widthFrame)
        {
            if (Model.GameLauch)
            {
                ball.HandleTrajectory(Model, gameTime, heightFrame, widthFrame);
            }
        }
    }
}
