using Breakout.Events;
using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

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

        public ViewBricksZone(BrickZone brickZone)
        {
            this.ViewBricks = new ViewBrick[brickZone.NbBrickRow, brickZone.NbBrickCol];
            this.BrickZone = brickZone;

            this.NbBrickRow = brickZone.NbBrickRow;
            this.NbBrickCol = brickZone.NbBrickCol;

            for (int i = 0; i < brickZone.NbBrickRow; i++)
            {
                for (int j = 0; j < brickZone.NbBrickCol; j++)
                {
                    if(brickZone.AllBricks[i, j] != null) {
                        ViewBricks[i, j] = new ViewBrick(brickZone.AllBricks[i, j]);
                    }
                }
            }
        }

        public void LoadContent(ContentManager content)
        {
            this.ViewBrick0Life = content.Load<Texture2D>("brick0life");
            this.ViewBrick1Life = content.Load<Texture2D>("brick1life");
            this.ViewBrick2Life = content.Load<Texture2D>("brick2life");
            this.ViewBrick3Life = content.Load<Texture2D>("brick3life");

            for (int i = 0; i < this.BrickZone.NbBrickRow; i++)
            {
                for (int j = 0; j < this.BrickZone.NbBrickCol; j++)
                {
                    if (this.ViewBricks[i, j] != null && this.ViewBricks[i, j].Shape != null)
                    {
                        switch (((Brick)this.ViewBricks[i, j].Shape).Life)
                        {
                            case 0: this.ViewBricks[i, j].Texture = ViewBrick0Life;
                                break;
                            case 1: this.ViewBricks[i, j].Texture = ViewBrick1Life;
                                break;
                            case 2: this.ViewBricks[i, j].Texture = ViewBrick2Life;
                                break;
                            case 3: this.ViewBricks[i, j].Texture = ViewBrick3Life;
                                break;
                        }
                    }
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
                ViewBrick viewBrick = this.ViewBricks[brick.YBrick, brick.XBrick];
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
