using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using DungeonCrawler.Objects;

public class Wall : GameObject
{
    public Vector2 Position {get; set; }
    private readonly Texture2D wallTexture;
    
    public Wall(ContentManager contentManager)
    {
        wallTexture = contentManager.Load<Texture2D>("images/wall");
    }
    
    public override void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(wallTexture, Position, Color.White);
    }

    public override void Update(GameTime gameTime)
    {
        
    }
}