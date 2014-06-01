using Breakout.Events;
using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Breakout.Views
{
    /// <summary>
    /// This class represents the view of the zone of bricks.
    /// </summary>
    public class ViewBricksZone : View
    {
        /// <summary>
        /// Gets or sets the view of all the bricks.
        /// </summary>
        /// <value>
        /// The view bricks.
        /// </value>
        public ViewBrick[,] ViewBricks { get; set; }

        /// <summary>
        /// Gets or sets the brick zone (from the model).
        /// </summary>
        /// <value>
        /// The brick zone.
        /// </value>
        public BrickZone BrickZone { get; set; }

        /// <summary>
        /// Gets or sets the number of bricks per columns.
        /// </summary>
        /// <value>
        /// The nb brick col.
        /// </value>
        public int NbBrickCol { get; set; }

        /// <summary>
        /// Gets or sets the number of bricks per rows.
        /// </summary>
        /// <value>
        /// The nb brick row.
        /// </value>
        public int NbBrickRow { get; set; }

        /// <summary>
        /// Gets or sets the image of a brick with 0 life.
        /// </summary>
        /// <value>
        /// The image of a brick with 0 life
        /// </value>
        public Texture2D ViewBrick0Life { get; set; }

        /// <summary>
        /// Gets or sets the image of a brick with 1 life.
        /// </summary>
        /// <value>
        /// The image of a brick with 1 life
        /// </value>
        public Texture2D ViewBrick1Life { get; set; }

        /// <summary>
        /// Gets or sets the image of a brick with 2 life.
        /// </summary>
        /// <value>
        /// The image of a brick with 2 life
        /// </value>
        public Texture2D ViewBrick2Life { get; set; }

        /// <summary>
        /// Gets or sets the image of a brick with 3 life.
        /// </summary>
        /// <value>
        /// The image of a brick with 3 life
        /// </value>
        public Texture2D ViewBrick3Life { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewBricksZone"/> class.
        /// </summary>
        /// <param name="brickZone">The brick zone.</param>
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

        /// <summary>
        /// Loads the content, here all the images.
        /// </summary>
        /// <param name="content">The content.</param>
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

        /// <summary>
        /// Draws the texture of all the bricks using the sprite bach.
        /// </summary>
        /// <param name="spriteBatch">The sprite batch.</param>
        /// <param name="gameTime">The game time.</param>
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

        /// <summary>
        /// Refreshes the view according to the specified e.
        /// </summary>
        /// <param name="e">The event fired.</param>
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
