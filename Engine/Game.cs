using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using DungeonCrawler.Objects;
using System.Collections.Generic;


namespace DungeonCrawler.Engine;

public class Game
{
    private Engine engine;
    Player player;

    readonly List<Wall> walls = new();
    readonly List<List<string>> level = new() {
        new(){"W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W"},
        new(){"W"," ","W"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","W"},
        new(){"W"," ","W"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","W"},
        new(){"W"," ","W"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","W"},
        new(){"W"," ","W","W","W","W","W"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","W"},
        new(){"W"," "," "," "," "," ","W"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","W"},
        new(){"W"," "," "," "," "," ","W"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","W"},
        new(){"W"," "," "," "," "," ","W"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","W"},
        new(){"W"," ","W","W","W","W","W"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","W"},
        new(){"W"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","W"},
        new(){"W"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","W"},
        new(){"W"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","W"},
        new(){"W"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","W"},
        new(){"W"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","W"},
        new(){"W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W","W"}        
    };

    public Game(ContentManager contentManager, Engine engine)
    {
        this.engine = engine;
        player = new Player(contentManager, new Vector2(100, 100));
        for (int y = 0; y < level.Count; y++)
        {
            for (int x = 0; x < level[y].Count; x++)
            {
                if (level[y][x] == "W")
                {
                    Wall tempWall = new Wall(contentManager)
                    {
                        Position = new Vector2(x * 32, y * 32)
                    };
                    walls.Add(tempWall);
                }
            }
        }
    }

    public void Update(GameTime gameTime)
    {
        player.Update(gameTime);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        foreach(Wall wall in walls)
        {
            wall.Draw(spriteBatch);
        }
        player.Draw(spriteBatch);
    }
}