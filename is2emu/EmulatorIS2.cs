using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace is2emu
{
    class EmulatorIS2 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        /// <summary>
        /// Construct a new <see cref="EmulatorIS2"/>.
        /// </summary>
        public EmulatorIS2()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            //TODO: Add any initialization code needed
            base.Initialize();
        }

        protected override void LoadContent()
        {
            //TODO: Load Akko Pro fonts from Content (do not distribute!)
            //TODO: Load Icons from Content (do not distribute: https://drive.google.com/open?id=0B6fWQWXuE09OOWtBOXJNX190TDQ SVGs zip, this is from TWC themselves, if not working, download straight from weather.com)
            //TODO: Load Background
            base.LoadContent();
        }

        protected override void UnloadContent()
        {
            //TODO: Unload Akko Pro fonts
            //TODO: Unload Icons
            base.UnloadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            //TODO: Render emulator
            base.Draw(gameTime);
        }
    }
}
