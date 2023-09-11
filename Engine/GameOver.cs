using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace DungeonCrawler.Engine;

public class GameOver
{

    private Texture2D gameOver;
    private float WaitToShowMainMenu = 5;
    Engine engine;

    public GameOver(ContentManager contentManager, Engine engine)
    {   
        gameOver = contentManager.Load<Texture2D>("images/gameover");
        this.engine = engine;
        Console.WriteLine("GameOver created");
    }

    public void Update(GameTime gameTime)
    {
        if (WaitToShowMainMenu > 0)
        {
            WaitToShowMainMenu -= (float) gameTime.ElapsedGameTime.TotalSeconds;
            if (WaitToShowMainMenu <= 0)
            {
                this.engine.CurrentState = States.States.MainMenu; 
            }
        }
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(gameOver, new Vector2(0, 0), Color.White);
    }
}