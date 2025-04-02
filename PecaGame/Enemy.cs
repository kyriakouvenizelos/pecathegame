namespace PecaGame;

public class Enemy
{
    public string Name { get; private set; }
    public int Health { get; private set; }

    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void DecreaseHealth(int damage)
    {
        Health -= damage;
    }
}