using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CasseBrique
{
    public class ViewBar : View
    {
        public override void Draw(Modele modele, SpriteBatch spriteBatch, GameTime gameTime)
        {
            if (modele is Bar)
            {
                Bar bar = (Bar)modele;
                spriteBatch.Draw(this.Texture, bar.Position, Color.White);
            }
        }
    }
}
