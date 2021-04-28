using System;
using System.Numerics;
using Raylib_cs;

public class Program
{
    public static int w = 960;
    public static int h = 540;
    public static float screenWidth = Raylib.GetScreenWidth();
    public static float screenHeight = Raylib.GetScreenHeight();

    static void Main(string[] args)
    {
        Raylib.InitWindow(w, h, "");
        Raylib.InitAudioDevice();
        Raylib.SetTargetFPS(60);
        Raylib.SetExitKey(0);
        Raylib.SetWindowTitle("A Game");
        Image icon = Raylib.LoadImage(@"Images/Cola.png");
        Raylib.SetWindowIcon(icon);
        Player P1 = new Player();
        PlayerMovement controller = new PlayerMovement();
        PlayerTexture Textures = new PlayerTexture();

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.RED);

            P1.Draw();
            controller.Move();
            Textures.ShowPlayer();


            bool areOverlapping = Raylib.CheckCollisionCircles(Player.position, Player.playerSize / 2, Player.position2, Player.playerSize / 2);

            if (areOverlapping == true)
            {
                Raylib.ClearBackground(Color.GREEN);
            }

            Raylib.EndDrawing();
        }
        Console.ReadKey();
    }
}

