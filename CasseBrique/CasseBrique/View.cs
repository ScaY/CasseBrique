using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace CasseBrique
{
    public abstract class View
    {
        private Texture2D texture;

        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        public void LoadContent(ContentManager content, string ressource)
        {
            try
            {
                this.Texture = content.Load<Texture2D>(ressource);
            }
            catch (Exception e)
            {
                Console.WriteLine("Expcetion in Shape: " + e.Message);
            }
        }

        public abstract void Draw(Modele modele, SpriteBatch spriteBatch, GameTime gameTime);
    }
}
