using Breakout.Model;
using Microsoft.Xna.Framework;
using System;

namespace Breakout.Bonus
{
    public abstract class AbstractBonus : Shape
    {
        public float Modifier { get; set; }

        public TimeSpan StartTime { get; set; }

        public int Duration { get; set; }

        public AbstractBonus(): base()
        {

        }


        public override void HandleTrajectory(BreakoutModel model, GameTime gameTime, int heightFrame, int widthFrame)
        {
            float x = this.Position.X + this.Deplacement.X * this.Speed;
            float y = this.Position.Y + this.Deplacement.Y * this.Speed;

            this.Position = new Vector2(x, y);
        }

        public virtual void ApplyBonus(BreakoutModel model, Player player)
        {

        }
        public virtual void RemoveBonus(BreakoutModel model, Player player)
        {

        }

        public AbstractBonus(float modifier, int duration)
        {
            this.Modifier = modifier;
            this.Duration = duration;
        }
    }
}
