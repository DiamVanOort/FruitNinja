using System.Numerics;
using Raylib_cs;

public class Entity
{
    // Position
    public Vector2 Position;

    // Size
    public Vector2 Scale;

    // Texture
    private Texture2D _texture;

    // Constructor
    public Entity(string imagePath, float x, float y, float width, float height)
    {
        Position = new Vector2(x, y);
        Scale = new Vector2(width, height);
        _texture = Raylib.LoadTexture(imagePath);
    }

    // Update method (called every frame)
    public virtual void Update()
    {
        // Update logic here
    }

    // Draw method (called every frame)
    public void Draw()
    {
        Raylib.DrawTexture(_texture, (int)Position.X, (int)Position.Y, Color.White);
    }

    // Dispose method (call when the entity is destroyed)
    public void Dispose()
    {
        Raylib.UnloadTexture(_texture);
    }
}
