using CasseBrique;
using Microsoft.Xna.Framework;
using Breakout.Bonus;

namespace Breakout.Model
{
    public class Brick : Shape
    {//ceci est un commentaire
        public int Life { get; set; }

        public int XBrick { get; set; }

        public int YBrick { get; set; }

        public AbstractBonus Bonus { get; set; }

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

        public Rectangle GetBBox()
        {
            return new Rectangle((int)this.Position.X, (int)this.Position.Y, (int)this.Size.Width, (int)this.Size.Height);
        }

        public override void HandleTrajectory(BreakoutModel model, GameTime gameTime, int heightFrame, int widthFrame)
        {
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if(obj == this){
                return true;
            }

            if (obj is Brick)
            {
                Brick other = (Brick)obj;
                return other.XBrick == this.XBrick && other.YBrick == this.YBrick;
            }
            else
            {
                return false;
            }
        }
    }
}
