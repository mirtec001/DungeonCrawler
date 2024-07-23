namespace DungeonCrawler;


public static class Globals
{
    public static ContentManager Content { get; set; }
    public static SpriteBatch SpriteBatch { get; set; }
    public static Point Bounds { get; set; }
    public static float TotalSeconds { get; set; }


    public static void Update(GameTime gameTime)
    {
        TotalSeconds = (float)gameTime.ElapsedGameTime.Seconds;
    }
}
