using System;
using System.Numerics;
using Raylib_cs;

public class PlayerMovement
{
    Program Main = new Program();
    Player P1 = new Player();
    public static bool movDown, movUp, movRight, movLeft;

    public void Move()
    {

        if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            Player.position.X += Player.speed;
            movLeft = true;
        }
        else
        {
            movLeft = false;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            Player.position.X -= Player.speed;
            movRight = true;
        }
        else
        {
            movRight = false;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            Player.position.Y -= Player.speed;
            movUp = true;
        }
        else
        {
            movUp = false;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            Player.position.Y += Player.speed;
            movDown = true;
        }
        else
        {
            movDown = false;
        }
    }
}
