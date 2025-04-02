namespace PecaGame;

public class Merchant
{
    public string Name { get; private set; }
    public List<string> Items { get; private set; }

    public Merchant(string name, List<string> items)
    {
        Name = name;
        Items = items;
    }
}