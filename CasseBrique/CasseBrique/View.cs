using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CasseBrique
{
    interface View
    {
        void Draw(Modele modele, SpriteBatch spriteBatch, GameTime gameTime);
    }
}
