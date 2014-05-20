using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CassseBrique
{
    public interface View
    {
        public void Draw(Modele modele, SpriteBatch spriteBatch, GameTime gameTime);
    }
}
