using Breakout.Bonus;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Views
{
    public class ViewBonus : ShapeView
    {
        public ViewBonus(AbstractBonus bonus, Texture2D texture) : base(bonus, texture)
        {
        }
    }
}
