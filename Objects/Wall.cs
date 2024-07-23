namespace DungeonCrawler.Objects;

public class Wall : GameObject
{
    public Vector2 Position { get; set; }
    private readonly Texture2D wallTexture;

    public Wall()
    {
        wallTexture = Globals.Content.Load<Texture2D>("images/wall");
    }

    public override void Draw()
    {
        Globals.SpriteBatch.Draw(wallTexture, Position, Color.White);
    }

    public override void Update()
    {

    }
}
