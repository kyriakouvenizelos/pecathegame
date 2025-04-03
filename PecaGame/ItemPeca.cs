namespace PecaGame;

public class ItemPeca
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int AttackBonus { get; set; }

    public ItemPeca(string name, int price, int attackBonus)
    {
        Name = name;
        Price = price;
        AttackBonus = attackBonus;
    }
}