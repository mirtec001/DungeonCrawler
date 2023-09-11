using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DungeonCrawler.Engine;
public class MainMenu
{
    Texture2D background;
    Texture2D playButton;
    Texture2D quitButton;
    Texture2D highlight;
    Vector2 playButtonPos;
    Vector2 quitButtonPos;
    Vector2 highlightPos;

    KeyboardState mmPreviousKeyState;
    KeyboardState mmCurrentKeyState;

    private Engine engine;

    public MainMenu(ContentManager contentManager, Engine engine)
    {
        background = contentManager.Load<Texture2D>("images/background");
        playButton = contentManager.Load<Texture2D>("images/playbutton");
        quitButton = contentManager.Load<Texture2D>("images/quitbutton");
        highlight = contentManager.Load<Texture2D>("images/highlight");
        playButtonPos = new Vector2(100, 350);
        quitButtonPos = new Vector2(500, 350);
        highlightPos = playButtonPos;
        this.engine = engine;
        
    }   

    public void Update(GameTime gameTime)
    {
        mmCurrentKeyState = Keyboard.GetState();
        if (mmCurrentKeyState.IsKeyUp(Keys.Left) && mmPreviousKeyState.IsKeyDown(Keys.Left))
        {
            if (highlightPos == playButtonPos)
            {
                highlightPos = quitButtonPos;
            }
            else
            {
                highlightPos = playButtonPos;
            }
        }

        if (mmCurrentKeyState.IsKeyUp(Keys.Right) && (mmPreviousKeyState.IsKeyDown(Keys.Right)))
        {
            if (highlightPos == quitButtonPos)
            {
                highlightPos = playButtonPos;
            }
            else
            {
                highlightPos = quitButtonPos;
            }
        }

        if (mmCurrentKeyState.IsKeyUp(Keys.Enter) && (mmPreviousKeyState.IsKeyDown(Keys.Enter)))
        {
            if (highlightPos == playButtonPos)
            {
                this.engine.CurrentState = States.States.Game;
            }
            else
            {
                this.engine.CurrentState = States.States.GameOver;
            }
        }

        mmPreviousKeyState = mmCurrentKeyState;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(background, new Vector2(0, 0), Color.White);
        spriteBatch.Draw(playButton, playButtonPos, Color.White);
        spriteBatch.Draw(quitButton, quitButtonPos, Color.White);
        spriteBatch.Draw(highlight, highlightPos, Color.White);
    }
}