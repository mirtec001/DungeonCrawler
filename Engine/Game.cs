using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using DungeonCrawler.Objects;


namespace DungeonCrawler.Engine;

public class Game
{
    private Engine engine;
    Player player;

    public Game(ContentManager contentManager, Engine engine)
    {
        this.engine = engine;
        player = new Player(contentManager, new Vector2(100, 100));
    }

    public void Update(GameTime gameTime)
    {
        player.Update(gameTime);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        player.Draw(spriteBatch);
    }
}