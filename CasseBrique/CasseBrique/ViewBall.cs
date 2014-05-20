using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CasseBrique
{
    public class ViewBall : View
    {
        public override void Draw(Modele modele, SpriteBatch spriteBatch, GameTime gameTime)
        {
            if (modele is Ball)
            {
                Ball ball = (Ball)modele;
                spriteBatch.Draw(this.Texture, ball.Position, Color.White);
            }
        }
    }

}
