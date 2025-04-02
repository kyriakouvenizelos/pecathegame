namespace PecaGame;

public partial class Form1 : Form
{
    private Pecata pecata = new Pecata(100);
    private Enemy currentEnemyMaker;
    public Form1()
    {
        InitializeComponent();
    }

    //fight
    private void button1_Click(object sender, EventArgs e)
    {
        if (currentEnemyMaker == null)
        {
            MessageBox.Show("no enemy to fight man");
        }
        else
        {
            
        }
    }

    void FindEnemy()
    {
        currentEnemyMaker = new Enemy("desi mesi minion", 100);
    }

    void KissIvailoOnTheCheek()
    {
        pecata.Health += 69;
    }

    //find enemies
    private void button2_Click(object sender, EventArgs e)
    {
        FindEnemy();
    }
}