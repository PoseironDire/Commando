using System.Collections.Generic;
using System;
using System.Numerics;
using Raylib_cs;

public class Menu
{
    
    public static float buttonSize = 200;
    public static bool buttonSelected;
    public static bool leftButtonPressed;
    public static bool queStart;
    public static int startDelayMaxValue = 10;
    public static int startDelayCurrentValue = 10;
    public static Vector2 mousePos = Raylib.GetMousePosition();
    public static Vector2 middleButton = new Vector2(Program.w / 2, Program.h / 2);

    public void Start()
    {
        mousePos = Raylib.GetMousePosition();
        int cursorX = (int)mousePos.X;
        int cursorY = (int)mousePos.Y;

        Raylib.DrawCircle(cursorX, cursorY, 1, Color.BLANK);

        Raylib.DrawTexturePro(
            Textures.playButtonTexture,
            new Rectangle(0, 0, 512, 512), // Source
            new Rectangle(middleButton.X, middleButton.Y, buttonSize, buttonSize), // Dest(ination)
            new Vector2(buttonSize / 2, buttonSize / 2), // Origin
            Player.rotation,
            Color.WHITE);

        leftButtonPressed = Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON);
        buttonSelected = Raylib.CheckCollisionCircles(middleButton, buttonSize / 2, mousePos, 1);
        if (buttonSelected == true && leftButtonPressed == true)
        {
            queStart = true;
            Raylib.SetSoundVolume(Assets.startSound, 0f);
            Raylib.PlaySound(Assets.startSound);
            Textures.stevePos.X -= 800;
        }
        else if (buttonSelected == true)
        {
            Raylib.SetSoundVolume(Assets.startSound, 1f);
            int spasm = Program.generator.Next(10);
            Textures.steveModifier +=spasm;
            Raylib.SetSoundVolume(Assets.buttonSelectSound, 1f);
            Raylib.ClearBackground(Assets.lighterColor);
            buttonSize = 250;
        }
        else
        {
            Raylib.SetSoundVolume(Assets.startSound, 1f);
            Textures.steveModifier = 0;
            Raylib.SetSoundVolume(Assets.buttonSelectSound, 0f);
            Raylib.PlaySound(Assets.buttonSelectSound);
            buttonSize = 200;
        }

        //Changes To Game State
        if (queStart == true)
        {
            startDelayCurrentValue--;
            if (startDelayCurrentValue <= 0)
            {
                buttonSize = 150;
                Program.State = "Game";
                startDelayCurrentValue = startDelayMaxValue;
            }
        }
    }
public void CheckWin()
{
    int distance = Player.x - Bot.x2;

        if (distance < 0)
        {
            distance *= -1;
        }
        Console.WriteLine(distance);
}
}