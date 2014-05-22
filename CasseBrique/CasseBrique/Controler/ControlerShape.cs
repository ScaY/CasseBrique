using Breakout.Model;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Controler
{
    public class ControlerShape
    {
        public Shape Shape { get; set; }

        public ControlerShape(Shape shape)
        {
            this.Shape = shape;
        }

        public void HandleTrajectory(BreakoutModel model, GameTime gameTime, int heightFrame, int widthFrame)
        {
            Shape.HandleTrajectory(model, gameTime, heightFrame, widthFrame);
        }
    }
}
