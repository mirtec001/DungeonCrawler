using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace DungeonCrawler.Engine;

public class Engine
{
    public States.States CurrentState { get; set; }
    public ContentManager ContentManager { get; set; }
    public SpriteBatch SpriteBatch { get; set; }
    
    private MainMenu MainMenu;
    private Game Game;
    private GameOver GameOver;

    
    public void Initialize()
    {
        MainMenu = new MainMenu(ContentManager, this);
        Game = new Game(ContentManager, this);
        GameOver = new GameOver(ContentManager, this);
        
    }

    public void Update(GameTime gameTime)
    {
        switch (CurrentState)
        {
            case States.States.MainMenu:
                MainMenu.Update(gameTime);
                break;
            case States.States.Game:
                Game.Update(gameTime);
                break;
            case States.States.GameOver:
                GameOver.Update(gameTime);
                break;
        }
    }

    public void Draw()
    {
        switch (CurrentState)
        {
            case States.States.MainMenu:
                MainMenu.Draw(SpriteBatch);
                break;
            case States.States.Game:
                Game.Draw(SpriteBatch);
                break;
            case States.States.GameOver:
                GameOver.Draw(SpriteBatch);
                break;
        }
    }
}