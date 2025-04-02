namespace PecaGame;

public class Enemy
{
    public string Name { get;  set; }
    public int Health { get;  set; }

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