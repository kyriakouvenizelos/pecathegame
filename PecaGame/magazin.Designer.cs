﻿using System.ComponentModel;

namespace PecaGame;

partial class magazin
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
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(12, 339);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(204, 102);
        button1.TabIndex = 0;
        button1.Text = "burkan s prudnqta na ivailo - 100";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(222, 339);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(204, 102);
        button2.TabIndex = 1;
        button2.Text = "kukla debelana - 500";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(432, 339);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(204, 102);
        button3.TabIndex = 2;
        button3.Text = "himikal - 1000";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // magazin
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(653, 450);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Text = "magazin";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    #endregion
}