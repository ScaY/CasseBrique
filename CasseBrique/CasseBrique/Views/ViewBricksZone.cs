using Breakout.Views;
using CasseBrique.Views;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace CasseBrique
{
    public class ViewBricksZone : View
    {
        public ViewBrick[,] ViewBrick { get; set; }

        public int NbBrickCol { get; set; }

        public int NbBrickRow { get; set; }

        public ViewBricksZone(BrickZone brickZone, Texture2D texture)
        {
            this.ViewBrick = new ViewBrick[brickZone.NbBrickRow, brickZone.NbBrickCol];
            this.NbBrickRow = brickZone.NbBrickRow;
            this.NbBrickCol = brickZone.NbBrickCol;

            for (int i = 0; i < brickZone.NbBrickRow; i++)
            {
                for (int j = 0; j < brickZone.NbBrickCol; j++)
                {
                    ViewBrick[i, j] = new ViewBrick(brickZone.AllBricks[i, j], texture);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            for (int i = 0; i <NbBrickRow; i++)
            {
                for (int j = 0; j < NbBrickCol; j++)
                {
                    ViewBrick[i, j].Draw(spriteBatch, gameTime);
                }
            }
        }
    }
}
