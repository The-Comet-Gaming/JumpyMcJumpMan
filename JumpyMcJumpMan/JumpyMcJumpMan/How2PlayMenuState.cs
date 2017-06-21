using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace JumpyMcJumpMan
{
    public class How2PlayMenuState : AIE.State
    {
        bool isLoaded = false;
        SpriteFont font = null;
        public int menuSelection = 1;

        public How2PlayMenuState() : base()
        {

        }

        public override void Update(ContentManager content, GameTime gameTime)
        {
            if (isLoaded == false)
            {
                isLoaded = true;
                font = content.Load<SpriteFont>("Agency_FB");
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Back) == true && menuSelection == 1)
            {
                AIE.StateManager.ChangeState("MAINMENU");
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(font, "HOW TO PLAY", new Vector2(20, 20), Color.White);
            spriteBatch.DrawString(font, "Arrow Keys: Move Left and Right", new Vector2(20, 60), Color.White);
            spriteBatch.DrawString(font, "Space Bar: Jump", new Vector2(20, 80), Color.White);
            spriteBatch.DrawString(font, "Jump on enemies to kill them", new Vector2(20, 100), Color.White);
            spriteBatch.DrawString(font, "Press Backspace to return to the Main Menu", new Vector2(20, 130), Color.White);
            spriteBatch.End();
        }

        public override void CleanUp()
        {
            font = null;
            isLoaded = false;
        }
    }
}
