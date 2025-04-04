using System.Runtime.Intrinsics.Arm;

namespace PecaGame;

public partial class Form1 : Form
{
    private Pecata pecata = new Pecata(100);
    private int killcount = 0;
    private Enemy currentEnemyMaker;
    static Random rand = new Random();
    private Svetla svetla = new Svetla(0);
    private RoomPecaGame koridor = new RoomPecaGame("koridor");
    RoomPecaGame firstetaj = new RoomPecaGame("firstetaj");
    RoomPecaGame secondetaj = new RoomPecaGame("secondetaj");
    RoomPecaGame obshtejitie = new RoomPecaGame("obshtejitie");
    RoomPecaGame staqtanakosta = new RoomPecaGame("staqtanakosta");
    RoomPecaGame hakaton = new RoomPecaGame("hakaton");
    private ItemPeca currentItemPeca = null;
    private RoomPecaGame currentPecaRoom = null;
    private bool inFight;
    public Form1()
    {
        InitializeComponent();
        updatepecahealth();
        startroom();
        GetCurrentRoom();
        
    }

    //fight
    private void button1_Click(object sender, EventArgs e)
    {
        if (currentEnemyMaker == null)
        {
            MessageBox.Show("no enemy to fight man");
            return;
        }

        if (rand.Next(100) < 15)
        {
            MessageBox.Show("pecata missed! MALEEEEEEEE");
        }
        else
        {
            TakeEnemyDamage();

            if (currentEnemyMaker.Health <= 0)
            {
                MessageBox.Show("peca won!");
                currentEnemy.Text = null;
                enemyhealth.Text = null;
                currentEnemyMaker = null;
                turnfightoff();
                updatepecahealth();
                inFight = false;
                UpdateBackgroundImage();
                killcount++;
                return;
            }
        }

        TakePecaDamage();

        if (pecata.Health <= 0)
        {
            MessageBox.Show("NE NE O NEEEEEEE!!!");
            this.Close();
        }
    }

    void FindEnemy()
    {
        if (currentPecaRoom == hakaton || currentPecaRoom == obshtejitie)
        {
            MessageBox.Show("no enemies to fight here Bro");
        }
        else
        {
            inFight = true;
            UpdateBackgroundImage();
            currentEnemyMaker = new Enemy("desi mesi minion", 69, 5);
            currentEnemy.Text = currentEnemyMaker.Name;
            enemyhealth.Text = "Health: " + currentEnemyMaker.Health.ToString();
            currentEnemy.Show();
            enemyhealth.Show();
            button1.Show();
        }
    }

    void KissIvailoOnTheCheek()
    {
        pecata.Health += 69;
    }

    //find enemies
    private void button2_Click(object sender, EventArgs e)
    {
        if (currentEnemyMaker == null)
        {
            FindEnemy();
        }

        else
        {
            MessageBox.Show("already in battle man");
        }
    }

    int TakePecaDamage()
    {
        Random random = new Random();
        int rawDamage = random.Next(2, 15) + currentEnemyMaker.Strength;
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
        int newenemyhealth = currentEnemyMaker.Health - random.Next(5, 25) - Convert.ToInt32(pecata.Strength / 3);
        currentEnemyMaker.Health = newenemyhealth;
        updateenemyhealth();
        Console.WriteLine(currentEnemyMaker.Health);
        return currentEnemyMaker.Health;
    }

    void updatepecahealth()
    {
        pecahealth.Text = "Health: " + pecata.Health.ToString();
        defenselvl.Text = "Defense: "+ pecata.Defense.ToString();
        currencyllb.Text = GetCurrencyLabel();
        attacklbl.Text = "Attack: " + pecata.Strength.ToString();
    }

    void updateenemyhealth()
    {
        enemyhealth.Text = "Health: " + currentEnemyMaker.Health.ToString();
    }

    private void button7_Click(object sender, EventArgs e)
    {
        KissIvailoOnTheCheek();
        updatepecahealth();
    }

    private void button6_Click(object sender, EventArgs e)
    {
        svetla.FuckSvetla(pecata);
        updatepecahealth();
        Console.WriteLine(pecata.Defense);
    }

    public void GetCurrentRoom()
    {
        currentRoom.Text = currentPecaRoom.Name;
    }

    public void FirstEtajRoom()
    {
        currentPecaRoom = firstetaj;
        GetCurrentRoom();
        button5.Hide();
        button6.Hide();
        this.BackgroundImage = Image.FromFile("pecathegame/etaj1.png");
        this.BackgroundImageLayout = ImageLayout.Stretch;
    }

    public void SecondEtajRoom()
    {
        currentPecaRoom = secondetaj;
        GetCurrentRoom();
        button5.Hide();
        button6.Hide();
        this.BackgroundImage = Image.FromFile("pecathegame/etaj2.png");
        this.BackgroundImageLayout = ImageLayout.Stretch;
        UpdateBackgroundImage();
    }

    public void ObshtejitieRoom()
    {
        currentPecaRoom = obshtejitie;
        GetCurrentRoom();
        button5.Hide();
        button6.Show();
        this.BackgroundImage = Image.FromFile("pecathegame/obshtejitie.png");
        this.BackgroundImageLayout = ImageLayout.Stretch;
        UpdateBackgroundImage();
    }

