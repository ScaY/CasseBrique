#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
using Breakout.Model;
using Breakout.Views;
using Breakout.Controler;
using Breakout.Bonus;
using CasseBrique.Controler;
using System.Media;

#endregion

namespace Breakout
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class GameXNA : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public const float speedBall = 0.2f;
        public const float speedBar = 0.5f;

        //dimensions de la fenêtre
        private int widthFrame;
        private int heightFrame;

        private BreakoutModel model;
        private ViewBreakout view;
        private ControlerBar controlerBar;
        private ControlerBall controlerBall;
        private ControlerBonus controlerBonus;
        private Player player;

       // SoundEffect ballReboundBar;

        public GameXNA(Player _player)
            : base()
        {
            if (_player != null)
            {
                this.player = _player;
            }
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            widthFrame = Window.ClientBounds.Width;
            heightFrame = Window.ClientBounds.Height;

            model = new BreakoutModel(5, 5, (float)(0.2*widthFrame), (float)(0.2 * heightFrame));
            view = new ViewBreakout(model, Content);
            model.AddView(view);

            model.AddPlayer(player);
            model.AddPlayer(new Player("cc"));
            model.AddBall(new Ball());
            model.AddBall(new Ball());
            controlerBar = new ControlerBarMouse(model);
            controlerBall = new ControlerBall(model);
            controlerBonus = new ControlerBonus(model);

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            try
            {
                for (int i = 0; i < model.Players.Count; i++)
                {
                    Player player = model.Players[i];
                    //chargement de l'image de la barre du casse brique
                    player.Bar.Position = new Vector2((float)(150 * (i+1)) / 2, heightFrame * 0.9f);
                    player.Bar.Size.Width = 99;
                    player.Bar.Size.Height = 7;
                }

                foreach (Ball ball in model.Balls)
                {
                    //chargement de l'image de la balle du jeu
                    ball.Position = new Vector2((float)(widthFrame - 99) / 2 + 100, heightFrame * 0.9f - 7);
                    ball.Size.Width = 16;
                    ball.Size.Height = 16;
                }

                foreach (AbstractBonus bonus in model.Bonuses)
                {
                    bonus.Size.Width = view.ViewBonuses[0].Texture.Width;
                    bonus.Size.Height = view.ViewBonuses[0].Texture.Height;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in CasseBrique LoadContent: " + e.Message);
            }

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            try
            {
                foreach (Ball ball in model.Balls)
                {
                    controlerBall.HandleBall(ball, gameTime, heightFrame, widthFrame);
                }
            }
            catch (Exception e)
            {
            }

            try
            {
                foreach (AbstractBonus bonus in model.Bonuses)
                {
                    controlerBonus.HandleBonus(gameTime, heightFrame, widthFrame, bonus, gameTime.TotalGameTime);
                }
            }
            catch (Exception e) //je comprends pas encore à quoi est dû la levée d'exception
            {
            }

            foreach (Player player in model.Players)
            {
                controlerBar.HandleInput(Keyboard.GetState(), Mouse.GetState(), gameTime, widthFrame, player);

                try
                {
                    foreach (AbstractBonus bonus in player.Bonuses)
                    {
                        if ((gameTime.TotalGameTime - bonus.StartTime).Seconds > bonus.Duration)
                        {
                            bonus.RemoveBonus(model, player);
                            player.Bonuses.Remove(bonus);
                        }
                    }
                }
                catch (Exception e) //je comprends pas encore à quoi est dû la levée d'exception
                {
                }
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            //signal au SpriteBatch le début du déssin
            spriteBatch.Begin();
            view.Draw(spriteBatch, gameTime);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
