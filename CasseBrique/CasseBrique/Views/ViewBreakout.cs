using Breakout.Bonus;
using Breakout.Events;
using Breakout.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breakout.Views
{
    public class ViewBreakout : View
    {
        public List<ViewBar> ViewBars { get; set; }

        public ViewBall ViewBall { get; set; }

        public ViewBricksZone ViewBricksZone { get; set; }

        public List<ViewBonus> ViewBonuses { get; set; }

        private Texture2D textureBar;
        private Texture2D textureBall;
        private Texture2D textureBrick;
        private Texture2D textureBonus;

        public ViewBreakout(BreakoutModel breakout, ContentManager content)
        {
            textureBar = content.Load<Texture2D>("barMid");
            textureBall = content.Load<Texture2D>("ballSmall");
            textureBrick = content.Load<Texture2D>("brick3life");
            textureBonus = content.Load<Texture2D>("bonus");

            //this.ViewBricksZone = new ViewBricksZone(breakout.BrickZone, textureBrick);
            breakout.BrickZone.InitializeSizeBrick(new Size(textureBrick.Width, textureBrick.Height));
            breakout.BrickZone.InitializePositionBrick();

            this.ViewBars = new List<ViewBar>();
            foreach (Player player in breakout.Players)
            {
                this.ViewBars.Add(new ViewBar(player.Bar, textureBar));
            }

            this.ViewBall = new ViewBall(breakout.Ball, textureBall);
            this.ViewBricksZone = new ViewBricksZone(breakout.BrickZone, textureBrick, breakout.BrickZone, content);
            this.ViewBonuses = new List<ViewBonus>();

            foreach (AbstractBonus bonus in breakout.Bonuses)
            {
                this.ViewBonuses.Add(new ViewBonus(bonus, textureBonus));
            }

        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            ViewBall.Draw(spriteBatch, gameTime);

            foreach (ViewBar viewBar in ViewBars)
            {
                viewBar.Draw(spriteBatch, gameTime);
            }

            ViewBricksZone.Draw(spriteBatch, gameTime);
            
            foreach (ViewBonus viewBonus in ViewBonuses)
            {
                viewBonus.Draw(spriteBatch, gameTime);
            }
        }

        public void Refresh(Event e)
        {
            if (e is PlayerEvent)
            {
                PlayerEvent pe = (PlayerEvent)e;

                if (e is AddedPlayerEvent)
                {
                    this.ViewBars.Add(new ViewBar(pe.Player.Bar, textureBar));
                }
            }
            else if (e is BrickEvent)
            {
                if (e is BrickLifeUpdatedEvent)
                {
                    this.ViewBricksZone.Refresh(e);
                }
            }
            else if (e is BonusEvent)
            {
                BonusEvent be = (BonusEvent)e;

                if (e is AddedBonusEvent)
                {
                    this.ViewBonuses.Add(new ViewBonus(be.Bonus, textureBonus));
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
        }
    }
}
