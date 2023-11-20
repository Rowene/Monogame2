using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D blackTexture;
        Texture2D whiteTexture;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferHeight = 640;
            _graphics.PreferredBackBufferWidth = 640;
            _graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            blackTexture = Content.Load<Texture2D>("black");
            whiteTexture = Content.Load<Texture2D>("white");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            for (int i = 0; i != 8; i++)
            {
                if (i %2 == 0) { _spriteBatch.Draw(whiteTexture, new Rectangle(0, i * 80, 80, 80), Color.White); }
                else { _spriteBatch.Draw(blackTexture, new Rectangle(0, i*80, 80, 80),Color.White); }
            }
            for (int i = 0; i != 8; i++)
            {
                if (i % 2 == 0) { _spriteBatch.Draw(blackTexture, new Rectangle(80, i * 80, 80, 80), Color.White); }
                else { _spriteBatch.Draw(whiteTexture, new Rectangle(80, i * 80, 80, 80), Color.White); }
            }
            for (int i = 0; i != 8; i++)
            {
                if (i % 2 == 0) { _spriteBatch.Draw(whiteTexture, new Rectangle(160, i * 80, 80, 80), Color.White); }
                else { _spriteBatch.Draw(blackTexture, new Rectangle(160, i * 80, 80, 80), Color.White); }
            }
            for (int i = 0; i != 8; i++)
            {
                if (i % 2 == 0) { _spriteBatch.Draw(blackTexture, new Rectangle(240, i * 80, 80, 80), Color.White); }
                else { _spriteBatch.Draw(whiteTexture, new Rectangle(240, i * 80, 80, 80), Color.White); }
            }
            for (int i = 0; i != 8; i++)
            {
                if (i % 2 == 0) { _spriteBatch.Draw(whiteTexture, new Rectangle(320, i * 80, 80, 80), Color.White); }
                else { _spriteBatch.Draw(blackTexture, new Rectangle(320, i * 80, 80, 80), Color.White); }
            }
            for (int i = 0; i != 8; i++)
            {
                if (i % 2 == 0) { _spriteBatch.Draw(blackTexture, new Rectangle(400, i * 80, 80, 80), Color.White); }
                else { _spriteBatch.Draw(whiteTexture, new Rectangle(400, i * 80, 80, 80), Color.White); }
            }
            for (int i = 0; i != 8; i++)
            {
                if (i % 2 == 0) { _spriteBatch.Draw(whiteTexture, new Rectangle(480, i * 80, 80, 80), Color.White); }
                else { _spriteBatch.Draw(blackTexture, new Rectangle(480, i * 80, 80, 80), Color.White); }
            }
            for (int i = 0; i != 8; i++)
            {
                if (i % 2 == 0) { _spriteBatch.Draw(blackTexture, new Rectangle(560, i * 80, 80, 80), Color.White); }
                else { _spriteBatch.Draw(whiteTexture, new Rectangle(560, i * 80, 80, 80), Color.White); }
            }

            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}