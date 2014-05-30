using Breakout.Bonus;
using Breakout.Model;
using Microsoft.Xna.Framework;
using System;

namespace Breakout.Controler
{
    public class ControlerBonus : AbstractControler
    {
        public ControlerBonus(BreakoutModel model) : base(model)
        {
        }

        public void HandleBonus(GameTime gameTime, int heightFrame, int widthFrame, AbstractBonus bonus, TimeSpan totalGameTime) {
            bonus.HandleTrajectory(Model, gameTime, heightFrame, widthFrame);

            if (bonus.Position.Y > heightFrame)
            {
                Model.RemoveBonus(bonus);
            }
            else
            {
                foreach (Player player in Model.Players)
                {
                    Bar bar = player.Bar;

                    if (bar.getRectangle().Contains((int)(bonus.Position.X), (int)(bonus.Position.Y + bonus.Size.Height)) || bar.getRectangle().Contains((int)(bonus.Position.X + bonus.Size.Width), (int)(bonus.Position.Y + bonus.Size.Height)))
                    {
                        player.Bonuses.Add(bonus);
                        bonus.ApplyBonus(Model, player);
                        Console.WriteLine(bonus.ToString());
                        bonus.StartTime = totalGameTime;
                        Model.RemoveBonus(bonus);
                    }
                }
            }
        }
    }
}
