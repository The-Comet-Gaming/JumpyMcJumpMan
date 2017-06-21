using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace JumpyMcJumpMan
{
    public class GameOverState : AIE.State
    {
        bool isLoaded = false;
        SpriteFont font = null;

        KeyboardState oldState;

        public GameOverState() : base()
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

            KeyboardState newState = Keyboard.GetState();

            if (Keyboard.GetState().IsKeyDown(Keys.Enter) == true)
            {
                // checking the old state ensures that we only process new key
                //presses (incase the key was held down from the last state
                if (oldState.IsKeyDown(Keys.Enter) == false)
                {
                    AIE.StateManager.ChangeState("GAME");
                }
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Back) == true)
            {
                // checking the old state ensures that we only process new key
                //presses (incase the key was held down from the last state
                if (oldState.IsKeyDown(Keys.Back) == false)
                {
                    AIE.StateManager.ChangeState("MAINMENU");
                }
            }
            oldState = newState;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(font, "GAME OVER...", new Vector2(20, 20), Color.White);
            spriteBatch.DrawString(font, "Press Enter to try again", new Vector2(20, 60), Color.White);
            spriteBatch.DrawString(font, "Press Backspace to return to Main Menu", new Vector2(20, 80), Color.White);
            spriteBatch.End();
        }

        public override void CleanUp()
        {
            font = null;
            isLoaded = false;
        }
    }
}
