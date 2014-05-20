#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace CasseBrique
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class CasseBrique : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public const float speedBall = 0.2f;
        public const float speedBar = 0.5f;

        //dimensions de la fenêtre
        private int widthFrame;
        private int heightFrame;

        //MVC concernant la barre
        private Bar bar1;
        private ControlerBar controlerBar1;
        private View viewBar1;

        //MVC concernant la balle
        private Ball ball1;
        private ControlerBall controlerBall1;
        private View viewBall1;

        private Bricks bricks;
        private ViewBricks viewBricks;

        public CasseBrique()
            : base()
        {
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

            bar1 = new Bar(Vector2.Zero, Vector2.Normalize(Vector2.UnitX), speedBar);
            controlerBar1 = new ControlerbarKeyboard(bar1);
            viewBar1 = new ViewBar();
            bar1.addView(viewBar1);

            ball1 = new Ball(Vector2.Zero, Vector2.Normalize(new Vector2(1, -1)), speedBall);
            controlerBall1 = new ControlerBall(ball1);
            viewBall1 = new ViewBall();
            ball1.addView(viewBall1);

            bricks = new Bricks(1, 5, (float)(heightFrame * 0.2), (float)(heightFrame * 0.2));
            viewBricks = new ViewBricks();
            bricks.InitializeViewBrick();

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
                viewBar1.LoadContent(Content, "barMid");
                bar1.Position = new Vector2((float)(widthFrame - viewBar1.Texture.Width) / 2, heightFrame * 0.9f);

                //chargement de l'image de la balle du jeu
                viewBall1.LoadContent(Content, "balleMid");
                ball1.Position = new Vector2((float)(widthFrame - viewBar1.Texture.Width) / 2, heightFrame * 0.9f - viewBar1.Texture.Height);

                //chargement des images de brique
                bricks.InitializeTextureBrick(Content);
                //initialisation de la pasotion des briques en fonction de la taille de leur image
                bricks.InitializePositionBrick();
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

            controlerBar1.HandleInput(Keyboard.GetState(), Mouse.GetState(), gameTime, widthFrame);
            controlerBall1.HandleTrajectoryBall(bar1, gameTime, heightFrame, widthFrame, bricks);

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
            viewBar1.Draw(bar1, spriteBatch, gameTime);
            viewBall1.Draw(ball1, spriteBatch, gameTime);
            viewBricks.Draw(bricks, spriteBatch, gameTime);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
