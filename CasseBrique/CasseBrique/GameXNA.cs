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
        private List<Player> players;
        private KeyboardState previousKeyboardState;

       // SoundEffect ballReboundBar;

        public GameXNA(List<Player> _players, System.Windows.Forms.Form form) : base()
        {
            form.Close();
            if (_players != null)
            {
                this.players = _players;
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

            model = new BreakoutModel(0, 0, (float)(0.2*widthFrame), (float)(0.2 * heightFrame));
            view = new ViewBreakout(model);
            model.AddView(view);

            if (this.players != null)
            {
                foreach (Player player in this.players)
                {
                    model.AddPlayer(player);
                    model.AddBall(new Ball());
                }
            }

            controlerBar = new ControlerBarKeyboard(model);
            controlerBall = new ControlerBall(model);
            controlerBonus = new ControlerBonus(model);

            try
            {
                Player player = model.Players[0];
                player.Bar.Position = new Vector2(50, heightFrame - 20);
                player.Bar.Size.Width = 99;
                player.Bar.Size.Height = 7;
                player.MoveLeftKey = Keys.Q;
                player.MoveRightKey = Keys.D;

                if (model.Players.Count > 1)
                {
                    player = model.Players[1];
                    player.Bar.Position = new Vector2(widthFrame - 50 - 99, heightFrame - 20);
                    player.Bar.Size.Width = 99;
                    player.Bar.Size.Height = 7;
                    player.MoveLeftKey = Keys.K;
                    player.MoveRightKey = Keys.M;
                }

                //on considère ici qu'il y a une balle par joueur
                int i = 0;
                foreach (Ball ball in model.Balls)
                {
                    Bar bar = model.Players[i].Bar;

                    ball.Size.Width = 16;
                    ball.Size.Height = 16;
                    ball.Position = new Vector2(bar.Position.X + (float)(bar.Size.Width / 2) - (float)(ball.Size.Height / 2), bar.Position.Y - ball.Size.Width);
                    ball.Speed = 0.3f;
                    i++;
                }

                foreach (AbstractBonus bonus in model.Bonuses)
                {
                    bonus.Size.Width = 32;
                    bonus.Size.Height = 32;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in CasseBrique LoadContent: " + e.Message);
            }

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
            view.LoadContent(Content);
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
            KeyboardState keyboardState = Keyboard.GetState();

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || keyboardState.IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            if (keyboardState.IsKeyDown(Keys.Space) && previousKeyboardState != null && previousKeyboardState.IsKeyUp(Keys.Space))
            {
                model.Pause = !model.Pause;
            }

            if (!model.Pause)
            {
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
                    controlerBar.HandleInput(keyboardState, Mouse.GetState(), gameTime, widthFrame, player);

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
            }

            previousKeyboardState = keyboardState;

            if (model.IsGameWon() ||model.IsGameLost())
            {
                bool won = model.IsGameWon();
                EndGame m = new EndGame(model);
                m.ShowDialog();
                this.Exit();
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
