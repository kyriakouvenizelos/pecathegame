namespace PecaGame;

public class Svetla
{
    public int FuckCount { get; set; }

    public Svetla(int fuckCount)
    {
        FuckCount = fuckCount;
    }

    public void FuckSvetla(Pecata pecata)
    {
        FuckCount++;
        pecata.Defense += FuckCount * 2;
    }
}