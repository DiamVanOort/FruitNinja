using System.Numerics;
using Raylib_cs;

namespace MyScene;

class Program
{
    public static void Main()
    {
        int screenWidth =  1920;
        int screenHeight =  1080;

        Raylib.InitWindow(screenWidth, screenHeight, "Fruit Ninja");

        Texture2D texture = Raylib.LoadTexture("recources/Aardbei.png"); 

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.White);
                Raylib.DrawTexture(texture, screenWidth/2 - texture.Width/2, screenHeight/2 - texture.Height/2, Color.White);

            Raylib.EndDrawing();
        }

        Raylib.UnloadTexture(texture); 

        Raylib.CloseWindow();
    }
}