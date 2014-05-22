using Breakout.Model;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Bonus
{
    public abstract class AbstractBonus : Shape
    {
        public int Modifier { get; set; }

        public override void HandleTrajectory(BreakoutModel model, GameTime gameTime, int heightFrame, int widthFrame)
        {
            float x = this.Position.X + this.Deplacement.X * this.Speed;
            float y = this.Position.Y + this.Deplacement.Y * this.Speed;

            this.Position = new Vector2(x, y);

        }
    }
}
