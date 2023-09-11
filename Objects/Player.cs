using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DungeonCrawler.Objects;

public class Player : GameObject
{
    Texture2D texture;
    Vector2 position;
    Vector2 size;

    public Player(ContentManager contentManager, Vector2 position)
    {
        texture = contentManager.Load<Texture2D>("images/player");
        size = new Vector2(texture.Width, texture.Height);
    }
    public override void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(texture, position, Color.White);
    }

    public override void Update(GameTime gameTime)
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