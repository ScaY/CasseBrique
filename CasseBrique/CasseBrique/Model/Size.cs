using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Model
{
    public class Size
    {
        public int Width { get; set; }

        public int Height { get; set; }


        public Size()
        {
            this.Width = 0;
            this.Height = 0;
        }

        public Size(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
