using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CassseBrique
{
    public interface CasseBrique
    {
        public void Draw(AbstractModel modele, SpriteBatch spriteBatch, GameTime gameTime);
    }
}
