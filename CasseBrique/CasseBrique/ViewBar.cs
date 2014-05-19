using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CasseBrique
{
    public class ViewBar : View
    {
       public override void View.Draw(AbstractModel modele, SpriteBatch spriteBatch, GameTime gameTime)
        {
            if (modele is Bar)
            {
                Bar bar = (Bar)modele;
                spriteBatch.Draw(bar.Texture, bar.Position, Color.White);
            }
        }

       public override void Refresh(Event e)
       {

       }
    }
}
