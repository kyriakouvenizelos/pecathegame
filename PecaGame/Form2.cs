namespace PecaGame;

public partial class Form2 : Form
{
    Form1 _mainForm;
    public Form2(Form1 mainForm)
    {
        InitializeComponent();
        _mainForm = mainForm;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        _mainForm.startroom();
        this.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        _mainForm.FirstEtajRoom();
        this.Close();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        _mainForm.SecondEtajRoom();
        this.Close();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        _mainForm.HakatonRoom();
        this.Close();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        _mainForm.ObshtejitieRoom();
        this.Close();
    }
}