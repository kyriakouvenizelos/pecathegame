namespace PecaGame;

public class Pecata
{
    public int Health { get; set; }
    public int Score { get;  set; }
    public int Currency { get;  set; }
    public int Strength { get;  set; }
    public int Stamina { get;  set; }
    public int Endurance { get;  set; }
    public int Intellect { get;  set; }

    public Pecata(int health)
    {
        Health = health;
        Score = 0;
        Currency = 0;
        Strength = 0;
        Stamina = 0;
        Endurance = 0;
        Intellect = 0;
    }

    public string GetStats()
    {
        return $"Pecata: Health = {Health}, Score = {Score}, Strength = {Strength}, Stamina = {Stamina}, Endurance = {Endurance}";
    }

    public void IncreaseScore(int points)
    {
        Score += points;
    }

    public void DecreaseHealth(int damage)
    {
        Health -= damage;
    }

    public void DecreaseCurrency(int amount)
    {
        Currency -= amount;
    }

    public void IncreaseStrength(int amount)
    {
        Strength += amount;
    }

    public void IncreaseStamina(int amount)
    {
        Stamina += amount;
    }

    public void IncreaseEndurance(int amount)
    {
        Endurance += amount;
    }

    public void IncreaseIntellect(int amount)
    {
        Intellect += amount;
    }

    public void DecreaseIntellect(int amount)
    {
        Intellect -= amount;
    }
}