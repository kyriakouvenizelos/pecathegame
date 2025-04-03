using System.ComponentModel;

namespace PecaGame;

partial class Form2
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        button5 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(19, 11);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 23);
        button1.TabIndex = 0;
        button1.Text = "koridor";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(19, 40);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(75, 23);
        button2.TabIndex = 1;
        button2.Text = "etaj 1";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(19, 69);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(75, 23);
        button3.TabIndex = 2;
        button3.Text = "etaj 2";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Location = new System.Drawing.Point(19, 98);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(75, 23);
        button4.TabIndex = 3;
        button4.Text = "hakaton";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button5
        // 
        button5.Location = new System.Drawing.Point(19, 127);
        button5.Name = "button5";
        button5.Size = new System.Drawing.Size(75, 23);
        button5.TabIndex = 4;
        button5.Text = "obshtejitie";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // Form2
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(120, 168);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Text = "Form2";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;

    #endregion
}