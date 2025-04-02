using System.Runtime.Intrinsics.Arm;

namespace PecaGame;

public partial class Form1 : Form
{
    private Pecata pecata = new Pecata(100);
    private Enemy currentEnemyMaker;
    static Random rand = new Random();
    private Svetla svetla = new Svetla(0);
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
            if (pecata.Health > 0)
            {
                currentEnemy.Text = currentEnemyMaker.Name;
                enemyhealth.Text = currentEnemyMaker.Health.ToString();
                if (rand.Next(100) < 15)
                {
                    MessageBox.Show("pecata missed! MALEEEEEEEE");
                    TakePecaDamage();
                }
                else
                {
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
                        currentEnemyMaker = null;
                    }
                }
                    
            }
            else
            {
                MessageBox.Show("NE NE O NEEEEEEE!!!");
                this.Close();
            }
        }
    }

    void FindEnemy()
    {
        currentEnemyMaker = new Enemy("desi mesi minion", 69);
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
        int rawDamage = random.Next(2, 15);
        double damageMultiplier = 100.0 / (100 + pecata.Defense); // scalable defense formula
        int reducedDamage = Convert.ToInt32(rawDamage * damageMultiplier);
    
        pecata.Health -= reducedDamage;
        updatepecahealth();
        Console.WriteLine(pecata.Health);
        return pecata.Health;
    }

    int TakeEnemyDamage()
    {
        Random random = new Random();
        int newenemyhealth = currentEnemyMaker.Health - random.Next(5, 25);
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

    private void button6_Click(object sender, EventArgs e)
    {
        svetla.FuckSvetla(pecata);
        Console.WriteLine(pecata.Defense);
    }
}