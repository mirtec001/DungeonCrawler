namespace DungeonCrawler.Objects;

public class Player : GameObject
{
    Texture2D texture;
    Vector2 position;
    Vector2 size;

    public Player(Vector2 position)
    {
        texture = Globals.Content.Load<Texture2D>("images/player");
        size = new Vector2(texture.Width, texture.Height);
    }
    public override void Draw()
    {
        Globals.SpriteBatch.Draw(texture, position, Color.White);
    }

    public override void Update()
    {
        KeyboardState currentState = Keyboard.GetState();

        if (currentState.IsKeyDown(Keys.A))
        {
            position.X--;
        }
        if (currentState.IsKeyDown(Keys.D))
        {
            position.X++;
        }
        if (currentState.IsKeyDown(Keys.S))
        {
            position.Y++;
        }
        if (currentState.IsKeyDown(Keys.W))
        {
            position.Y--;
        }
    }

}
