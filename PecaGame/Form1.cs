namespace PecaGame;

public partial class Form1 : Form
{
    private Pecata pecata = new Pecata(100);
    private Enemy currentEnemyMaker;
    public Form1()
    {
        InitializeComponent();
        updatepecahealth();
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
            currentEnemy.Text = currentEnemyMaker.Name;
            enemyhealth.Text = currentEnemyMaker.Health.ToString();
            if (currentEnemyMaker.Health > 0)
            {
                TakeEnemyDamage();
                TakePecaDamage();
            }
            else
            {
                MessageBox.Show("peca won!");
                currentEnemy.Text = null;
                enemyhealth.Text = null;
            }
        }
    }

    void FindEnemy()
    {
        currentEnemyMaker = new Enemy("desi mesi minion", 150);
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

    int TakePecaDamage()
    {
        Random random = new Random();
        int pecanewhealth = pecata.Health - random.Next(1, 20);
        pecata.Health = pecanewhealth;
        updatepecahealth();
        Console.WriteLine(pecata.Health);
        return pecata.Health;
    }

    int TakeEnemyDamage()
    {
        Random random = new Random();
        int newenemyhealth = currentEnemyMaker.Health - random.Next(1, 20);
        currentEnemyMaker.Health = newenemyhealth;
        updateenemyhealth();
        Console.WriteLine(currentEnemyMaker.Health);
        return currentEnemyMaker.Health;
    }

    void updatepecahealth()
    {
        pecahealth.Text = pecata.Health.ToString();
    }

    void updateenemyhealth()
    {
        enemyhealth.Text = currentEnemyMaker.Health.ToString();
    }

    private void button7_Click(object sender, EventArgs e)
    {
        KissIvailoOnTheCheek();
        updatepecahealth();
    }
}