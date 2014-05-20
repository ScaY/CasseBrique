using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CasseBrique
{
    public class ViewBricks : View
    {

        public override void Draw(Modele modele, SpriteBatch spriteBatch, GameTime gameTime)
        {
            if (modele is Bricks)
            {
                Bricks bricks = (Bricks)modele;
                int i = 0, j=0;
                for (i = 0; i < bricks.NbBrickRow; i++)
                {
                    for (j = 0; j < bricks.NbBrickCol; j++)
                    {
                        spriteBatch.Draw(bricks.AllBricks[i, j].Views[0].Texture, bricks.AllBricks[i, j].Position, Color.White);
                    }
                }
            }
        }
    }
}
