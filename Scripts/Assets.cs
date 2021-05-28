using System;
using Raylib_cs;

public class Assets
{
    //Sounds
    public static Sound buttonSelectSound = Raylib.LoadSound("Sounds/sound.wav");
    public static Sound startSound = Raylib.LoadSound("Sounds/start.wav");
    public static Sound screamSound = Raylib.LoadSound("Sounds/scream.wav");
    public static Sound guideSound = Raylib.LoadSound("Sounds/guide.wav");

    //Colors
    public static Color bg = new Color(50, 50, 50, 255);
    public static Color lighterColor = new Color(70, 70, 70, 255);
    public static Color botColor = new Color(200, 0, 0, 255);
    public static Color botRadarColor = new Color(200, 0, 0, 100);
}