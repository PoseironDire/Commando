using System;
using System.Numerics;
using Raylib_cs;


public class Player
{
    Program Main = new Program();

    // Player settings
    public static float speed = 5f;
    public static float rotation;
    public static int playerSize = 100;
    public static int x = (int)position.X;
    public static int y = (int)position.Y;
    public static Vector2 position = new Vector2(Program.w / 2, Program.h / 2);

    public void Draw()
    {
        //Convert float to int
        x = (int)position.X;
        y = (int)position.Y;

        //Draw Player
        Raylib.DrawCircle(x, y, playerSize / 2, Color.BLANK);
    }
}
