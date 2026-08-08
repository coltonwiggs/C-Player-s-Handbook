using System.ComponentModel.Design;

Color[] colors = Enum.GetValues<Color>();
Rank[] ranks = Enum.GetValues<Rank>();
foreach (Color color in colors)
{
    foreach (Rank rank in ranks)
    {
        Console.WriteLine($"The {color} {rank}");
    }
}

Card card = new Card(Color.Red, Rank.Carat);
string type = card.GetRankType(Rank.Carat);
Console.WriteLine(type);

public class Card
{
    private Color _color { get; }
    private Rank _rank { get; }

    public Card (Color color, Rank rank)
    {
        _color = color;
        _rank = rank;
    }
    
    public string GetRankType(Rank rank)
    {
        string rankType = rank switch 
        { 
            Rank.Carat or Rank.Ampersand or Rank.Dollar or Rank.Percent => "Symbol",
            _ => "Number"
        };
        return rankType;
    }
}

public enum Color { Red, Green, Blue, Yellow }
public enum Rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Carat, Ampersand }