using System;
using System.Numerics;
using Raylib_cs;

public class PlayerTexture
{
    Player P1 = new Player();

    public void ShowPlayer()
    {

        if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            Raylib.DrawTexturePro(
            Player.playerTexture,
            new Rectangle(16, 0, 16, 16), // Source
            new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
            new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
            Player.rotation,
            Color.WHITE);
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            Raylib.DrawTexturePro(
                        Player.playerTexture,
                        new Rectangle(32, 0, 16, 16), // Source
                        new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                        new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                        Player.rotation,
                        Color.WHITE);
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            Raylib.DrawTexturePro(
                        Player.playerTexture,
                        new Rectangle(0, 16, 16, 16), // Source
                        new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                        new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                        Player.rotation,
                        Color.WHITE);
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            Raylib.DrawTexturePro(
                        Player.playerTexture,
                        new Rectangle(16, 16, 16, 16), // Source
                        new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                        new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                        Player.rotation,
                        Color.WHITE);
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            Raylib.DrawTexturePro(
            Player.playerTexture,
            new Rectangle(32, 16, 16, 16), // Source
            new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
            new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
            Player.rotation,
            Color.WHITE);
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            Raylib.DrawTexturePro(
                        Player.playerTexture,
                        new Rectangle(0, 32, 16, 16), // Source
                        new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                        new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                        Player.rotation,
                        Color.WHITE);
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            Raylib.DrawTexturePro(
                        Player.playerTexture,
                        new Rectangle(16, 32, 16, 16), // Source
                        new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                        new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                        Player.rotation,
                        Color.WHITE);
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            Raylib.DrawTexturePro(
                        Player.playerTexture,
                        new Rectangle(32, 32, 16, 16), // Source
                        new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                        new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                        Player.rotation,
                        Color.WHITE);
        }
    }
}
