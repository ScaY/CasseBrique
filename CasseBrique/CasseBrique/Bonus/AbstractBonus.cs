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
        public float Modifier { get; set; }

        public TimeSpan StartTime { get; set; }

        public int Duration { get; set; }

        public override void HandleTrajectory(BreakoutModel model, GameTime gameTime, int heightFrame, int widthFrame)
        {
            float x = this.Position.X + this.Deplacement.X * this.Speed;
            float y = this.Position.Y + this.Deplacement.Y * this.Speed;

            this.Position = new Vector2(x, y);
        }

        public abstract void ApplyBonus(BreakoutModel model, Player player);
        public abstract void RemoveBonus(BreakoutModel model, Player player);

        public AbstractBonus(float modifier, int duration)
        {
            this.Modifier = modifier;
            this.Duration = duration;
        }
    }
}
