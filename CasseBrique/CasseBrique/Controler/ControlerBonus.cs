using Breakout.Bonus;
using Breakout.Model;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Controler
{
    public class ControlerBonus : ControlerShape
    {
        public bool Enabled { get; set; }

        public ControlerBonus(AbstractBonus bonus) : base(bonus)
        {
            Enabled = true;
        }

        public override void HandleTrajectory(BreakoutModel model, GameTime gameTime, int heightFrame, int widthFrame)
        {
            if (Enabled)
            {
                base.HandleTrajectory(model, gameTime, heightFrame, widthFrame);

                if (Shape.Position.Y > heightFrame)
                {
                    model.Bonuses.Remove((AbstractBonus)Shape);
                    Enabled = false;
                }
            }
        }
    }
}
