using Raylib_cs;

public class PlayerMovement
{
    public static bool movDown, movUp, movRight, movLeft;

    public void Move()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            movLeft = true;
        }
        else
        {
            movLeft = false;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && Player.x < Program.w - Player.playerSize / 2)
        {
            Player.position.X += Player.speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && Player.x > 0 + Player.playerSize / 2)
        {
            Player.position.X -= Player.speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            movRight = true;
        }
        else
        {
            movRight = false;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W) && Player.y > 0 + Player.playerSize / 2)
        {
            Player.position.Y -= Player.speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            movUp = true;
        }
        else
        {
            movUp = false;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S) && Player.y < Program.h - Player.playerSize / 2)
        {
            Player.position.Y += Player.speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            movDown = true;
        }
        else
        {
            movDown = false;
        }
    }
}
