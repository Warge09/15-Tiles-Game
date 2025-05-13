using System.Collections.Generic;
using System.Collections;
// using System.Timers;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace _2D_Game 
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private static int WINDOW_Width = 1080;
        private static int WINDOW_Height = 720;

        private MouseState mouseState, Previousmousestate;

        private int Moves;
        private Random rng;
        
        public enum GAMESTATES { MENU, START, COMPLETE, END};
        private GAMESTATES currentstate;

        private Texture2D BackgroundImage;
        private Texture2D TileImage;
        private Texture2D ButtonImage;

        private Song MainmenuSong;
        private Song BackgroundSong;
        

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _graphics.PreferredBackBufferWidth = WINDOW_Width;
            _graphics.PreferredBackBufferHeight = WINDOW_Height;
            Window.Title = "15 Tiles Games";
            Window.AllowUserResizing = false;
            
        }

        protected override void Initialize()
        {
            Moves = 0;
            currentstate = GAMESTATES.MENU;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            MainmenuSong = Content.Load<Song>("awesomeness");
            BackgroundSong = Content.Load<Song>("BackgroundSong");
            BackgroundImage  =  Content.Load<Texture2D>("");
            TileImage =  Content.Load<Texture2D>("");
            ButtonImage =  Content.Load<Texture2D>("");

            MediaPlayer.Play(MainmenuSong);
        }

        private void TileManager()
        {
            int TileWidth = 10;
            int TileHeight = 10;
            for (int i  = 1; i <=  TileWidth; i++) {
                for (int j = 1; j <= TileHeight; j++)
                {


                }
            }

        }

        void UpdateMENU(GameTime deltaTime)
        {
            
            

        }

        void UpdateSTART(GameTime deltaTime)
        {

        }

        void UpdateCOMPLETE(GameTime deltaTime)
        {

        }

        void UpdateEND(GameTime deltaTime)
        {

        }

        protected void Update(GameTime gameTime, GameTime deltaTime)
        {
            base.Update(deltaTime);
            switch (currentstate)
            {
                case GAMESTATES.MENU:
                    UpdateMENU(deltaTime);
                    break;
                case GAMESTATES.START:
                    UpdateSTART(deltaTime);
                    break;
                case GAMESTATES.COMPLETE:
                    UpdateCOMPLETE(deltaTime);
                    break;
                case GAMESTATES.END:
                    UpdateEND(deltaTime);
                    break;
            }


            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
            _spriteBatch.End();
        }
    }
}
