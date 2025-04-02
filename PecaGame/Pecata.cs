namespace PecaGame;

public class Pecata
{
    public int Health { get; set; }
    public int Currency { get;  set; }
    public int Strength { get;  set; }
    public int Defense { get;  set; }

    public Pecata(int health)
    {
        Health = health;
        Currency = 0;
        Strength = 0;
        Defense = 1;
    }
    
    public void DecreaseCurrency(int amount)
    {
        Currency -= amount;
    }

    public void IncreaseStrength(int amount)
    {
        Strength += amount;
    }

    public void IncreaseEndurance(int amount)
    {
        Defense += amount;
    }
}