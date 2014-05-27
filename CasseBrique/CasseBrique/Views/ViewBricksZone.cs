using Breakout.Events;
using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Breakout.Views
{
    public class ViewBricksZone : View
    {
        public ViewBrick[,] ViewBricks { get; set; }

        public BrickZone BrickZone { get; set; }

        public int NbBrickCol { get; set; }

        public int NbBrickRow { get; set; }

        public Texture2D ViewBrick0Life { get; set; }

        public Texture2D ViewBrick1Life { get; set; }

        public Texture2D ViewBrick2Life { get; set; }

        public Texture2D ViewBrick3Life { get; set; }

        public ViewBricksZone(BrickZone brickZone, Texture2D texture, BrickZone bricks, ContentManager content)
        {
            this.ViewBricks = new ViewBrick[brickZone.NbBrickRow, brickZone.NbBrickCol];
            this.BrickZone = bricks;

            ViewBrick0Life = content.Load<Texture2D>("brick0life");
            ViewBrick1Life = content.Load<Texture2D>("brick1life");
            ViewBrick2Life = content.Load<Texture2D>("brick2life");
            ViewBrick3Life = content.Load<Texture2D>("brick3life");

            this.NbBrickRow = brickZone.NbBrickRow;
            this.NbBrickCol = brickZone.NbBrickCol;

            for (int i = 0; i < brickZone.NbBrickRow; i++)
            {
                for (int j = 0; j < brickZone.NbBrickCol; j++)
                {
                    ViewBricks[i, j] = new ViewBrick(brickZone.AllBricks[i, j], texture);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            for (int i = 0; i < NbBrickRow; i++)
            {
                for (int j = 0; j < NbBrickCol; j++)
                {
                    if (BrickZone.AllBricks[i, j] != null)
                    {
                        ViewBricks[i, j].Draw(spriteBatch, gameTime);
                    }
                }
            }
        }

        public void Refresh(Event e)
        {
            if (e is BrickLifeUpdatedEvent)
            {
                BrickLifeUpdatedEvent sourceEvent = (BrickLifeUpdatedEvent)e;
                Brick brick = sourceEvent.Brick;
                ViewBrick viewBrick = this.ViewBricks[brick.XBrick, brick.YBrick];
                int lifeBrick = brick.Life;
                switch (lifeBrick)
                {
                    case 0: viewBrick.Texture = ViewBrick0Life;
                        break;
                    case 1: viewBrick.Texture = ViewBrick1Life;
                        break;
                    case 2: viewBrick.Texture = ViewBrick2Life;
                        break;
                    case 3: viewBrick.Texture = ViewBrick3Life;
                        break;
                }
                
                
            }
        }
    }
}
