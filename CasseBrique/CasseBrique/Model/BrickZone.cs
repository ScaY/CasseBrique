
using Breakout.Bonus;
using Microsoft.Xna.Framework;
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
        public BrickZone()
        {
            
        }
        public BrickZone(int nbBrickCol, int nbBrickRow, float startBlockBrickX, float startBlockBrickY)
        {
            this.AllBricks = new Brick[nbBrickRow, nbBrickCol];
            this.NbBrickCol = nbBrickCol;
            this.NbBrickRow = nbBrickRow;

            for (int y = 0; y < nbBrickRow; y++)
            {
                for (int x = 0; x < nbBrickCol; x++)
                {
                    AddBrick(new Brick(), x, y);
                }
            }

            this.StartBlockBrickX = 0;
            this.StartBlockBrickY = startBlockBrickY;
            //this.StartBlockBrickX = 0;
            //this.StartBlockBrickY = 0;

        }
        public BrickZone(int nbBrickCol, int nbBrickRow, float startBlockBrickX, float startBlockBrickY,Brick[,] bricks)
        {
            this.AllBricks = bricks;
            this.NbBrickCol = nbBrickCol;
            this.NbBrickRow = nbBrickRow;


           this.StartBlockBrickX = 0;
            this.StartBlockBrickY = startBlockBrickY;
            //this.StartBlockBrickX = 0;
            //this.StartBlockBrickY = 0;
        }

        public void InitializeSizeBrick(Size size)
        {
            if (this.AllBricks.Length != 0)
            {
                this.HeightBrick = size.Height;
                this.WidthBrick = size.Width;

                for (int y = 0; y < nbBrickRow; y++)
                {
                    for (int x = 0; x < nbBrickCol; x++)
                    {
                        if (AllBricks[y, x] != null)
                        {
                            AllBricks[y, x].Size = size;
                        }
                    }
                }

                this.EndBlockBrickX = StartBlockBrickX + NbBrickCol * WidthBrick;
                this.EndBlockBrickY = StartBlockBrickY + NbBrickRow * HeightBrick;

            }
        }

        public void AddBrick(Brick brick, int x, int y)
        {
            if (x >= 0 && y >= 0 && x < this.NbBrickCol && y < this.NbBrickRow)
            {
                AllBricks[y, x] = brick;
                brick.XBrick = x;
                brick.YBrick = y;
                brick.Life = 3;
                brick.Bonus = new AddBallBonus(0.05f, 5);
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
                AllBricks[ brick.YBrick, brick.XBrick] = null;
            }
        }

        public void InitializePositionBrick()
        {
            for (int y = 0; y < nbBrickRow; y++)
            {
                for (int x = 0; x < nbBrickCol; x++)
                {
                    if (AllBricks[y, x] != null)
                    {
                        AllBricks[y, x].Position = new Vector2(this.StartBlockBrickX + x * WidthBrick, this.StartBlockBrickY + y * HeightBrick);
                    }
                }
            }

        }

        public Brick GetBrick(int x , int y)
        {
            if (x < 0 || y < 0 || y >= NbBrickRow || x>= NbBrickCol)
            {
                return null;
            }
            return AllBricks[y, x];
        }

        public Rectangle GetBox()
        {
            return new Rectangle((int)StartBlockBrickX, (int)StartBlockBrickY, (int)Math.Abs(StartBlockBrickX - EndBlockBrickX), (int)Math.Abs(StartBlockBrickY - EndBlockBrickY));
        }

        public override string ToString()
        {
            return string.Format("{0} {1}      et y: {2} {3}",
                this.StartBlockBrickX, this.EndBlockBrickX,
                this.StartBlockBrickY, this.EndBlockBrickY);
        }

        public int GetNbBricks()
        {
            int nbBricks = 0;

            for (int y = 0; y < nbBrickRow; y++)
            {
                for (int x = 0; x < nbBrickCol; x++)
                {
                    if (AllBricks[y, x] != null)
                    {
                        nbBricks++;
                    }
                }
            }

            return nbBricks;
        }
    }
}
