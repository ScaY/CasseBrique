using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CasseBrique;
using Microsoft.Xna.Framework;

namespace Breakout.Model
{
    public class BreakoutModel : GameModel
    {
        public BrickZone BrickZone { get; set; }

        public Ball Ball { get; set; }

        public Bar Bar { get; set; }
        public BreakoutModel(int nbBrickCol, int nbBrickRow, float startBlockBrickX, float startBlockBrickY)
        {
            this.BrickZone = new BrickZone(nbBrickCol, nbBrickRow, startBlockBrickX, startBlockBrickY);
            this.Ball = new Ball();
            this.Bar = new Bar();
        }

        public void AddBrick(Brick brick, int x, int y)
        {
            BrickZone.AddBrick(brick, x, y);
        }

        public void RemoveBrick(Brick brick)
        {
            BrickZone.RemoveBrick(brick);
        }

        public void UpdateBrickLife(Brick brick, int life)
        {
            brick.Life = life;
        }
    }
}
