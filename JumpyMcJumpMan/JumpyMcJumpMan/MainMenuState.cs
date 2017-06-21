using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace JumpyMcJumpMan
{
    public class MainMenuState : AIE.State
    {
        bool isLoaded = false;
        SpriteFont font = null;
        public int menuSelection = 1;

        public MainMenuState() : base()
        {

        }

        public override void Update(ContentManager content, GameTime gameTime)
        {
            if (isLoaded == false)
            {
                isLoaded = true;
                font = content.Load<SpriteFont>("Agency_FB");
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Enter) == true && menuSelection == 1)
            {
                
                AIE.StateManager.ChangeState("GAME");
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Enter) == true && menuSelection == 2)
            {
                AIE.StateManager.ChangeState("HOW2PLAYMENU");
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Up) == true && menuSelection > 1)
            {
                menuSelection -= 1;         
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Down) == true && menuSelection < 2)
            {
                menuSelection += 1;
            }            
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(font, "JUMPY MC JUMP MAN", new Vector2(20, 20), Color.White);
            if (menuSelection == 1)
            {
                spriteBatch.DrawString(font, "Play Game", new Vector2(20, 60), Color.Silver);
            }
            else
            {
                spriteBatch.DrawString(font, "Play Game", new Vector2(20, 60), Color.White);
            }
            if (menuSelection == 2)
            {
                spriteBatch.DrawString(font, "How to Play", new Vector2(20, 80), Color.Silver);
            }
            else
            {
                spriteBatch.DrawString(font, "How to Play", new Vector2(20, 80), Color.White);
            }
            spriteBatch.DrawString(font, "Press ESC to Close Game", new Vector2(20, 110), Color.White);
            spriteBatch.End();
        }

        public override void CleanUp()
        {
            font = null;
            isLoaded = false;
        }
    }
}
