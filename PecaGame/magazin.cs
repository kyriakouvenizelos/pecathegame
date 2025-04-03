namespace PecaGame;

public partial class magazin : Form
{
    Form1 _mainForm;
    ItemPeca itemPeca = null;
    private Pecata pecata;
    public magazin(Form1 mainForm)
    {
        InitializeComponent();
        _mainForm = mainForm;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        itemPeca = new ItemPeca("prudnq", 100, 5);
        _mainForm.BuyItemPeca(itemPeca, this);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        itemPeca = new ItemPeca("kukla debelana", 500, 10);
        _mainForm.BuyItemPeca(itemPeca, this);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        itemPeca = new ItemPeca("himikal (ne pishe)", 1000, -10);
        _mainForm.BuyItemPeca(itemPeca, this);
    }
}