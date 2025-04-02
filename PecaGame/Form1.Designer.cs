namespace PecaGame;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        button5 = new System.Windows.Forms.Button();
        button6 = new System.Windows.Forms.Button();
        currentRoom = new System.Windows.Forms.Label();
        currentEnemy = new System.Windows.Forms.Label();
        pecahealth = new System.Windows.Forms.Label();
        enemyhealth = new System.Windows.Forms.Label();
        button7 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(8, 376);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(152, 65);
        button1.TabIndex = 0;
        button1.Text = "Fight";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(166, 376);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(151, 65);
        button2.TabIndex = 1;
        button2.Text = "Run in the apartment";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(323, 376);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(164, 65);
        button3.TabIndex = 2;
        button3.Text = "Next location";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new System.Drawing.Point(702, 7);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(160, 65);
        button4.TabIndex = 3;
        button4.Text = "boss fight";
        button4.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        button5.Location = new System.Drawing.Point(493, 376);
        button5.Name = "button5";
        button5.Size = new System.Drawing.Size(183, 65);
        button5.TabIndex = 4;
        button5.Text = "merchant";
        button5.UseVisualStyleBackColor = true;
        // 
        // button6
        // 
        button6.Location = new System.Drawing.Point(682, 376);
        button6.Name = "button6";
        button6.Size = new System.Drawing.Size(180, 65);
        button6.TabIndex = 5;
        button6.Text = "sex with svetla";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // currentRoom
        // 
        currentRoom.Location = new System.Drawing.Point(8, 7);
        currentRoom.Name = "currentRoom";
        currentRoom.Size = new System.Drawing.Size(100, 23);
        currentRoom.TabIndex = 6;
        // 
        // currentEnemy
        // 
        currentEnemy.Location = new System.Drawing.Point(323, 148);
        currentEnemy.Name = "currentEnemy";
        currentEnemy.Size = new System.Drawing.Size(164, 23);
        currentEnemy.TabIndex = 7;
        // 
        // pecahealth
        // 
        pecahealth.Location = new System.Drawing.Point(166, 347);
        pecahealth.Name = "pecahealth";
        pecahealth.Size = new System.Drawing.Size(151, 26);
        pecahealth.TabIndex = 8;
        // 
        // enemyhealth
        // 
        enemyhealth.Location = new System.Drawing.Point(323, 171);
        enemyhealth.Name = "enemyhealth";
        enemyhealth.Size = new System.Drawing.Size(100, 23);
        enemyhealth.TabIndex = 9;
        // 
        // button7
        // 
        button7.Location = new System.Drawing.Point(8, 296);
        button7.Name = "button7";
        button7.Size = new System.Drawing.Size(152, 74);
        button7.TabIndex = 10;
        button7.Text = "kiss ivailo";
        button7.UseVisualStyleBackColor = true;
        button7.Click += button7_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackgroundImage = ((System.Drawing.Image)resources.GetObject("$this.BackgroundImage"));
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        ClientSize = new System.Drawing.Size(867, 450);
        Controls.Add(button7);
        Controls.Add(enemyhealth);
        Controls.Add(pecahealth);
        Controls.Add(currentEnemy);
        Controls.Add(currentRoom);
        Controls.Add(button6);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button7;

    private System.Windows.Forms.Label enemyhealth;

    private System.Windows.Forms.Label pecahealth;

    private System.Windows.Forms.Label currentRoom;
    private System.Windows.Forms.Label currentEnemy;

    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;

    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    #endregion
}