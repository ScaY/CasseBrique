
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CasseBrique
{
    public class Bricks : Modele
    {

        private Brick[,] bricks;

        public Brick[,] AllBricks
        {
            get { return bricks; }
            set { bricks = value; }
        }


        private float startBlockBrickX;

        public float StartBlockBrickX
        {
            get { return startBlockBrickX; }
            set { startBlockBrickX = value; }
        }

        private float startBlockBrickY;

        public float StartBlockBrickY
        {
            get { return startBlockBrickY; }
            set { startBlockBrickY = value; }
        }

        private float endBlockBrickX;

        public float EndBlockBrickX
        {
            get { return endBlockBrickX; }
            set { endBlockBrickX = value; }
        }

        private float endBlockBrickY;

        public float EndBlockBrickY
        {
            get { return endBlockBrickY; }
            set { endBlockBrickY = value; }
        }

        private int nbBrickRow;

        public int NbBrickRow
        {
            get { return nbBrickRow; }
            set { nbBrickRow = value; }
        }

        private int nbBrickCol;

        public int NbBrickCol
        {
            get { return nbBrickCol; }
            set { nbBrickCol = value; }
        }

        private float heightBrick;

        public float HeightBrick
        {
            get { return heightBrick; }
            set { heightBrick = value; }
        }

        private float widthBrick;

        public float WidthBrick
        {
            get { return widthBrick; }
            set { widthBrick = value; }
        }


        public Bricks(int nbBrickCol, int nbBrickRow, float startBlockBrickX, float startBlockBrickY)
        {
            this.AllBricks = new Brick[nbBrickRow, nbBrickCol];
            this.NbBrickCol = nbBrickCol;
            this.NbBrickRow = nbBrickRow;

            for (int i = 0; i < nbBrickRow; i++)
            {
                for (int j = 0; j < nbBrickCol; j++)
                {
                    AllBricks[i, j] = new Brick();
                }
            }

            this.StartBlockBrickX = startBlockBrickX;
            this.StartBlockBrickY = startBlockBrickY;
        }

        public void InitializeViewBrick()
        {
            for (int i = 0; i < this.NbBrickRow; i++)
            {
                for (int j = 0; j < this.NbBrickCol; j++)
                {
                    AllBricks[i, j].addView(new BrickView());
                }
            }
        }

        public void InitializeTextureBrick(ContentManager content)
        {
            if (this.AllBricks.Length != 0)
            {
                Texture2D texture = content.Load<Texture2D>("brick3life");

                this.HeightBrick = texture.Height;
                this.WidthBrick = texture.Width;

                for (int i = 0; i < this.NbBrickRow; i++)
                {
                    for (int j = 0; j < this.NbBrickCol; j++)
                    {
                        AllBricks[i, j].Views[0].Texture = texture;
                    }
                }


                this.EndBlockBrickX = startBlockBrickX + NbBrickCol * WidthBrick;
                this.EndBlockBrickY = startBlockBrickY + NbBrickRow * HeightBrick;

            }
        }

        public void InitializePositionBrick()
        {
            for (int i = 0; i < this.NbBrickRow; i++)
            {
                for (int j = 0; j < this.NbBrickCol; j++)
                {
                    AllBricks[i, j].Position = new Vector2((i + 1) * StartBlockBrickX, (j + 1) * StartBlockBrickY);
                }
            }
        }
    }
}
