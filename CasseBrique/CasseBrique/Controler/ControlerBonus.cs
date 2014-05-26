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
    public class ControlerBonus : ControlerShape
    {
        public bool Enabled { get; set; }

        public ControlerBonus(AbstractBonus bonus) : base(bonus)
        {
            Enabled = true;
        }

        public void HandleBonus(BreakoutModel model, GameTime gameTime, int heightFrame, int widthFrame, List<ViewBonus> views) {
            if (Enabled)
            {
                HandleTrajectory(model, gameTime, heightFrame, widthFrame);

                Bar bar = model.Bar;

                if (Shape.Position.Y > heightFrame)
                {
                    RemoveBonus(model, views);
                }
                else if (bar.getRectangle().Contains((int)(Shape.Position.X), (int)(Shape.Position.Y + Shape.Size.Height)) || bar.getRectangle().Contains((int)(Shape.Position.X + Shape.Size.Width), (int)(Shape.Position.Y + Shape.Size.Height)))
                {
                    if(model.CurrentPlayer != null) {
                        model.CurrentPlayer.Bonuses.Add((AbstractBonus)Shape);
                    }

                    ((AbstractBonus)Shape).ApplyBonus(model);
                    RemoveBonus(model, views);
                }
            }
        }

        private void RemoveBonus(BreakoutModel model, List<ViewBonus> views)
        {
            model.Bonuses.Remove((AbstractBonus)Shape);

            int i = 0;
            while(Enabled || i < views.Count)
            {
                ViewBonus view = views.ElementAt(i);
                if (view.Shape == Shape)
                {
                    views.Remove(view);
                    Enabled = false;
                }

                i++;
            }
        }
    }
}
