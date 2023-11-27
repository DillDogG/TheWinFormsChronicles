namespace TheWinFormsChronicles;

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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        constitution = new NumericUpDown();
        dexterity = new NumericUpDown();
        weaponSkill = new NumericUpDown();
        forcePower = new NumericUpDown();
        blasterPower = new NumericUpDown();
        pointsLeft = new TextBox();
        charCreate = new Button();
        charisma = new NumericUpDown();
        conTell = new TextBox();
        dexTell = new TextBox();
        weapTell = new TextBox();
        forTell = new TextBox();
        blastTell = new TextBox();
        charTell = new TextBox();
        ((System.ComponentModel.ISupportInitialize)constitution).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dexterity).BeginInit();
        ((System.ComponentModel.ISupportInitialize)weaponSkill).BeginInit();
        ((System.ComponentModel.ISupportInitialize)forcePower).BeginInit();
        ((System.ComponentModel.ISupportInitialize)blasterPower).BeginInit();
        ((System.ComponentModel.ISupportInitialize)charisma).BeginInit();
        SuspendLayout();
        // 
        // constitution
        // 
        constitution.Location = new Point(1246, 30);
        constitution.Name = "constitution";
        constitution.Size = new Size(180, 31);
        constitution.TabIndex = 0;
        constitution.ValueChanged += constitution_ValueChanged;
        // 
        // dexterity
        // 
        dexterity.Location = new Point(1246, 70);
        dexterity.Name = "dexterity";
        dexterity.Size = new Size(180, 31);
        dexterity.TabIndex = 1;
        // 
        // weaponSkill
        // 
        weaponSkill.Location = new Point(1246, 150);
        weaponSkill.Name = "weaponSkill";
        weaponSkill.Size = new Size(180, 31);
        weaponSkill.TabIndex = 2;
        // 
        // forcePower
        // 
        forcePower.Location = new Point(1246, 190);
        forcePower.Name = "forcePower";
        forcePower.Size = new Size(180, 31);
        forcePower.TabIndex = 3;
        // 
        // blasterPower
        // 
        blasterPower.Location = new Point(1246, 230);
        blasterPower.Name = "blasterPower";
        blasterPower.Size = new Size(180, 31);
        blasterPower.TabIndex = 4;
        // 
        // pointsLeft
        // 
        pointsLeft.Location = new Point(773, 70);
        pointsLeft.Name = "pointsLeft";
        pointsLeft.ReadOnly = true;
        pointsLeft.Size = new Size(150, 31);
        pointsLeft.TabIndex = 5;
        pointsLeft.Text = "Points Left: 0";
        // 
        // charCreate
        // 
        charCreate.Location = new Point(811, 110);
        charCreate.Name = "charCreate";
        charCreate.Size = new Size(112, 34);
        charCreate.TabIndex = 6;
        charCreate.Text = "Create";
        charCreate.UseVisualStyleBackColor = true;
        charCreate.Click += charCreate_Click;
        // 
        // charisma
        // 
        charisma.Location = new Point(1246, 110);
        charisma.Name = "charisma";
        charisma.Size = new Size(180, 31);
        charisma.TabIndex = 7;
        // 
        // conTell
        // 
        conTell.Location = new Point(1090, 30);
        conTell.Name = "conTell";
        conTell.ReadOnly = true;
        conTell.Size = new Size(150, 31);
        conTell.TabIndex = 8;
        conTell.Text = "Constitution: ";
        conTell.TextAlign = HorizontalAlignment.Right;
        // 
        // dexTell
        // 
        dexTell.Location = new Point(1090, 70);
        dexTell.Name = "dexTell";
        dexTell.ReadOnly = true;
        dexTell.Size = new Size(150, 31);
        dexTell.TabIndex = 9;
        dexTell.Text = "Dexterity: ";
        dexTell.TextAlign = HorizontalAlignment.Right;
        // 
        // weapTell
        // 
        weapTell.Location = new Point(1090, 150);
        weapTell.Name = "weapTell";
        weapTell.ReadOnly = true;
        weapTell.Size = new Size(150, 31);
        weapTell.TabIndex = 10;
        weapTell.Text = "Weapon Skill: ";
        weapTell.TextAlign = HorizontalAlignment.Right;
        // 
        // forTell
        // 
        forTell.Location = new Point(1090, 190);
        forTell.Name = "forTell";
        forTell.ReadOnly = true;
        forTell.Size = new Size(150, 31);
        forTell.TabIndex = 11;
        forTell.Text = "Force Power: ";
        forTell.TextAlign = HorizontalAlignment.Right;
        // 
        // blastTell
        // 
        blastTell.Location = new Point(1090, 230);
        blastTell.Name = "blastTell";
        blastTell.ReadOnly = true;
        blastTell.Size = new Size(150, 31);
        blastTell.TabIndex = 12;
        blastTell.Text = "Blaster Skill: ";
        blastTell.TextAlign = HorizontalAlignment.Right;
        // 
        // charTell
        // 
        charTell.Location = new Point(1090, 110);
        charTell.Name = "charTell";
        charTell.ReadOnly = true;
        charTell.Size = new Size(150, 31);
        charTell.TabIndex = 13;
        charTell.Text = "Charisma: ";
        charTell.TextAlign = HorizontalAlignment.Right;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1455, 680);
        Controls.Add(charTell);
        Controls.Add(blastTell);
        Controls.Add(forTell);
        Controls.Add(weapTell);
        Controls.Add(dexTell);
        Controls.Add(conTell);
        Controls.Add(charisma);
        Controls.Add(charCreate);
        Controls.Add(pointsLeft);
        Controls.Add(blasterPower);
        Controls.Add(forcePower);
        Controls.Add(weaponSkill);
        Controls.Add(dexterity);
        Controls.Add(constitution);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)constitution).EndInit();
        ((System.ComponentModel.ISupportInitialize)dexterity).EndInit();
        ((System.ComponentModel.ISupportInitialize)weaponSkill).EndInit();
        ((System.ComponentModel.ISupportInitialize)forcePower).EndInit();
        ((System.ComponentModel.ISupportInitialize)blasterPower).EndInit();
        ((System.ComponentModel.ISupportInitialize)charisma).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private NumericUpDown constitution;
    private NumericUpDown dexterity;
    private NumericUpDown weaponSkill;
    private NumericUpDown forcePower;
    private NumericUpDown blasterPower;
    private TextBox pointsLeft;
    private Button charCreate;
    private NumericUpDown charisma;
    private TextBox conTell;
    private TextBox dexTell;
    private TextBox weapTell;
    private TextBox forTell;
    private TextBox blastTell;
    private TextBox charTell;
}
