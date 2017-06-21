using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace JumpyMcJumpMan
{
    public class GameState : AIE.State
    {
        bool isLoaded = false;
        SpriteFont font = null;

        KeyboardState oldState;

        public GameState() : base()
        {

        }

        public override void Update(ContentManager content, GameTime gameTime)
        {
            if (isLoaded == false)
            {
                isLoaded = true;
                font = content.Load<SpriteFont>("Agency_FB");
                oldState = Keyboard.GetState();
            }           
        }

        public override void Draw(SpriteBatch spriteBatch)
        {

        }

        public override void CleanUp()
        {
            font = null;
            isLoaded = false;
        }
    }
}
