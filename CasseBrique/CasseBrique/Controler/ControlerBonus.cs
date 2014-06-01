using Breakout.Bonus;
using Breakout.Model;
using Microsoft.Xna.Framework;
using System;

namespace Breakout.Controler
{
    /// <summary>
    /// This is a class that represents a controler of the bonus.
    /// </summary>
    public class ControlerBonus : AbstractControler
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlerBonus"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        public ControlerBonus(BreakoutModel model) : base(model)
        {
        }

        /// <summary>
        /// Handles the display and the trajectory of the bonus.
        /// </summary>
        /// <param name="gameTime">The game time.</param>
        /// <param name="heightFrame">The height frame.</param>
        /// <param name="widthFrame">The width frame.</param>
        /// <param name="bonus">The bonus.</param>
        /// <param name="totalGameTime">The total game time.</param>
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
                        bonus.StartTime = totalGameTime;
                        Model.RemoveBonus(bonus);
                    }
                }
            }
        }
    }
}
