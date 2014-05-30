
using Breakout.Bonus;
using Microsoft.Xna.Framework;
using System;

namespace Breakout.Model
{
    /// <summary>
    /// This a class that represents a zone of bricks.
    /// </summary>
    public class BrickZone
    {
        /// <summary>
        /// The bricks
        /// </summary>
        private Brick[,] bricks;

        /// <summary>
        /// Gets or sets the bricks.
        /// </summary>
        /// <value>
        /// The bricks.
        /// </value>
        public Brick[,] AllBricks
        {
            get { return bricks; }
            set { bricks = value; }
        }


        /// <summary>
        /// The start block brick x coordinate
        /// </summary>
        private float startBlockBrickX;

        /// <summary>
        /// Gets or sets the start block brick x coordinate.
        /// </summary>
        /// <value>
        /// The start block brick x coordinate.
        /// </value>
        public float StartBlockBrickX
        {
            get { return startBlockBrickX; }
            set { startBlockBrickX = value; }
        }

        /// <summary>
        /// The start block brick y coordinate
        /// </summary>
        private float startBlockBrickY;

        /// <summary>
        /// Gets or sets the start block brick y coordinate.
        /// </summary>
        /// <value>
        /// The start block brick y coordinate.
        /// </value>
        public float StartBlockBrickY
        {
            get { return startBlockBrickY; }
            set { startBlockBrickY = value; }
        }

        /// <summary>
        /// The end block brick x coordinate
        /// </summary>
        private float endBlockBrickX;

        /// <summary>
        /// Gets or sets the end block brick x coordinate.
        /// </summary>
        /// <value>
        /// The end block brick x coordinate.
        /// </value>
        public float EndBlockBrickX
        {
            get { return endBlockBrickX; }
            set { endBlockBrickX = value; }
        }

        /// <summary>
        /// The end block brick y coordinate
        /// </summary>
        private float endBlockBrickY;

        /// <summary>
        /// Gets or sets the end block brick y coordinate.
        /// </summary>
        /// <value>
        /// The end block brick y coordinate.
        /// </value>
        public float EndBlockBrickY
        {
            get { return endBlockBrickY; }
            set { endBlockBrickY = value; }
        }

        /// <summary>
        /// The number of bricks per rows
        /// </summary>
        private int nbBrickRow;

        /// <summary>
        /// Gets or sets the number of bricks per rows.
        /// </summary>
        /// <value>
        /// The number of bricks per rows.
        /// </value>
        public int NbBrickRow
        {
            get { return nbBrickRow; }
            set { nbBrickRow = value; }
        }

        /// <summary>
        /// The number of bricks per columns
        /// </summary>
        private int nbBrickCol;

        /// <summary>
        /// Gets or sets the number of bricks per columns.
        /// </summary>
        /// <value>
        /// The number of bricks per columns.
        /// </value>
        public int NbBrickCol
        {
            get { return nbBrickCol; }
            set { nbBrickCol = value; }
        }

        /// <summary>
        /// The height of the brick
        /// </summary>
        private float heightBrick;

        /// <summary>
        /// Gets or sets the height of the brick.
        /// </summary>
        /// <value>
        /// The height of the brick.
        /// </value>
        public float HeightBrick
        {
            get { return heightBrick; }
            set { heightBrick = value; }
        }

        /// <summary>
        /// The width of the brick
        /// </summary>
        private float widthBrick;

        /// <summary>
        /// Gets or sets the width of the brick.
        /// </summary>
        /// <value>
        /// The width of the brick.
        /// </value>
        public float WidthBrick
        {
            get { return widthBrick; }
            set { widthBrick = value; }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BrickZone"/> class.
        /// </summary>
        public BrickZone()
        {
            
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BrickZone"/> class.
        /// </summary>
        /// <param name="nbBrickCol">The number of bricks per columns.</param>
        /// <param name="nbBrickRow">The number of bricks per rows.</param>
        /// <param name="startBlockBrickX">The start block brick x coordinate.</param>
        /// <param name="startBlockBrickY">The start block brick y coordinate.</param>
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

            this.StartBlockBrickX = startBlockBrickX;
            this.StartBlockBrickY = startBlockBrickY;

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BrickZone"/> class.
        /// </summary>
        /// <param name="nbBrickCol">The number of bricks per columns.</param>
        /// <param name="nbBrickRow">The number of bricks per rows.</param>
        /// <param name="startBlockBrickX">The start block brick x coordinate.</param>
        /// <param name="startBlockBrickY">The start block brick y coordinate.</param>
        /// <param name="bricks">The bricks.</param>
        public BrickZone(int nbBrickCol, int nbBrickRow, float startBlockBrickX, float startBlockBrickY,Brick[,] bricks)
        {
            this.AllBricks = bricks;
            this.NbBrickCol = nbBrickCol;
            this.NbBrickRow = nbBrickRow;


            this.StartBlockBrickX = startBlockBrickX;
            this.StartBlockBrickY = startBlockBrickY;
        }

        /// <summary>
        /// Initializes the size of the bricks.
        /// </summary>
        /// <param name="size">The size.</param>
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

        /// <summary>
        /// Adds the brick.
        /// </summary>
        /// <param name="brick">The brick.</param>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
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

        /// <summary>
        /// Removes the brick.
        /// </summary>
        /// <param name="brick">The brick.</param>
        public void RemoveBrick(Brick brick)
        {
            if (brick != null)
            {
                AllBricks[ brick.YBrick, brick.XBrick] = null;
            }
        }

        /// <summary>
        /// Initializes the positions of the bricks.
        /// </summary>
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

        /// <summary>
        /// Gets the brick.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <returns>the brick</returns>
        public Brick GetBrick(int x , int y)
        {
            if (x < 0 || y < 0 || y >= NbBrickRow || x>= NbBrickCol)
            {
                return null;
            }
            return AllBricks[y, x];
        }

        /// <summary>
        /// Gets the bounding box.
        /// </summary>
        /// <returns>a rectangle corresponding to the bounding box</returns>
        public Rectangle GetBox()
        {
            return new Rectangle((int)StartBlockBrickX, (int)StartBlockBrickY, (int)Math.Abs(StartBlockBrickX - EndBlockBrickX), (int)Math.Abs(StartBlockBrickY - EndBlockBrickY));
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0} {1}      et y: {2} {3}",
                this.StartBlockBrickX, this.EndBlockBrickX,
                this.StartBlockBrickY, this.EndBlockBrickY);
        }

        /// <summary>
        /// Gets the numberb of bricks.
        /// </summary>
        /// <returns>the number of bricks</returns>
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
