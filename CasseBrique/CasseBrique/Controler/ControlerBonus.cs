using Breakout.Bonus;
using Breakout.Model;
using Breakout.Views;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Controler
{
    public class ControlerBonus
    {
        public ControlerBonus()
        {
        }

        public void HandleBonus(BreakoutModel model, GameTime gameTime, int heightFrame, int widthFrame, AbstractBonus bonus) {
            bonus.HandleTrajectory(model, gameTime, heightFrame, widthFrame);

            Bar bar = model.CurrentPlayer.Bar;

            if (bonus.Position.Y > heightFrame)
            {
                model.RemoveBonus(bonus);
            }
            else if (bar.getRectangle().Contains((int)(bonus.Position.X), (int)(bonus.Position.Y + bonus.Size.Height)) || bar.getRectangle().Contains((int)(bonus.Position.X + bonus.Size.Width), (int)(bonus.Position.Y + bonus.Size.Height)))
            {
                if(model.CurrentPlayer != null) {
                    model.CurrentPlayer.Bonuses.Add(bonus);
                }

                bonus.ApplyBonus(model);
                model.RemoveBonus(bonus);
            }
        }
    }
}
