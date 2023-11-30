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
        constitutionDisp = new NumericUpDown();
        dexterityDisp = new NumericUpDown();
        weaponSkillDisp = new NumericUpDown();
        forcePowerDisp = new NumericUpDown();
        blasterSkillDisp = new NumericUpDown();
        pointsLeft = new TextBox();
        charCreate = new Button();
        charismaDisp = new NumericUpDown();
        conTell = new TextBox();
        dexTell = new TextBox();
        weapTell = new TextBox();
        forTell = new TextBox();
        blastTell = new TextBox();
        charTell = new TextBox();
        test = new TextBox();
        ((System.ComponentModel.ISupportInitialize)constitutionDisp).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dexterityDisp).BeginInit();
        ((System.ComponentModel.ISupportInitialize)weaponSkillDisp).BeginInit();
        ((System.ComponentModel.ISupportInitialize)forcePowerDisp).BeginInit();
        ((System.ComponentModel.ISupportInitialize)blasterSkillDisp).BeginInit();
        ((System.ComponentModel.ISupportInitialize)charismaDisp).BeginInit();
        SuspendLayout();
        // 
        // constitutionDisp
        // 
        constitutionDisp.Location = new Point(931, 18);
        constitutionDisp.Margin = new Padding(2);
        constitutionDisp.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
        constitutionDisp.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
        constitutionDisp.Name = "constitutionDisp";
        constitutionDisp.Size = new Size(63, 23);
        constitutionDisp.TabIndex = 0;
        constitutionDisp.Value = new decimal(new int[] { 8, 0, 0, 0 });
        constitutionDisp.ValueChanged += constitution_ValueChanged;
        // 
        // dexterityDisp
        // 
        dexterityDisp.Location = new Point(931, 42);
        dexterityDisp.Margin = new Padding(2);
        dexterityDisp.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
        dexterityDisp.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
        dexterityDisp.Name = "dexterityDisp";
        dexterityDisp.Size = new Size(63, 23);
        dexterityDisp.TabIndex = 1;
        dexterityDisp.Value = new decimal(new int[] { 8, 0, 0, 0 });
        // 
        // weaponSkillDisp
        // 
        weaponSkillDisp.Location = new Point(931, 90);
        weaponSkillDisp.Margin = new Padding(2);
        weaponSkillDisp.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
        weaponSkillDisp.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
        weaponSkillDisp.Name = "weaponSkillDisp";
        weaponSkillDisp.Size = new Size(63, 23);
        weaponSkillDisp.TabIndex = 2;
        weaponSkillDisp.Value = new decimal(new int[] { 8, 0, 0, 0 });
        // 
        // forcePowerDisp
        // 
        forcePowerDisp.Location = new Point(931, 114);
        forcePowerDisp.Margin = new Padding(2);
        forcePowerDisp.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
        forcePowerDisp.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
        forcePowerDisp.Name = "forcePowerDisp";
        forcePowerDisp.Size = new Size(63, 23);
        forcePowerDisp.TabIndex = 3;
        forcePowerDisp.Value = new decimal(new int[] { 8, 0, 0, 0 });
        // 
        // blasterSkillDisp
        // 
        blasterSkillDisp.Location = new Point(931, 138);
        blasterSkillDisp.Margin = new Padding(2);
        blasterSkillDisp.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
        blasterSkillDisp.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
        blasterSkillDisp.Name = "blasterSkillDisp";
        blasterSkillDisp.Size = new Size(63, 23);
        blasterSkillDisp.TabIndex = 4;
        blasterSkillDisp.Value = new decimal(new int[] { 8, 0, 0, 0 });
        // 
        // pointsLeft
        // 
        pointsLeft.Location = new Point(689, 45);
        pointsLeft.Margin = new Padding(2);
        pointsLeft.Name = "pointsLeft";
        pointsLeft.ReadOnly = true;
        pointsLeft.Size = new Size(106, 23);
        pointsLeft.TabIndex = 5;
        pointsLeft.Text = "Points Left: 27";
        // 
        // charCreate
        // 
        charCreate.Location = new Point(716, 69);
        charCreate.Margin = new Padding(2);
        charCreate.Name = "charCreate";
        charCreate.Size = new Size(78, 20);
        charCreate.TabIndex = 6;
        charCreate.Text = "Create";
        charCreate.UseVisualStyleBackColor = true;
        charCreate.Click += charCreate_Click;
        // 
        // charismaDisp
        // 
        charismaDisp.Location = new Point(931, 66);
        charismaDisp.Margin = new Padding(2);
        charismaDisp.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
        charismaDisp.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
        charismaDisp.Name = "charismaDisp";
        charismaDisp.Size = new Size(63, 23);
        charismaDisp.TabIndex = 7;
        charismaDisp.Value = new decimal(new int[] { 8, 0, 0, 0 });
        // 
        // conTell
        // 
        conTell.Location = new Point(822, 18);
        conTell.Margin = new Padding(2);
        conTell.Name = "conTell";
        conTell.ReadOnly = true;
        conTell.Size = new Size(106, 23);
        conTell.TabIndex = 8;
        conTell.Text = "Constitution: ";
        conTell.TextAlign = HorizontalAlignment.Right;
        // 
        // dexTell
        // 
        dexTell.Location = new Point(822, 42);
        dexTell.Margin = new Padding(2);
        dexTell.Name = "dexTell";
        dexTell.ReadOnly = true;
        dexTell.Size = new Size(106, 23);
        dexTell.TabIndex = 9;
        dexTell.Text = "Dexterity: ";
        dexTell.TextAlign = HorizontalAlignment.Right;
        // 
        // weapTell
        // 
        weapTell.Location = new Point(822, 90);
        weapTell.Margin = new Padding(2);
        weapTell.Name = "weapTell";
        weapTell.ReadOnly = true;
        weapTell.Size = new Size(106, 23);
        weapTell.TabIndex = 10;
        weapTell.Text = "Weapon Skill: ";
        weapTell.TextAlign = HorizontalAlignment.Right;
        // 
        // forTell
        // 
        forTell.Location = new Point(822, 114);
        forTell.Margin = new Padding(2);
        forTell.Name = "forTell";
        forTell.ReadOnly = true;
        forTell.Size = new Size(106, 23);
        forTell.TabIndex = 11;
        forTell.Text = "Force Power: ";
        forTell.TextAlign = HorizontalAlignment.Right;
        // 
        // blastTell
        // 
        blastTell.Location = new Point(822, 138);
        blastTell.Margin = new Padding(2);
        blastTell.Name = "blastTell";
        blastTell.ReadOnly = true;
        blastTell.Size = new Size(106, 23);
        blastTell.TabIndex = 12;
        blastTell.Text = "Blaster Skill: ";
        blastTell.TextAlign = HorizontalAlignment.Right;
        // 
        // charTell
        // 
        charTell.Location = new Point(822, 66);
        charTell.Margin = new Padding(2);
        charTell.Name = "charTell";
        charTell.ReadOnly = true;
        charTell.Size = new Size(106, 23);
        charTell.TabIndex = 13;
        charTell.Text = "Charisma: ";
        charTell.TextAlign = HorizontalAlignment.Right;
        // 
        // test
        // 
        test.Location = new Point(383, 262);
        test.Name = "test";
        test.Size = new Size(100, 23);
        test.TabIndex = 14;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1018, 408);
        Controls.Add(test);
        Controls.Add(charTell);
        Controls.Add(blastTell);
        Controls.Add(forTell);
        Controls.Add(weapTell);
        Controls.Add(dexTell);
        Controls.Add(conTell);
        Controls.Add(charismaDisp);
        Controls.Add(charCreate);
        Controls.Add(pointsLeft);
        Controls.Add(blasterSkillDisp);
        Controls.Add(forcePowerDisp);
        Controls.Add(weaponSkillDisp);
        Controls.Add(dexterityDisp);
        Controls.Add(constitutionDisp);
        Margin = new Padding(2);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)constitutionDisp).EndInit();
        ((System.ComponentModel.ISupportInitialize)dexterityDisp).EndInit();
        ((System.ComponentModel.ISupportInitialize)weaponSkillDisp).EndInit();
        ((System.ComponentModel.ISupportInitialize)forcePowerDisp).EndInit();
        ((System.ComponentModel.ISupportInitialize)blasterSkillDisp).EndInit();
        ((System.ComponentModel.ISupportInitialize)charismaDisp).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private NumericUpDown constitutionDisp;
    private NumericUpDown dexterityDisp;
    private NumericUpDown weaponSkillDisp;
    private NumericUpDown forcePowerDisp;
    private NumericUpDown blasterSkillDisp;
    private TextBox pointsLeft;
    private Button charCreate;
    private NumericUpDown charismaDisp;
    private TextBox conTell;
    private TextBox dexTell;
    private TextBox weapTell;
    private TextBox forTell;
    private TextBox blastTell;
    private TextBox charTell;
    private TextBox test;
}
