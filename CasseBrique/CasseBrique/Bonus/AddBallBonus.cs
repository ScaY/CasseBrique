using Breakout.Model;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Bonus
{
    public class AddBallBonus : BallBonus
    {
        private Ball ball;


        public override void ApplyBonus(Model.BreakoutModel model, Player player)
        {
            Bar bar = player.Bar;
            this.ball = new Ball();
            ball.Size.Width = 16;
            ball.Size.Height = 16;
            ball.Position = new Vector2(bar.Position.X + (float)(bar.Size.Width / 2) - (float)(ball.Size.Height / 2), bar.Position.Y - ball.Size.Width);
            ball.Speed = 0.3f;
            ball.Deplacement = Vector2.Normalize(new Vector2(-1));
            model.AddBall(ball);
        }

        public override void RemoveBonus(BreakoutModel model, Player player)
        {
            model.RemoveBall(ball);
        }
        public AddBallBonus()
        {
        }
        public AddBallBonus(float modifier, int duration) : base(modifier, duration)
        {
        }
    }
}
