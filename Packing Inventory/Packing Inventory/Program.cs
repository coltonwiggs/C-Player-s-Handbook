

using System.Runtime.CompilerServices;

public class Pack
{
    private int _itemCount;
    private double _weight;
    private double _volume;
    
    public Pack(int itemCount, double weight, double volume)
    {
        _itemCount = itemCount;
        _weight = weight;
        _volume = volume;
    }


}

public class InventoryItem
{
    private double _weight;
    private double _volume;

    public InventoryItem(double weight, double volume)
    {
        _weight = weight;
        _volume = volume;
    }


}

public class Arrow : InventoryItem
{
    public double weight;
    public double volume;
    
    public Arrow()
    {
        weight = 0.1;
    }
}