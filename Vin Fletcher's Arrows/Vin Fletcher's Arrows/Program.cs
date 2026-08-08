Arrow arrow = GetArrow();
Console.WriteLine($"That arrow costs {arrow.GetCost()} gold.");

Arrow GetArrow()
{
    ArrowheadType arrowheadType = GetArrowheadType();
    FletchingType fletchingType = GetFletchingType();
    float shaftLength = GetShaftLength();

    return new Arrow(arrowheadType, fletchingType, shaftLength);
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
    Console.Write("Enter shaft length (between 60 ad 100): ");
    float shaftLength = Convert.ToInt32(Console.ReadLine());
    return shaftLength;
}

class Arrow
{
    public ArrowheadType _arrowheadType;
    public FletchingType _fletchingType;
    public float _shaftLength;
    public Arrow(ArrowheadType arrowheadType, FletchingType fletchingType, float shaftLength)
    {
        _arrowheadType = arrowheadType;
        _fletchingType = fletchingType;
        _shaftLength = shaftLength;
    }
    public float GetCost()
    {
        float arrowheadCost = _arrowheadType switch
        {
            ArrowheadType.Steel => 10,
            ArrowheadType.Wood => 3,
            ArrowheadType.Obsidian => 5
        };

        float fletchingCost = _fletchingType switch
        {
            FletchingType.Plastic => 10,
            FletchingType.Turkey => 5,
            FletchingType.Goose => 3
        };

        float shaftCost = _shaftLength * .05f;

        return arrowheadCost + fletchingCost + shaftCost;
    }
}

enum ArrowheadType { Steel, Wood, Obsidian }
enum FletchingType { Plastic, Turkey, Goose }