using Microsoft.Xna.Framework;

namespace Breakout.Model
{
    public class Bar : Shape
    {
        public Ball StartBall { get; set; }

        public Bar() : base()
        {
        }

        public Rectangle getRectangle()
        {
            return new Rectangle((int)Position.X, (int)Position.Y, Size.Width, Size.Height);

        }

        public Vector2 GetCenter()
        {
            return new Vector2(this.Position.X + this.Size.Width / 2, this.Position.Y + this.Size.Height);
        }

        public override void HandleTrajectory(BreakoutModel model, GameTime gameTime, int heightFrame, int widthFrame)
        {
        }
    }
}
