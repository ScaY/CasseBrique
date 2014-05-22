using CasseBrique;
using Microsoft.Xna.Framework;
using Breakout.Bonus;

namespace Breakout.Model
{
    public class Brick : Shape
    {
        public int Life { get; set; }

        public int XBrick { get; set; }

        public int YBrick { get; set; }

        public AbstractBonus bonus { get; set; }

        public Brick() 
        {
            this.XBrick = 0;
            this.YBrick = 0;
            this.Life = 0;

        }

        public Brick(Vector2 position, int life, Size size) : base(position, Vector2.Zero, 0f, size)
        {
            this.XBrick = 0;
            this.YBrick = 0;
            this.Life = life;
        }

        public override void HandleTrajectory(BreakoutModel model, GameTime gameTime, int heightFrame, int widthFrame)
        {
        }
    }
}
