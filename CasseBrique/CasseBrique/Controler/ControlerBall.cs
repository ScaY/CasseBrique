using Breakout.Model;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Controler
{
    public class ControlerBall : AbstractControler
    {
        public ControlerBall(BreakoutModel model) : base(model)
        {
        }

        public void HandleBall()
        {

        }

        public void HandleBall(Ball ball, GameTime gameTime, int heightFrame, int widthFrame) 
        {
            ball.HandleTrajectory(Model, gameTime, heightFrame, widthFrame);
        }
    }
}
