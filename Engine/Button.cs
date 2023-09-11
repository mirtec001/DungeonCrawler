using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


public class Button
{
    private Texture2D texture;
    private Vector2 position;
    public Button(ContentManager contentManager, string textureTitle, Vector2 position)
    {
        this.position = position;
        texture = contentManager.Load<Texture2D>(textureTitle);
    }

    public void Update(GameTime gameTime)
    {

    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(texture, position, Color.White);
    }
}