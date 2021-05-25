using System;
using System.Numerics;
using Raylib_cs;

public class PlayerTexture
{
    Player P1 = new Player();
    public static Texture2D playerTexture = Raylib.LoadTexture(@"drone.png");

    public void ShowPlayer()
    {
        if (PlayerMovement.movDown == false && PlayerMovement.movUp == false && PlayerMovement.movLeft == false && PlayerMovement.movRight == false)
        {
            Raylib.DrawTexturePro(
            playerTexture,
            new Rectangle(0, 0, 16, 16), // Source
            new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
            new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
            Player.rotation,
            Color.WHITE);
        }
        else
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                Raylib.DrawTexturePro(
                playerTexture,
                new Rectangle(16, 0, 16, 16), // Source
                new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                Player.rotation,
                Color.WHITE);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                Raylib.DrawTexturePro(
                            playerTexture,
                            new Rectangle(32, 0, 16, 16), // Source
                            new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                            new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                            Player.rotation,
                            Color.WHITE);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                Raylib.DrawTexturePro(
                            playerTexture,
                            new Rectangle(0, 16, 16, 16), // Source
                            new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                            new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                            Player.rotation,
                            Color.WHITE);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                Raylib.DrawTexturePro(
                            playerTexture,
                            new Rectangle(16, 16, 16, 16), // Source
                            new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                            new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                            Player.rotation,
                            Color.WHITE);
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                Raylib.DrawTexturePro(
                playerTexture,
                new Rectangle(32, 16, 16, 16), // Source
                new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                Player.rotation,
                Color.WHITE);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                Raylib.DrawTexturePro(
                            playerTexture,
                            new Rectangle(0, 32, 16, 16), // Source
                            new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                            new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                            Player.rotation,
                            Color.WHITE);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                Raylib.DrawTexturePro(
                            playerTexture,
                            new Rectangle(16, 32, 16, 16), // Source
                            new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                            new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                            Player.rotation,
                            Color.WHITE);
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                Raylib.DrawTexturePro(
                            playerTexture,
                            new Rectangle(32, 32, 16, 16), // Source
                            new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                            new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                            Player.rotation,
                            Color.WHITE);
            }
        }
    }
}