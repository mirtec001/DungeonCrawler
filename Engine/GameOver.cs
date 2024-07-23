
namespace DungeonCrawler.Engine;

public class GameOver
{

    private Texture2D gameOver;
    private float WaitToShowMainMenu = 5;
    Engine engine;

    public GameOver(Engine engine)
    {
        gameOver = Globals.Content.Load<Texture2D>("images/gameover");
        this.engine = engine;
        Console.WriteLine("GameOver created");
    }

    public void Update()
    {
        if (WaitToShowMainMenu > 0)
        {
            WaitToShowMainMenu -= Globals.TotalSeconds;
            if (WaitToShowMainMenu <= 0)
            {
                this.engine.CurrentState = States.States.MainMenu;
            }
        }
    }

    public void Draw()
    {
        Globals.SpriteBatch.Draw(gameOver, new Vector2(0, 0), Color.White);
    }
}
