#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Breakout.Model;
using Breakout.Views;
using Breakout.Controler;
using Breakout.Bonus;
using CasseBrique.Controler;


#endregion

namespace Breakout
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class GameXNA : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        //dimensions de la fenêtre
        private int widthFrame;
        private int heightFrame;

        private BreakoutModel model;
        private ViewBreakout view;
        private ControlerBall controlerBall;
        private ControlerBonus controlerBonus;
        private List<Player> players;
        private Level level;
        private KeyboardState previousKeyboardState;

        //les différents controleur de la barre disponible
        private ControlerBarKeyboard controlerBarKeyboard;
        private ControlerBarMouse controlerbarMouse;

        public GameXNA(List<Player> _players, Level _level) : base()
        {
            this.InitializeVariables(_players, _level);
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.Window.Title = "Casse Tuile";
            this.Window.AllowUserResizing = false;
        }

        public void InitializeVariables(List<Player> _players, Level _level)
        {
            this.players = _players;
            this.level = _level;
        }

        public void Reset(List<Player> _players, Level _level)
        {
            this.InitializeVariables(_players, _level);
            this.Initialize();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            
            this.widthFrame = this.GraphicsDevice.Viewport.Width;
            this.heightFrame = this.GraphicsDevice.Viewport.Height;

            if (this.level == null)
            {
                this.model = new BreakoutModel(10, 10, 0, 0);
            }
            else
            {
                this.model = new BreakoutModel(level);
            }

            this.view = new ViewBreakout(model,this.heightFrame,this.widthFrame);
            
            this.model.AddView(view);

            if (this.players != null)
            {
                foreach (Player player in this.players)
                {
                    model.AddPlayer(player);
                    Ball ball = new Ball();
                    model.AddBall(ball);
                    player.Bar.StartBall = ball;

                }
            }

            controlerBarKeyboard = new ControlerBarKeyboard(model);
            controlerbarMouse = new ControlerBarMouse(model);
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
                Console.WriteLine("Exception in CasseTuile LoadContent: " + e.Message);
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
            view.LoadContent(Content, widthFrame, heightFrame, model);
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
            MouseState mouseState = Mouse.GetState();

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || keyboardState.IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            if (keyboardState.IsKeyDown(Keys.Space) && previousKeyboardState != null && previousKeyboardState.IsKeyUp(Keys.Space))
            {
                model.SetPause(!model.Pause);
            }

            if (mouseState.LeftButton == ButtonState.Pressed)
            {
                model.GameLauch = true;
            }

            if (!model.Pause)
            {
                try
                {
                    foreach (Ball ball in model.Balls)
                    {
                        controlerBall.HandleBall(ball, gameTime, this.heightFrame, this.widthFrame);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
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
                    if (player.ControlGame == NameControlerBar.KeyboardKM || player.ControlGame == NameControlerBar.KeyboardQD)
                    {
                        controlerBarKeyboard.HandleInput(keyboardState, mouseState, gameTime, widthFrame, player);
                    }
                    else if (player.ControlGame == NameControlerBar.Mouse)
                    {
                        controlerbarMouse.HandleInput(keyboardState, mouseState, gameTime, widthFrame, player);
                    }

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

                if (model.IsGameWon() || model.IsGameLost())
                {
                    model.SetPause(true);
                    System.Windows.Forms.Form m = new EndGame(model, this, gameTime);
                    m.ShowDialog();
                }
            }

            previousKeyboardState = keyboardState;

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(51,51,51));
            
            //signal au SpriteBatch le début du déssin
            spriteBatch.Begin();
            view.Draw(spriteBatch, gameTime);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
