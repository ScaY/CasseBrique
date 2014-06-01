using Breakout.Bonus;
using Breakout.Events;
using Breakout.Model;
using CasseBrique.Events;
using CasseBrique.Views;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Linq;

namespace Breakout.Views
{
    /// <summary>
    /// This class represents the graphical interface of the breakout.
    /// </summary>
    public class ViewBreakout : View
    {
        /// <summary>
        /// Gets or sets the view of the bars.
        /// </summary>
        /// <value>
        /// The view bars.
        /// </value>
        public List<ViewBar> ViewBars { get; set; }

        /// <summary>
        /// Gets or sets the view of the balls.
        /// </summary>
        /// <value>
        /// The view balls.
        /// </value>
        public List<ViewBall> ViewBalls { get; set; }

        /// <summary>
        /// Gets or sets the view of the bricks zone.
        /// </summary>
        /// <value>
        /// The view bricks zone.
        /// </value>
        public ViewBricksZone ViewBricksZone { get; set; }

        /// <summary>
        /// Gets or sets the view of the bonuses.
        /// </summary>
        /// <value>
        /// The view bonuses.
        /// </value>
        public List<ViewBonus> ViewBonuses { get; set; }

        /// <summary>
        /// Gets or sets the view of the pause.
        /// </summary>
        /// <value>
        /// The view pause.
        /// </value>
        public ViewPause ViewPause { get; set; }

        /// <summary>
        /// The texture of the bar
        /// </summary>
        private Texture2D textureBar;
        /// <summary>
        /// The texture of the ball
        /// </summary>
        private Texture2D textureBall;
        /// <summary>
        /// The texture of the IEbonus
        /// </summary>
        private Texture2D textureIEBonus;
        /// <summary>
        /// The texture of the FireFoxbonus
        /// </summary>
        private Texture2D textureFireFoxBonus;
        /// <summary>
        /// The texture of the Chromebonus
        /// </summary>
        private Texture2D textureChromeBonus;
        /// <summary>
        /// The texture of the pause
        /// </summary>
        private Texture2D texturePause;
        /// <summary>
        /// The texture of the ball bonus
        /// </summary>
        private Texture2D textureBallBonus;
        /// <summary>
        /// The texture of the brick
        /// </summary>
        private Texture2D textureBrick;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewBreakout"/> class.
        /// </summary>
        /// <param name="breakout">The breakout model.</param>
        /// <param name="height">The height.</param>
        /// <param name="width">The width.</param>
        public ViewBreakout(BreakoutModel breakout, int height, int width)
        {

            this.ViewBars = new List<ViewBar>();
            foreach (Player player in breakout.Players)
            {
                this.ViewBars.Add(new ViewBar(player.Bar));
            }

            this.ViewBalls = new List<ViewBall>();
            foreach (Ball ball in breakout.Balls)
            {
                this.ViewBalls.Add(new ViewBall(ball));
            }

            this.ViewBricksZone = new ViewBricksZone(breakout.BrickZone);
            this.ViewBonuses = new List<ViewBonus>();

            foreach (AbstractBonus bonus in breakout.Bonuses)
            {
                this.ViewBonuses.Add(new ViewBonus(bonus));
            }

            this.ViewPause = new ViewPause();
        }

        /// <summary>
        /// Loads the content, here all the images.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <param name="widthFrame">The width frame.</param>
        /// <param name="heightFrame">The height frame.</param>
        /// <param name="breakout">The breakout.</param>
        public void LoadContent(ContentManager content, int widthFrame, int heightFrame, BreakoutModel breakout)
        {
            this.textureBar = content.Load<Texture2D>("barMid");
            this.textureBall = content.Load<Texture2D>("ballSmall");
            this.textureIEBonus = content.Load<Texture2D>("IEbonus");
            this.textureChromeBonus = content.Load<Texture2D>("ChromeBonus");
            this.textureFireFoxBonus = content.Load<Texture2D>("FireFoxBonus");
            this.texturePause = content.Load<Texture2D>("PauseCasseTuile");
            this.textureBallBonus = content.Load<Texture2D>("ballBonus");
            this.textureBrick = content.Load<Texture2D>("brick0life");

            breakout.BrickZone.InitializeSizeBrick(new Size(textureBrick.Width, textureBrick.Height));
            breakout.BrickZone.InitializePositionBrick();

            foreach (ViewBar viewBar in this.ViewBars)
            {
                viewBar.Texture = this.textureBar;
            }

            foreach (ViewBall viewBall in this.ViewBalls)
            {
                viewBall.Texture = this.textureBall;
            }

            foreach (ViewBonus viewBonus in this.ViewBonuses)
            {
                viewBonus.Texture = this.textureBar;
            }

            this.ViewBricksZone.LoadContent(content);

            this.ViewPause.LoadContent(this.texturePause, widthFrame, heightFrame);
        }

