using System;
using System.Numerics;
using Raylib_cs;


public class Bot
{
    Program Main = new Program();

    // Bot settings
    public static int x2 = (int)position2.X;
    public static int y2 = (int)position2.Y;
    public static float GetXPos = x2;
    public static float GetYPos = y2;
    public static float autoX;
    public static float autoY;
    public static bool resetPos = false;
    public static int i = 0;
    public static Vector2 position2 = new Vector2(Program.w / 2 + 200, Program.h / 2);
    Random generator = new Random();
    Color botColor = new Color(200, 0, 0, 255);
    Color botRadarColor = new Color(200, 0, 0, 100);

    public void AI()
    {
        //Convert float to int
        x2 = (int)position2.X;
        y2 = (int)position2.Y;

        //Random bot speed
        if (Program.State == "Game")
        {

            if (resetPos == false)
            {
                i++;
                if (i == 10)
                {
                    autoX = generator.Next(-10, 10);
                    autoY = generator.Next(-10, 10);
                    i = 0;
                }
                Bot.position2.X += autoX;
                Bot.position2.Y += autoY;
            }
            else
            {
                Bot.position2.X += autoX;
                Bot.position2.Y += autoY;
            }
            if (Bot.position2.X > Program.w / 2 || Bot.position2.Y > Program.h / 2)
            {
                resetPos = false;
            }

            if (position2.X < Player.playerSize / 2)
            {
                resetPos = true;
                GetXPos = x2;
                autoX = ((GetXPos / Program.w) + 15);
            }
            if (position2.X > Program.w - Player.playerSize / 2)
            {
                resetPos = true;
                GetXPos = x2;
                autoX = ((GetXPos / Program.w) - 15);
            }
            if (position2.Y < Player.playerSize / 2)
            {
                resetPos = true;
                GetYPos = y2;
                autoY = ((GetYPos / Program.h) + 15);
            }
            if (position2.Y > Program.h - Player.playerSize / 2)
            {
                resetPos = true;
                GetYPos = y2;
                autoY = ((GetYPos / Program.h) - 15);
            }
        }
        //Draw Bot
        Raylib.DrawCircle(x2, y2, Player.playerSize * 2, botRadarColor);
        Raylib.DrawCircle(x2, y2, Player.playerSize / 2, botColor);
    }
}
