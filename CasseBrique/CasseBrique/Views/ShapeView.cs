using Breakout.Events;
using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Breakout.Views
{
    public abstract class ShapeView : View
    {
        public Shape Shape { get; set; }

        private Texture2D texture;

        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        public ShapeView(Shape shape)
        {
            this.Shape = shape;
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            float scale = (float)Shape.Size.Width / texture.Width;
            spriteBatch.Draw(this.Texture, Shape.Position, null, Color.White, 0, Vector2.Zero, scale, SpriteEffects.None, 1);   
        }

        public void Refresh(Event e)
        {

        }
    }
}
