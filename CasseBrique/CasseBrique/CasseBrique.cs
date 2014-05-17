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

        private Texture2D ballImgMid;  //image représentant la balle du jeu

        private Vector2 positionBall;   //vecteur représentant la position de la balle

        private Vector2 directionBall;    //vecteur représentant la direction de déplacement de la balle

        public const float speedBall = 0.3f;        //constante représentant la vitesse de la balle

        private SpriteFont font;                    //variable permettant d'écrire

        private Vector2 positionBrickInfo;          //vecteur repésentant la position de l'information des briques restantes 


        //dimensions de la fenêtre
        private int widthFrame;
        private int heightFrame;

        //parametre de la position de la barre
        public const int xSetBar = 5;
        public const int yPosition = 2;

        private Bar bar1;
        private ControlerBar controlerBar1;
        private View viewBar1;

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
            
            bar1 = new Bar();
            controlerBar1 = new ControlerBar(bar1);
            viewBar1 = new ViewBar();

            bar1.Initialize(Vector2.Zero, Vector2.UnitX);
            directionBall = Vector2.Normalize(Vector2.UnitX);

            positionBall = Vector2.Zero;

            positionBrickInfo = new Vector2(widthFrame - 100, 0);   //é changer @@@@ !!!



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
            
            //chargement de l'image de la balle du jeu
            ballImgMid = Content.Load<Texture2D>("balleMid");

            //chargement de l'image de la barre du casse brique
            bar1.LoadContent(Content, "horizontalbarMid");

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

            if (positionBall.X >= widthFrame)
            {
                directionBall = Vector2.Normalize(new Vector2(-1, 0));
            }
            else if (positionBall.X <= 0)
            {
                directionBall = Vector2.Normalize(Vector2.UnitX);
            }

            //permet de gérer le problème du framerate (nombre de tours de la "boule de jeu")
            positionBall += directionBall * speedBall * (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            controlerBar1.HandleInput(Keyboard.GetState(), Mouse.GetState(), gameTime);

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
            spriteBatch.Draw(ballImgMid, positionBall, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
