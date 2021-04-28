using System;
using System.Numerics;
using Raylib_cs;


public class Player
{
    Program Main = new Program();

    public static float speed = 5f;
    public static float rotation;
    public static float velocityDown;
    public static float playerSize = 100;
    public static Vector2 position = new Vector2(Program.w / 2, Program.h / 2);
    public static Vector2 position2 = new Vector2(Program.w / 2 + 200, Program.h / 2);
    public static Texture2D playerTexture = Raylib.LoadTexture(@"drone.png");

    public void Draw()
    {
        int x = (int)position.X;
        int y = (int)position.Y;
        int x2 = (int)position2.X;
        int y2 = (int)position2.Y;

        Raylib.DrawCircle(x2, y2, playerSize / 2, Color.BLUE);

        if (PlayerMovement.movDown == false && PlayerMovement.movUp == false && PlayerMovement.movLeft == false && PlayerMovement.movRight == false)
        {
            Raylib.DrawTexturePro(
            playerTexture,
            new Rectangle(0, 0, 16, 16), // Source
            new Rectangle(position.X, position.Y, playerSize, playerSize), // Dest(ination)
            new Vector2(playerSize / 2, playerSize / 2), // Origin
            rotation,
            Color.WHITE);
            Raylib.DrawCircle(x, y, playerSize / 2, Color.BLANK);
        }
    }
}
