namespace DungeonCrawler.Engine;

public class Engine
{
    public States.States CurrentState { get; set; }

    private MainMenu MainMenu;
    private Game Game;
    private GameOver GameOver;


    public void Initialize()
    {
        MainMenu = new MainMenu(this);
        Game = new Game(this);
        GameOver = new GameOver(this);

    }

    public void Update()
    {
        switch (CurrentState)
        {
            case States.States.MainMenu:
                MainMenu.Update();
                break;
            case States.States.Game:
                Game.Update();
                break;
            case States.States.GameOver:
                GameOver.Update();
                break;
        }
    }

    public void Draw()
    {
        switch (CurrentState)
        {
            case States.States.MainMenu:
                MainMenu.Draw();
                break;
            case States.States.Game:
                Game.Draw();
                break;
            case States.States.GameOver:
                GameOver.Draw();
                break;
        }
    }
}
