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
        Texture2D Background = Raylib.LoadTexture("recources/planken.png");


        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.White);
                Raylib.DrawTexture(Background, 0, 0, Color.White);
               
            Raylib.EndDrawing();
        }

        Raylib.UnloadTexture(Background);
        Raylib.CloseWindow();
    }
}