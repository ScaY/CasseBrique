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
        private List<Player> players;

        public GameXNA(List<Player> _players)
            : base()
        {
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

            model = new BreakoutModel(2, 2, (float)(0.2*widthFrame), (float)(0.2 * heightFrame));
            
            Bar bar = model.Bar;
            controlerBar = new ControlerBarKeyboard(bar);

            Ball ball = model.Ball;
            controlerBall = new ControlerBall(ball);

            AbstractBonus bonus = new BarSizeBonus();
            bonus.Speed = 0.2f;
            bonus.Position = new Vector2(200, 200);
            bonus.Deplacement = Vector2.Normalize(Vector2.UnitY);
            model.Bonuses.Add(bonus);

            view = new ViewBreakout(model, Content);

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

                //chargement de l'image de la barre du casse brique
                model.Bar.Position = new Vector2((float)(widthFrame - view.ViewBar.Texture.Width) / 2, heightFrame * 0.9f);
                model.Bar.Size.Width = view.ViewBar.Texture.Width;
                model.Bar.Size.Height = view.ViewBar.Texture.Height;

                //chargement de l'image de la balle du jeu
                model.Ball.Position = new Vector2((float)(widthFrame - model.Bar.Size.Width) / 2, heightFrame * 0.9f - model.Bar.Size.Height);
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

            controlerBar.HandleInput(Keyboard.GetState(), Mouse.GetState(), gameTime, widthFrame);
            controlerBall.HandleTrajectory(model, gameTime, heightFrame, widthFrame);

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
