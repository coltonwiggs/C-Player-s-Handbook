using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

int ArrowChoice()
{
    int choice;
    Console.WriteLine("What arrow would you like?");
    Console.WriteLine("1 - Elite Arrow");
    Console.WriteLine("2 - Beginner Arrow");
    Console.WriteLine("3 - Marksman Arrow");
    Console.WriteLine("4 - Custom Arrow");
    Console.Write("Choice: ");
    choice = Convert.ToInt32(Console.ReadLine());
    return choice;
}

Arrow arrow = GetArrow();
Console.WriteLine($"That arrow costs {arrow.Cost} gold.");

Arrow GetArrow()
{
    int arrowheadChoice = ArrowChoice();
    switch (arrowheadChoice)
    {
        case 1:
            return Arrow.CreateEliteArrow();
        case 2:
            return Arrow.CreateBeginnerArrow();
        case 3:
            return Arrow.CreateMarksmanArrow();
        case 4:
            ArrowheadType arrowheadType = GetArrowheadType();
            FletchingType fletchingType = GetFletchingType();
            float shaftLength = GetShaftLength();
            return new Arrow(arrowheadType, fletchingType, shaftLength);
        default:
            return null;
    }
}

ArrowheadType GetArrowheadType()
{
    Console.Write("Enter arrowhead type (steel, wood, or obsidian): ");
    string arrowheadType = Console.ReadLine();
    return arrowheadType switch
    {
        "steel" => ArrowheadType.Steel,
        "wood" => ArrowheadType.Wood,
        "obsidian" => ArrowheadType.Obsidian
    };
}

FletchingType GetFletchingType()
{
    Console.Write("Enter fletching type (plastic, turkey feathers, or goose feathers): ");
    string fletchingType = Console.ReadLine();
    return fletchingType switch
    {
        "plastic" => FletchingType.Plastic,
        "turkey" => FletchingType.Turkey,
        "goose" => FletchingType.Goose
    };
}

float GetShaftLength()
{
    float length = 0;

    while (length < 60 || length > 100)
    {
        Console.Write("Enter shaft length (between 60 ad 100): ");
        length = Convert.ToInt32(Console.ReadLine());
    }
    return length;
}

public class Arrow
{
    public ArrowheadType ArrowheadType { get; }
    public FletchingType FletchingType { get; }
    public float Length { get; }

    public Arrow(ArrowheadType arrowheadType, FletchingType fletchingType, float shaftLength)
    {
        ArrowheadType = arrowheadType;
        FletchingType = fletchingType;
        Length = shaftLength;
    }

    public float Cost
    {
        get
        {
            float arrowheadCost = ArrowheadType switch
            {
                ArrowheadType.Steel => 10,
                ArrowheadType.Wood => 3,
                ArrowheadType.Obsidian => 5
            };

            float fletchingCost = FletchingType switch
            {
                FletchingType.Plastic => 10,
                FletchingType.Turkey => 5,
                FletchingType.Goose => 3
            };

            float shaftCost = Length * .05f;

            return arrowheadCost + fletchingCost + shaftCost;
        }
    }

    public static Arrow CreateEliteArrow() => new Arrow(ArrowheadType.Steel, FletchingType.Plastic, 95);
    public static Arrow CreateBeginnerArrow() => new Arrow(ArrowheadType.Wood, FletchingType.Goose, 75);
    public static Arrow CreateMarksmanArrow() => new Arrow(ArrowheadType.Steel, FletchingType.Goose, 65);
}

public enum ArrowheadType { Steel, Wood, Obsidian }
public enum FletchingType { Plastic, Turkey, Goose }