    public void HakatonRoom()
    {
        currentPecaRoom = hakaton;
        GetCurrentRoom();
        button5.Show();
        button6.Hide();
        this.BackgroundImage = Image.FromFile("pecathegame/merchantRoom.png");
        this.BackgroundImageLayout = ImageLayout.Stretch;
        UpdateBackgroundImage();
    }

    public void startroom()
    {
        currentPecaRoom = koridor;
        GetCurrentRoom();
        button5.Hide();
        button6.Hide();
        this.BackgroundImage = Image.FromFile("pecathegame/koridor.png");
        this.BackgroundImageLayout = ImageLayout.Stretch;
        UpdateBackgroundImage();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if(currentEnemyMaker != null)
        {
            MessageBox.Show("man no run away man come on man");
        }
        else
        {
            var stai = new Form2(this);
            stai.Show();
        }
    }

    void turnfightoff()
    {
        button1.Hide();
        pecata.Currency += rand.Next(5, 100);
        updatepecahealth();
        currentEnemy.Hide();
        enemyhealth.Hide();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        magazin magazeen = new magazin(this);
        magazeen.BackgroundImage = Image.FromFile("pecathegame/merchant.png");
        magazeen.BackgroundImageLayout = ImageLayout.Stretch;
        magazeen.Show();
    }
    public void BuyItemPeca(ItemPeca itemPeca, magazin mag)
    {
        if (pecata.Currency < itemPeca.Price)
        {
            mag.BackgroundImage = Image.FromFile("pecathegame/angryMerchant.png");
            mag.BackgroundImageLayout = ImageLayout.Stretch;
        }
        else
        {
            currentItemPeca = itemPeca;
            pecata.Strength += currentItemPeca.AttackBonus;
            pecata.Currency -= currentItemPeca.Price;
            updatepecahealth();
            mag.BackgroundImage = Image.FromFile("pecathegame/happyMerchant.png");
            mag.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
    public string GetCurrencyLabel()
    {
        return "Currency: " + pecata.Currency + " lukanki";
    }
    void UpdateBackgroundImage()
    {
        if (currentPecaRoom == null)
            return;

        // Corrected: use currentEnemyMaker, not currentEnemy
        if (currentEnemyMaker != null && inFight)
        {
            if (currentEnemyMaker.Name == "djambaza (the chocolate tooth)")
            {
                SetBackground("pecaBossDjambaza.png");
                return;
            }
            else if (currentEnemyMaker.Name == "desi mesi the terrible")
            {
                SetBackground("pecaBossDesi.png");
                return;
            }
            else if (currentEnemyMaker.Name == "gypsy from de market")
            {
                SetBackground("pecaBossCiganka.png");
                return;
            }
        }

        string baseName = currentPecaRoom.Name switch
        {
            "firstetaj" => "etaj1",
            "secondetaj" => "etaj2",
            "hakaton" => "merchantRoom",
            _ => currentPecaRoom.Name
        };

        string imageName = inFight ? $"{baseName}Battle.png" : $"{baseName}.png";
        SetBackground(imageName);
    }


    void SetBackground(string imageName)
    {
        string fullPath = $"pecathegame/{imageName}";

        if (File.Exists(fullPath))
        {
            this.BackgroundImage = Image.FromFile(fullPath);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        else
        {
            MessageBox.Show($"Image not found: {fullPath}");
        }
    }

    private void button4_Click(object sender, EventArgs e)
    {
        if (currentPecaRoom != secondetaj)
        {
            MessageBox.Show("no boss fight men");
        }
        else
        {
            if (killcount >= 25 && killcount < 35)
            {
                inFight = true;
                currentEnemyMaker = new Enemy("djambaza (the chocolate tooth)", 250, 15); // Set first
                UpdateBackgroundImage(); // THEN update background
                currentEnemy.Text = currentEnemyMaker.Name;
                enemyhealth.Text = "Health: " + currentEnemyMaker.Health.ToString();
                currentEnemy.Show();
                enemyhealth.Show();
                button1.Show();
            }
            else if (killcount >= 35 && killcount < 50)
            {
                inFight = true;
                currentEnemyMaker = new Enemy("desi mesi the terrible", 450, 30); // Set first
                UpdateBackgroundImage(); // THEN update background
                currentEnemy.Text = currentEnemyMaker.Name;
                enemyhealth.Text = "Health: " + currentEnemyMaker.Health.ToString();
                currentEnemy.Show();
                enemyhealth.Show();
                button1.Show();
            }
            else if (killcount >= 5 & killcount < 25)
            {
                inFight = true;
                currentEnemyMaker = new Enemy("gypsy from de market", 150, 10); // Set first
                UpdateBackgroundImage(); // THEN update background
                currentEnemy.Text = currentEnemyMaker.Name;
                enemyhealth.Text = "Health: " + currentEnemyMaker.Health.ToString();
                currentEnemy.Show();
                enemyhealth.Show();
                button1.Show();
            }
            else
            {
                MessageBox.Show("not enough kills nigga");
            }
        }
    }
}