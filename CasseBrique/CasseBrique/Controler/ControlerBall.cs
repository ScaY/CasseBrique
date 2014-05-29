using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
