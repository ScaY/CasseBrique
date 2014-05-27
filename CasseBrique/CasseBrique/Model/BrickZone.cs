
using Breakout.Bonus;
using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Breakout.Model
{
    public class BrickZone
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

        public BrickZone(int nbBrickCol, int nbBrickRow, float startBlockBrickX, float startBlockBrickY)
        {
            this.AllBricks = new Brick[nbBrickRow, nbBrickCol];
            this.NbBrickCol = nbBrickCol;
            this.NbBrickRow = nbBrickRow;

            for (int i = 0; i < nbBrickRow; i++)
            {
                for (int j = 0; j < nbBrickCol; j++)
                {
                    AddBrick(new Brick(), i, j);
                }
            }

            this.StartBlockBrickX = startBlockBrickX;
            this.StartBlockBrickY = startBlockBrickY;
        }

        public void InitializeSizeBrick(Size size)
        {
            if (this.AllBricks.Length != 0)
            {
                this.HeightBrick = size.Height;
                this.WidthBrick = size.Width;

                for (int i = 0; i < this.NbBrickRow; i++)
                {
                    for (int j = 0; j < this.NbBrickCol; j++)
                    {
                        AllBricks[i, j].Size = size;
                    }
                }

                this.EndBlockBrickX = startBlockBrickX + NbBrickCol * WidthBrick;
                this.EndBlockBrickY = startBlockBrickY + NbBrickRow * HeightBrick;
            }
        }

        public void AddBrick(Brick brick, int x, int y)
        {
            if (x >= 0 && y >= 0 && x < this.NbBrickCol && y < this.NbBrickRow)
            {
                AllBricks[x, y] = brick;
                brick.XBrick = x;
                brick.YBrick = y;
                brick.Bonus = new BarSizeBonus(50, 10);
                brick.Bonus.Speed = 1f;
                brick.Bonus.Position = brick.Position;
                brick.Bonus.Deplacement = Vector2.Normalize(Vector2.UnitY);
                brick.Bonus.Size = new Size(32, 32);
            }
        }

        public void RemoveBrick(Brick brick)
        {
            if (brick != null)
            {
                AllBricks[brick.XBrick, brick.YBrick] = null;
            }
        }

        public void InitializePositionBrick()
        {
            for (int i = 0; i < this.NbBrickRow; i++)
            {
                for (int j = 0; j < this.NbBrickCol; j++)
                {
                    AllBricks[i, j].Position = new Vector2(StartBlockBrickX + i * WidthBrick, StartBlockBrickY + j * HeightBrick);
                }
            }

        }

        public override string ToString()
        {
            return string.Format("{0} {1}      et y: {2} {3}",
                this.StartBlockBrickX, this.EndBlockBrickX,
                this.StartBlockBrickY, this.EndBlockBrickY);
        }
    }
}
