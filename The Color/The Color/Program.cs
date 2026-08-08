using System.Net.NetworkInformation;
Color color1 = new Color(145, 200, 111);
Color color2 = Color.Black;

Console.WriteLine($"({color1.R}, {color1.G}, {color1.B})");
Console.WriteLine($"({color2.R}, {color2.G}, {color2.B})");

public class Color
{
    public float R { get; }
    public float G { get; }
    public float B { get; }
    
    public Color(float r, float g, float b)
    {
        R = r; G = g; B = b;
    }

    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);
    public static Color Red { get; } = new Color(255, 0, 0);
    public static Color Orange { get; } = new Color(255, 165, 0);
    public static Color Yellow { get; } = new Color(255, 255, 0);
    public static Color Green { get; } = new Color(0, 128, 0);
    public static Color Blue { get; } = new Color(0, 0, 255);
    public static Color Purple { get; } = new Color(128, 0, 128);
}