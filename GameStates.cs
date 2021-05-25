using System.Collections.Generic;
using System;
using System.Numerics;
using Raylib_cs;

public class GameStates
{
    public static Texture2D playButtonTexture = Raylib.LoadTexture(@"Images/Button.png");
    public static float buttonSize = 200;
    public static Vector2 mousePos = Raylib.GetMousePosition();
    public static Vector2 middleButton = new Vector2(Program.w / 2, Program.h / 2);
    public static Color lighterColor = new Color(70, 70, 70, 255);
    public static Sound buttonSelectSound = Raylib.LoadSound("sound.wav");
    bool leftDown = Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON);


    public void Menu()
    {
        mousePos = Raylib.GetMousePosition();
        if (mousePos.X < (Program.w / 2) + (buttonSize / 2) && mousePos.X > (Program.w / 2) - (buttonSize / 2))
        {
            Console.WriteLine(mousePos);
        }

        int cursorX = (int)mousePos.X;
        int cursorY = (int)mousePos.Y;

        Raylib.DrawCircle(cursorX, cursorY, 1, Color.BLANK);

        Raylib.DrawTexturePro(
playButtonTexture,
new Rectangle(0, 0, 512, 512), // Source
new Rectangle(middleButton.X, middleButton.Y, buttonSize, buttonSize), // Dest(ination)
new Vector2(buttonSize / 2, buttonSize / 2), // Origin
Player.rotation,
Color.WHITE);

        bool buttonSelected = Raylib.CheckCollisionCircles(middleButton, buttonSize / 2, mousePos, 1);
        if (buttonSelected == true)
        {
            Raylib.ClearBackground(lighterColor);
            buttonSize = 250;
        }
        else if (buttonSelected == true)
        {

        }
        else
        {
            Raylib.PlaySound(buttonSelectSound);
            buttonSize = 200;
        }
    }

}