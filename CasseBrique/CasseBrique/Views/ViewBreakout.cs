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
    public class ViewBreakout : View
    {
        public List<ViewBar> ViewBars { get; set; }

        public List<ViewBall> ViewBalls { get; set; }

        public ViewBricksZone ViewBricksZone { get; set; }

        public List<ViewBonus> ViewBonuses { get; set; }

        public ViewPause ViewPause { get; set; }

        private Texture2D textureBar;
        private Texture2D textureBall;
        private Texture2D textureBonus;
        private Texture2D texturePause;

        public ViewBreakout(BreakoutModel breakout,int height,int width)
        {   
            breakout.BrickZone.InitializeSizeBrick(new Size(width/10, height/11));
            breakout.BrickZone.InitializePositionBrick();

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

        public void LoadContent(ContentManager content, int widthFrame, int heightFrame) {
            this.textureBar = content.Load<Texture2D>("barMid");
            this.textureBall = content.Load<Texture2D>("ballSmall");
            this.textureBonus = content.Load<Texture2D>("bonus");
            this.texturePause = content.Load<Texture2D>("pause");
            foreach (ViewBar viewBar in this.ViewBars)
            {
                viewBar.Texture = this.textureBar;
            }

            foreach(ViewBall viewBall in this.ViewBalls)
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
                    viewBonus.Texture = this.textureBonus;
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
                    viewBall.Texture = this.textureBall;
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
