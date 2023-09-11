using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DungeonCrawler;

public class Game1 : Game
{
    private Engine.Engine engine;
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        engine = new Engine.Engine();
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        engine.ContentManager = Content;
        engine.CurrentState = States.States.MainMenu;
        engine.Initialize();
        

        base.Initialize();
    }
 
    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        engine.SpriteBatch = _spriteBatch;
        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here
        base.Update(gameTime);
        engine.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        _spriteBatch.Begin();
        engine.Draw();
        _spriteBatch.End();
        // TODO: Add your drawing code here
        base.Draw(gameTime);
    }
}
