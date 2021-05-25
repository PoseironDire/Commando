using System.Collections.Generic;
using System;
using Raylib_cs;

public class Program
{
    public static int w = 1840;
    public static int h = 1000;
    public static string State = "Start";
    public static List<Rectangle> rects = new List<Rectangle>();
    public static Color bg = new Color(50, 50, 50, 255);

    public static void Main(string[] args)
    {
        Raylib.InitWindow(w, h, "");
        Raylib.InitAudioDevice();
        Raylib.SetMasterVolume(1.0f);
        Raylib.SetTargetFPS(60);
        Raylib.SetExitKey(0);
        Raylib.SetWindowTitle("A Game");
        Image icon = Raylib.LoadImage(@"Images/Cola.png");
        Raylib.SetWindowIcon(icon);
        Bot Bot = new Bot();
        Player P1 = new Player();
        GameStates GameState = new GameStates();
        PlayerMovement Controller = new PlayerMovement();
        PlayerTexture Textures = new PlayerTexture();

        rects.Add(new Rectangle());

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(bg);

            if (State == "Start")
            {
                GameState.Menu();
            }
            if (State != "Start")
            {
                P1.Draw();
                Bot.AI();
                Controller.Move();
                Textures.ShowPlayer();
            }


            bool areOverlapping = Raylib.CheckCollisionCircles(Player.position, Player.playerSize / 2, Bot.position2, Player.playerSize / 2);
            if (areOverlapping == true)
            {
                Raylib.ClearBackground(Color.WHITE);
            }
            Raylib.EndDrawing();
        }
        Console.ReadKey();
    }
}

