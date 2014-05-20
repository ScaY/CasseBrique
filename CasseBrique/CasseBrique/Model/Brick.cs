using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Model
{
    public class Brick
    {
        public Position Position { get; set; }

        public Size Size { get; set; }

        public int Life { get; set; }

        Brick()
        {
            this.Position = new Position();
            this.Size = new Size();
            this.Life = 0;
        }

        Brick(Position position, Size size, int life)
        {
            this.Position = position;
            this.Size = size;
            this.Life = life;
        }

        Brick(int x, int y, int width, int height, int life)
        {
            this.Position = new Position(x, y);
            this.Size = new Size(width, height);
            this.Life = life;
        }
    }
}
