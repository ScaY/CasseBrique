using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CasseBrique
{
    public class BrickView : View
    {
        public override void Draw(Modele modele, SpriteBatch spriteBatch, GameTime gameTime)
        {
            if (modele is Brick)
            {
                Brick brick = (Brick)modele;
                spriteBatch.Draw(this.Texture, brick.Position, Color.White);
            }
        }
    }
}
