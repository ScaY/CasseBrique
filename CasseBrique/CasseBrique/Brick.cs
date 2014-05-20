using Microsoft.Xna.Framework;

namespace CasseBrique
{
    public class Brick : Shape
    {
        private bool isBroken;

        public bool IsBroken
        {
            get { return isBroken; }
            set { isBroken = value; }
        }

        private int lifeRemaining;

        public int LifeRemaining
        {
            get { return lifeRemaining; }
            set { lifeRemaining = value; }
        }
        
        public Brick() : this(Vector2.Zero, 1)
        {
        }

        public Brick(Vector2 position, int life) : base(position, Vector2.Zero, 0f)
        {
            this.IsBroken = false;
            this.LifeRemaining = life;
        }

        public void DecreaseLifeBrick()
        {
            if (this.LifeRemaining == 0)
            {
                this.IsBroken = true;
            }
            else
            {
                this.LifeRemaining--;
            }
        }
    }
}
