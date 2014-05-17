using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CasseBrique
{
    public abstract class Shape : Modele
    {
        private Texture2D texture;

        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        private Vector2 position;

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        private Vector2 deplacement;

        public Vector2 Deplacement
        {
            get { return deplacement; }
            set { deplacement = value; }
        }

        private float speed;

        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public void Initialize(Vector2 position, Vector2 deplacement)
        {
            this.Position = position;
            this.Deplacement = deplacement;
            this.speed = 0.75f;
        }

        public void LoadContent(ContentManager content, string ressource)
        {
            this.Texture = content.Load<Texture2D>(ressource);
        }
    }
}