        /// <summary>
        /// Draws the components of the view by calling the draw method on all the sub components.
        /// </summary>
        /// <param name="spriteBatch">The sprite batch.</param>
        /// <param name="gameTime">The game time.</param>
        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            foreach (ViewBall viewBall in this.ViewBalls)
            {
                viewBall.Draw(spriteBatch, gameTime);
            }

            foreach (ViewBar viewBar in this.ViewBars)
            {
                viewBar.Draw(spriteBatch, gameTime);
            }

            ViewBricksZone.Draw(spriteBatch, gameTime);

            foreach (ViewBonus viewBonus in this.ViewBonuses)
            {
                viewBonus.Draw(spriteBatch, gameTime);
            }

            ViewPause.Draw(spriteBatch, gameTime);
        }

        /// <summary>
        /// Refreshes the view according to the specified e.
        /// </summary>
        /// <param name="e">The event fired.</param>
        public void Refresh(Event e)
        {
            if (e is PlayerEvent)
            {
                PlayerEvent pe = (PlayerEvent)e;

                if (e is AddedPlayerEvent)
                {
                    ViewBar viewBar = new ViewBar(pe.Player.Bar);
                    viewBar.Texture = this.textureBar;
                    this.ViewBars.Add(viewBar);
                }
            }
            else if (e is BrickEvent)
            {
                this.ViewBricksZone.Refresh(e);
            }
            else if (e is BonusEvent)
            {
                BonusEvent be = (BonusEvent)e;

                if (e is AddedBonusEvent)
                {
                    ViewBonus viewBonus = new ViewBonus(be.Bonus);
                    if (be.Bonus is AddBallBonus)
                    {
                        viewBonus.Texture = this.textureIEBonus;
                    }
                    else if (be.Bonus is BallSpeedBonus)
                    {
                        viewBonus.Texture = this.textureChromeBonus;
                    }
                    else if (be.Bonus is BarSizeBonus)
                    {
                        viewBonus.Texture = this.textureFireFoxBonus;
                    }
                    this.ViewBonuses.Add(viewBonus);
                }
                else if (e is RemovedBonusEvent)
                {
                    bool found = false;
                    int i = 0;
                    while (!found && i < this.ViewBonuses.Count)
                    {
                        ViewBonus view = this.ViewBonuses.ElementAt(i);
                        if (view.Shape == be.Bonus)
                        {
                            this.ViewBonuses.Remove(view);
                            found = true;
                        }

                        i++;
                    }
                }
            }
            else if (e is BallEvent)
            {
                BallEvent be = (BallEvent)e;

                if (e is AddedBallEvent)
                {
                    ViewBall viewBall = new ViewBall(be.Ball);
                    viewBall.Texture = this.textureBallBonus;
                    this.ViewBalls.Add(viewBall);
                }
                else if (e is RemovedBallEvent)
                {
                    bool found = false;
                    int i = 0;
                    while (!found && i < this.ViewBalls.Count)
                    {
                        ViewBall view = this.ViewBalls.ElementAt(i);
                        if (view.Shape == be.Ball)
                        {
                            this.ViewBalls.Remove(view);
                            found = true;
                        }

                        i++;
                    }
                }
            }
            else if (e is GamePause)
            {
                ViewPause.Refresh(e);
            }
        }
    }
}
